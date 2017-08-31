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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class NetSharePolicy : SecurityPolicy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables netshares so these directories are not shared automaticly anymore";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.NETSHARE_POLICY;
        }

        public override bool isEnabled()
        {
            if(!IsServiceStarted("LanmanServer"))
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            this.StopService("LanmanServer", this);
            this.SetServiceType("LanmanServer", ServiceType.MANUAL);
            this.setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            this.SetServiceType("LanmanServer", ServiceType.AUTOMATIC);
            this.StartService("LanmanServer", this);
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
