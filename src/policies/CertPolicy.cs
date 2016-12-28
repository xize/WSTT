/*

A security toolkit for windows    

    Copyright(C) 2016 Guido Lucassen

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class CertPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "makes it easier for people to remove bogus root certificates, however user control is required\nit will open notepad which you can edit the entries you remove will not be removed";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.CERT_POLICY;
        }

        public override bool isEnabled()
        {
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            if(!isInstalled())
            {
                Directory.CreateDirectory(getDataFolder() + @"\sigcheck");
                installForFirstTime("sigcheck");
                installForFirstTime("sigcheck64");
                installForFirstTime("sigcheckeula");
            }

            Process proc;

            if(Environment.Is64BitOperatingSystem)
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c " + getDataFolder() + @"\sigcheck\sigcheck.exe -tv > " + getDataFolder() + @"\sigcheck\badcerts.txt";
                proc = Process.Start(sinfo);
            } else
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c "+getDataFolder() + @"\sigcheck\sigcheck.exe -tv > "+getDataFolder()+@"\sigcheck\badcerts.txt";
                proc = Process.Start(sinfo);
            }

            while (!proc.HasExited) { } //lock the thread

            ProcessStartInfo notepad = new ProcessStartInfo("notepad.exe");
            notepad.Arguments = getDataFolder()+@"\sigcheck\badcerts.txt";

            DialogResult result = MessageBox.Show("Please remove the entries which you don't want to be removed.\n\nall the following certificates in this notepad are untrusted root certificates or root certificates not signed by Microsoft.\n\nthings like \"DELL\", \"Anti Virus\", should be removed this will increase your security against man in the middle attacks however some anti virus solutions use it to scan encrypted connections.\n\n do this at your own risk you cannot undo this option!", "Important please read!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                if(File.Exists(getDataFolder() + @"\sigcheck\badcerts.txt"))
                {
                    File.Delete(getDataFolder() + @"\sigcheck\badcerts.txt");
                }
                return;
            }

            Process notepadproc = Process.Start(notepad);

            while(!notepadproc.HasExited) {} //lock

            IEnumerable<string> lines = File.ReadLines(getDataFolder() + @"\sigcheck\badcerts.txt");
            string linestext = "";
            foreach (string line in lines)
            {
                if(line.Contains("   ")) //3 spaces... I don't understand why: ^([\w\s]{3})+[a-zA-Z0-9\\\/\-]$ does not work....
                {
                    string strippedline = line.Substring(2, line.Length-2);
                    linestext += strippedline+"\n";
                    ProcessStartInfo certutilinfo = new ProcessStartInfo("certutil.exe");
                    certutilinfo.Arguments = "-delstore Root " +"\""+strippedline+"\"";
                    Process certutil = Process.Start(certutilinfo);
                    while(!certutil.HasExited){} //lock the thread
                    certutil.Dispose();
                }
            }

            //cleanup
            proc.Dispose();
            notepadproc.Dispose();

            MessageBox.Show("success the following certificates have been removed.\n=====================================================\n" + linestext);
            getProgressbar().Value = 100;
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            
        }

        public bool isInstalled()
        {
            return Directory.Exists(getDataFolder() + @"\sigcheck");
        }

        public void installForFirstTime(string resource)
        {
            string path = getDataFolder() + @"\sigcheck";

            switch(resource)
            {
                case "sigcheck":
                    File.WriteAllBytes(path+@"\sigcheck.exe", Properties.Resources.sigcheck);
                    break;
                case "sigcheck64":
                    File.WriteAllBytes(path + @"\sigcheck64.exe", Properties.Resources.sigcheck64);
                    break;
                case "sigcheckeula":
                    File.WriteAllBytes(path + @"\Eula.txt", Properties.Resources.sigcheckeula);
                    break;
            }
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return true;
        }

        public override Button getButton()
        {
            return gui.boguscertbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.boguscertprogress;
        }
    }
}
