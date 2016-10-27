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
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class MBRPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "install MBRFilter to prevent bootloader modification, this will help you against rootkits and ransomware";
        }

        public override PolicyType getType()
        {
            return null;
           // return PolicyType.MBR_POLICY;
        }

        public override bool isEnabled()
        {
            if(Directory.Exists(getDataFolder()+@"\mbrfilter"))
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            string url = (Environment.Is64BitOperatingSystem ? "https://github.com/yyounan/MBRFilter/files/536998/64.zip" : "https://github.com/yyounan/MBRFilter/files/536997/32.zip");
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.59 Safari/537.36");
            Directory.CreateDirectory(getDataFolder()+@"\mbrfilter");
            try
            {
                client.DownloadFile(new Uri(url), getDataFolder() + @"\mbrfilter\mbrfilter.zip");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Unable to download  MBRFilter, perhaps the file has been removed?\nplease visit: "+url);
                Directory.Delete(getDataFolder() + @"\mbrfilter");
                getButton().Enabled = true;
                return;
            }
            ZipArchive archive = ZipFile.OpenRead(getDataFolder() + @"\mbrfilter\mbrfilter.zip");
            archive.ExtractToDirectory(getDataFolder() + @"\mbrfilter");
            archive.Dispose();
            File.Delete(getDataFolder() + @"\mbrfilter\mbrfilter.zip");

            ProcessStartInfo proci = new ProcessStartInfo("infdefaultinstall.exe");
            proci.Arguments = "\""+ getDataFolder() + @"\mbrfilter\"+(Environment.Is64BitOperatingSystem ? "64" : "32")+ @"\MBRFilter.inf" + "\"";
            Process proc = Process.Start(proci);
            while(!proc.HasExited)
            {
                //lock
            }
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            ProcessStartInfo proci = new ProcessStartInfo("cmd.exe");
            proci.Verb = "runas";
            proci.Arguments = "/c pnputil.exe /delete-driver \"" + getDataFolder() + @"\mbrfilter\" + (Environment.Is64BitOperatingSystem ? "64" : "32") + @"\MBRFilter.inf" + "\"";
            Process proc = Process.Start(proci);
            while (!proc.HasExited)
            {
                //lock
            }
            deleteMBR();
            getButton().Enabled = true;
        }

        private void deleteMBR()
        {
            foreach(string a in Directory.GetFiles(getDataFolder() + @"\mbrfilter"))
            {
                File.Delete(a);
            }
            Directory.Delete(getDataFolder() + @"\mbrfilter", true);
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override Button getButton()
        {
            return gui.mbrbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.mbrprogress;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }
    }
}
