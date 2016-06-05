using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool
{
    class PolicyType
    {

        protected static HashSet<PolicyType> types = new HashSet<PolicyType>();
        public static PolicyType POLICY_TEMP_EXECUTION = new PolicyType("TEMP_EXECUTION");
        public static PolicyType POLICY_NETBIOS_OVER_IP = new PolicyType("NETBIOS_OVER_IP");

        private string name;

        private PolicyType(string name)
        {
            types.Add(this);
            this.name = name;
        }

        public string getName()
        {
            return name;
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
