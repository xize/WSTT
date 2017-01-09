using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
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
            RegistryKey key = this.getRegistry(@"SOFTWARE\Policies\Microsoft\Windows NT", REG.HKLM);
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
