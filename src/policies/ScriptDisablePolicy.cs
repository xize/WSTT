using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_tweak_tool.src;
using windows_tweak_tool.src.policies;

namespace windows_tweak.src.policies
{
    class ScriptDisablePolicy : Policy
    {
        public string getDescription()
        {
            return "disable wscript and powershell scripts";
        }

        public string getName()
        {
            return getType().getName();
        }

        public PolicyType getType()
        {
            return PolicyType.POLICY_WSCRIPT_AND_POWERSHELL;
        }

        public bool isEnabled()
        {
            return Config.getConfig().getBoolean("scriptdisable");
        }

        public void setEnabled()
        {
            PolicyManager.getRegPolicy().setPolicyByRegFile("reg/scriptdisable_add.reg");
            Config.getConfig().put("scriptdisable", true);
        }

        public void setDisabled()
        {
            PolicyManager.getRegPolicy().setPolicyByRegFile("reg/scriptdisable_del.reg");
            Config.getConfig().put("scriptdisable", false);
        }

    }
}
