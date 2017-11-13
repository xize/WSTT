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
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.controls;

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

        public async override void Apply()
        {
            this.GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            this.GetButton().Enabled = true;
            RunProgressbar bar = (RunProgressbar)GetProgressbar();
            bar.RunOnceAnimationAsync();
        }

        public void ApplyAsync()
        {
            this.DownloadSigCheck();

            ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
            sinfo.Arguments = "/c " + GetDataFolder() + @"\sigcheck\sigcheck"+(Environment.Is64BitOperatingSystem ? "64":"")+@".exe -a -s -u -e C:\windows\system32 > " + GetDataFolder() + @"\sigcheck\unsigned.txt";
            Process proc = Process.Start(sinfo);
            proc.WaitForExit();
            proc.Close();
            proc.Dispose();

            ProcessStartInfo info = new ProcessStartInfo("notepad.exe");
            info.Arguments = GetDataFolder() + @"\sigcheck\unsigned.txt";
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }

        public override void Unapply()
        {
            throw new NotImplementedException();
        }

        public override bool IsCertificateDepended()
        {
            return true;
        }

        public override Certificate GetCertificate()
        {
            return (Environment.Is64BitOperatingSystem ? CertProvider.SIGCHECK_64BIT.GetCertificate() : CertProvider.SIGCHECK_32BIT.GetCertificate());
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
            return this.gui.unsignedbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return this.gui.unsignedprogress;
        }
    }
}
