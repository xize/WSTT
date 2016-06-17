using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_tweak.src.policies;

namespace windows_tweak_tool.src.policies
{
    class PolicyType
    {

        protected static HashSet<PolicyType> types = new HashSet<PolicyType>();
        public static PolicyType POLICY_TEMP_EXECUTION = new PolicyType("TEMP_EXECUTION", new TempExecutionPolicy());
        public static PolicyType POLICY_WSCRIPT_AND_POWERSHELL = new PolicyType("WSCRIPT_AND_POWERSHELL", new ScriptDisablePolicy());
        public static PolicyType POLICY_NETBIOS_OVER_IP = new PolicyType("NETBIOS_OVER_IP", new NetbiosPolicy());
        public static PolicyType POLICY_JS_FILE_ACC = new PolicyType("JS_FILE_ACC", new JSFilePolicy());

        private string name;
        private Policy pol;

        private PolicyType(string name, Policy pol)
        {
            types.Add(this);
            this.name = name;
            this.pol = pol;
        }

        public string getName()
        {
            return name;
        }

        public Policy getPolicy()
        {
            return pol;
        }

        public static PolicyType valueOf(string name)
        {
            foreach(PolicyType type in values())
            {
                if(type.getName().ToUpper() == name.ToUpper())
                {
                    return type;
                }
            }
            return null;
        }

        public static PolicyType[] values()
        {
            return types.ToArray();
        }

    }
}
