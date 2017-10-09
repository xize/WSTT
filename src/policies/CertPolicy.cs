/*
    A security toolkit for windows    

    Copyright(C) 2016-2017 Guido Lucassen

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

namespace windows_security_tweak_tool.src.policies
{
    class CertPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "makes it easier for people to remove bogus root certificates, however user control is required\nit will open notepad which you can edit the entries you remove will not be removed";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.CERT_POLICY;
        }

        public override bool IsEnabled()
        {
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;
            await Task.Run(() => ApplyAsync());
            GetProgressbar().Value = 100;
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            if (!IsInstalled())
            {
                Directory.CreateDirectory(GetDataFolder() + @"\sigcheck");
                InstallForFirstTime("sigcheck");
                InstallForFirstTime("sigcheck64");
                InstallForFirstTime("sigcheckeula");
            }

            ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
            sinfo.Arguments = "/c " + GetDataFolder() + @"\sigcheck\sigcheck" + (Environment.Is64BitOperatingSystem ? "64" : "") + ".exe -tv > "+GetDataFolder()+@"\sigcheck\badcerts.txt";
            Process proc = Process.Start(sinfo);

            proc.WaitForExit();
            proc.Close();
            proc.Dispose();

            ProcessStartInfo notepad = new ProcessStartInfo("notepad.exe");
            notepad.Arguments = GetDataFolder() + @"\sigcheck\badcerts.txt";

            DialogResult result = MessageBox.Show("Please remove the entries which you don't want to be removed.\n\nall the following certificates in this notepad are untrusted root certificates or root certificates not signed by Microsoft.\n\nthings like \"DELL\", \"Anti Virus\", should be removed this will increase your security against man in the middle attacks however some anti virus solutions use it to scan encrypted connections.\n\n do this at your own risk you cannot undo this option!", "Important please read!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                if (File.Exists(GetDataFolder() + @"\sigcheck\badcerts.txt"))
                {
                    File.Delete(GetDataFolder() + @"\sigcheck\badcerts.txt");
                }
                return;
            }

            Process notepadproc = Process.Start(notepad);

            notepadproc.WaitForExit();
            notepadproc.Close();
            notepadproc.Dispose();

            IEnumerable<string> lines = File.ReadLines(GetDataFolder() + @"\sigcheck\badcerts.txt");
            string linestext = "";

            Regex r = new Regex(@"^\s\s\s+"); //force first 3 spaces use + to make sure it should match anything else

            foreach (string line in lines)
            {
                if(r.IsMatch(line))
                {
                    MessageBox.Show(line);
                    string strippedline = line.Substring(2, line.Length - 2);
                    linestext += strippedline + "\n";
                    ProcessStartInfo certutilinfo = new ProcessStartInfo("certutil.exe");
                    certutilinfo.Arguments = "-delstore Root " + "\"" + strippedline + "\"";
                    Process certutil = Process.Start(certutilinfo);
                    while (!certutil.HasExited) { } //lock the thread
                    certutil.Dispose();
                }
            }

            //cleanup
            proc.Dispose();
            notepadproc.Dispose();

            MessageBox.Show("success the following certificates have been removed.\n=====================================================\n" + linestext);
        }

        public override void Unapply()
        {
            
        }

        private bool IsInstalled()
        {
            return Directory.Exists(GetDataFolder() + @"\sigcheck");
        }

        private void InstallForFirstTime(string resource)
        {
            string path = GetDataFolder() + @"\sigcheck";

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

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return true;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsUserControlRequired()
        {
            return true;
        }

        public override Button GetButton()
        {
            return gui.boguscertbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.boguscertprogress;
        }
    }
}
