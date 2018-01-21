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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class SMBSharingPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disable SMB sharing to block ransomware and malware which spreads across networks";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.SMB_SHARING_POLICY;
        }

        public override bool IsEnabled()
        {
            if (Config.GetConfig().NodeExist("smb-enabled"))
            {
                return Config.GetConfig().GetBoolean("smb-enabled");
            }
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            GetButton().Enabled = true;
            SetGuiEnabled(this);
        }

        public void ApplyAsync()
        {
            DialogResult result = MessageBox.Show("if you want to properly secure yourself you need to understand that there is a high chance a NAS or other network related equipment might fail to work properly.\n\nfor this reason we only block SMBv1 (the most vulnerable protocol) instead of SMBv2 and SMBv3 for full protection we recommend to block these ports from WAN to LAN and from LAN to WAN: 137-138/UDP, 139/TCP and 445/TCP", "advice regarding wannacry, and other ransomware", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", REG.HKLM);
            key.SetValue("SMB1", 0);

            key.Close();
            key.Dispose();

            ProcessStartInfo info = new ProcessStartInfo("dism.exe");
            info.Arguments = "/Online /Disable-Feature /FeatureName:SMB1Protocol";
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Config.GetConfig().Put("smb-enabled", true);
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            GetButton().Enabled = true;
            SetGuiDisabled(this);
        }

        public void UnapplyAsync()
        {
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", REG.HKLM);
            key.SetValue("SMB1", 1);

            key.Close();
            key.Dispose();


            ProcessStartInfo info = new ProcessStartInfo("dism.exe");
            info.Arguments = "/Online /Enable-Feature /FeatureName:SMB1Protocol";
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Config.GetConfig().Put("smb-enabled", false);
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
            return this.gui.smbbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return this.gui.smbprogress;
        }
    }
}
