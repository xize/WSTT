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

namespace windows_security_tweak_tool.src.policies
{
    class LLMNRPolicy : SecurityPolicy
    {

        private string path = @"SOFTWARE\Policies\Microsoft\Windows NT\DNSClient";


        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables broadcasting from the LLMNR protocol, and also blocks a form of dns posioning because it does not longer asks other computers to setup a dns server";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.LLMNR_POLICY;
        }

        public override bool isEnabled()
        {
            RegistryKey key = getRegistry(path, REG.HKLM);
            if(key != null)
            {
                int value = (int)key.GetValue("EnableMulticast");
                key.Close();
                key.Dispose();
                return (value == 0 ? true : false);
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            //check if key Windows NT exist...

            RegistryKey WinNT = this.getRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM);
            if(WinNT == null)
            {
                this.getRegistry(@"SOFTWARE\Policies\Microsoft\", REG.HKLM).CreateSubKey("Windows NT");
            }

            RegistryKey key = this.getRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM).CreateSubKey("DNSClient");
            key.SetValue("EnableMulticast", 0);
            key.Close();
            key.Dispose();
            this.setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            RegistryKey key = this.getRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT\", REG.HKLM);
            key.DeleteSubKey("DNSClient");
            key.Close();
            key.Dispose();
            this.setGuiDisabled(this);
            getButton().Enabled = true;
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
            return false;
        }

        public override Button getButton()
        {
            return this.gui.llmnrbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return this.gui.llmnrprogress;
        }
    }
}
