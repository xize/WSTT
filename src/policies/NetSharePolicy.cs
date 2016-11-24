using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class NetSharePolicy : Policy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables netshares so these directories are not shared automaticly anymore";
        }

        public override PolicyType getType()
        {
            return PolicyType.NETSHARE_POLICY;
        }

        public override bool isEnabled()
        {
            if(!isServiceStarted("LanmanServer"))
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            this.stopService("LanmanServer");
            this.setServiceType("LanmanServer", ServiceType.MANUAL);
            this.setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            this.startService("LanmanServer");
            this.setServiceType("LanmanServer", ServiceType.AUTOMATIC);
            this.setGuiDisabled(this);
            getButton().Enabled = true;
        }

        public override Button getButton()
        {
            return this.gui.netsharebtn;
        }

        public override ProgressBar getProgressbar()
        {
            return this.gui.netshareprogress;
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
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }
    }
}
