using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return PolicyType.MBR_POLICY;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("mbrfilter");
        }

        public override void apply()
        {
            
        }

        public override void unapply()
        {
            
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
    }
}
