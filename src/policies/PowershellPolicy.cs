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
using windows_security_tweak_tool.src.libs.windowslock;

namespace windows_security_tweak_tool.src.policies
{
    class PowershellPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return this.GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables powershell for being able to execute\n\nhowever in this version of wstt it only blocks powershell 2.0 and not the default powershell 1.0!";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.POWERSHELL_POLICY;
        }

        public override bool IsEnabled()
        {
            if(File.Exists(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe.disabled"))
            {
                return true;
            }
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            DialogResult r = MessageBox.Show("currently it is not advised to run this policy as the undo file permissions are not getting applied correctly...\n\nthis means it will make your system vulnerable because the administrator group always have write/delete permissions for some reason we cannot undo this.\nunless you're a professional yourself then you need to undo the rights yourself like showed below:\n\nC:\\windows\\system32\\WindowsPowershell\\v1.0\\powershell.exe\nC:\\windows\\system32\\WindowsPowershell\\v1.0\\powershell_ise.exe\n\nboth files need to be set to Read-only and Executable-only all other permissions should be rejected and the owner should be set to TrustedInstaller in order to restore the correct rights!", "warning, please read carefully!", MessageBoxButtons.OKCancel);

            if (r == DialogResult.Cancel)
            {
                GetButton().Enabled = true;
                return;
            }

            await Task.Run(() => ApplyAsync());

            SetGuiEnabled(this);

            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {

            ExecuteCMD("dism /online /Disable-Feature /FeatureName:MicrosoftWindowsPowerShellV2", true);
            ExecuteCMD("dism /online /Disable-Feature /FeatureName:MicrosoftWindowsPowerShellV2Root", true);

            //take owner rights...
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe");
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe");

            //rename files...
            File.Move(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe", @"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe.disabled");
            File.Move(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe", @"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe.disabled");

            //set owner back to trusted installer
            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe.disabled");
            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe.disabled");
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            SetGuiDisabled(this);

            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {

            MessageBox.Show("while it works you should manually change the permissions for the Administrators group for:\n\nC:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe\nC:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell_ise.exe\n\nboth files explicity need to be set to Read and Write permissions all other permissions should be disabled!\n\ncurrently we don't have a fix since icacls is very buggy/difficult in how it is implemented..", "warning!");

            ExecuteCMD("dism /online /Enable-Feature /FeatureName:MicrosoftWindowsPowerShellV2", true);
            ExecuteCMD("dism /online /Enable-Feature /FeatureName:MicrosoftWindowsPowerShellV2Root", true);

            //take owner rights...
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe.disabled");
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe.disabled");

            //rename files...
            File.Move(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe.disabled", @"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe");
            File.Move(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe.disabled", @"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe");

            //set owner back to trusted installer
            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell.exe");
            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\WindowsPowershell\v1.0\powershell_ise.exe");
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
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
            return false;
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
            return gui.powershellbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.powershellprogress;
        }
    }
}
