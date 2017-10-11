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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class LLMNRPolicy : SecurityPolicy
    {

        private string path = @"SOFTWARE\Policies\Microsoft\Windows NT\DNSClient";


        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables broadcasting from the LLMNR protocol, and also blocks a form of dns posioning because it does not longer asks other computers to setup a dns server";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.LLMNR_POLICY;
        }

        public override bool IsEnabled()
        {
            RegistryKey key = GetRegistry(path, REG.HKLM);
            if(key != null)
            {
                int value = (int)key.GetValue("EnableMulticast");
                key.Close();
                key.Dispose();
                return (value == 0 ? true : false);
            }
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;
            //check if key Windows NT exist...

           await Task.Run(()=> ApplyAsync());

            this.SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            RegistryKey WinNT = this.GetRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM);
            if (WinNT == null)
            {
                this.GetRegistry(@"SOFTWARE\Policies\Microsoft\", REG.HKLM).CreateSubKey("Windows NT");
            }

            RegistryKey key = this.GetRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM).CreateSubKey("DNSClient");
            key.SetValue("EnableMulticast", 0);
            key.Close();
            key.Dispose();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            this.SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {
            RegistryKey key = this.GetRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM);
            key.DeleteSubKey("DNSClient");
            key.Close();
            key.Dispose();
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
            return false;
        }

        public override Button GetButton()
        {
            return this.gui.llmnrbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return this.gui.llmnrprogress;
        }
    }
}
