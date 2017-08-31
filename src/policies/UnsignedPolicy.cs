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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class UnsignedPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "scans through every .exe and .dll file and checks if it has been signed with a certificate";
        }

        public override bool IsEnabled()
        {
            return false;
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.UNSIGNED_POLICY;
        }

        public override void Apply()
        {
            this.GetButton().Enabled = false;

            if (!IsInstalled())
            {
                Directory.CreateDirectory(GetDataFolder() + @"\sigcheck");
                InstallForFirstTime("sigcheck");
                InstallForFirstTime("sigcheck64");
                InstallForFirstTime("sigcheckeula");
            }

            Process proc;

            if (Environment.Is64BitOperatingSystem)
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c " + GetDataFolder() + @"\sigcheck\sigcheck.exe -a -s -u -e C:\windows\system32 > " + GetDataFolder() + @"\sigcheck\unsigned.txt";
                proc = Process.Start(sinfo);
            }
            else
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c " + GetDataFolder() + @"\sigcheck\sigcheck.exe -a -s -u -e C:\windows\system32 > " + GetDataFolder() + @"\sigcheck\unsigned.txt";
                proc = Process.Start(sinfo);
            }

            while (!proc.HasExited) { }
            proc.Close();
            proc.Dispose();

            ProcessStartInfo info = new ProcessStartInfo("notepad.exe");
            info.Arguments = GetDataFolder() + @"\sigcheck\unsigned.txt";
            Process p = Process.Start(info);

            this.GetButton().Enabled = true;
            this.GetProgressbar().Value = 100;
        }

        public override void Unapply()
        {
            throw new NotImplementedException();
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

        private bool IsInstalled()
        {
            return Directory.Exists(GetDataFolder() + @"\sigcheck");
        }

        private void InstallForFirstTime(string resource)
        {
            string path = GetDataFolder() + @"\sigcheck";

            switch (resource)
            {
                case "sigcheck":
                    File.WriteAllBytes(path + @"\sigcheck.exe", Properties.Resources.sigcheck);
                    break;
                case "sigcheck64":
                    File.WriteAllBytes(path + @"\sigcheck64.exe", Properties.Resources.sigcheck64);
                    break;
                case "sigcheckeula":
                    File.WriteAllBytes(path + @"\Eula.txt", Properties.Resources.sigcheckeula);
                    break;
            }
        }

        public override Button GetButton()
        {
            return this.gui.unsignedbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return this.gui.unsignedprogress;
        }
    }
}
