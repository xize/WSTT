using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class AutoPlayPolicy : SecurityPolicy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables auto play so removable devices cannot auto run programs on the computer";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.AUTOPLAY_POLICY;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            key.SetValue("NoDriveTypeAutoRun", 0x00);
            key.Close();
            key.Dispose();
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            key.SetValue("NoDriveTypeAutoRun", 0xFF);
            key.Close();
            key.Dispose();
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isEnabled()
        {
            RegistryKey key = getRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            try
            {
                var value = key.GetValue("NoDriveTypeAutoRun");
                key.Close();
                key.Dispose();
                return ((int)value != 0xFF ? true : false);
            } catch(NullReferenceException)
            {
                return false;
            }
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
            return gui.autoplaybtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.autoplayprogress;
        }

    }
}
