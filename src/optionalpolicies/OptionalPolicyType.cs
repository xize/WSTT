using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.optionalpolicies
{
    class OptionalPolicyType
    {

        public static HashSet<OptionalPolicyType> data = new HashSet<OptionalPolicyType>();

        public static OptionalPolicyType NINITE = new OptionalPolicyType("ninite", new NinitePolicy());

        private string name;
        private OptionalPolicy pol;

        public OptionalPolicyType(string name, OptionalPolicy policy)
        {
            this.name = name;
            this.pol = policy;
        }

        public string getName()
        {
            return this.name;
        }

        public OptionalPolicy getPolicy(OptionalWindow wind)
        {
            this.pol.setGui(wind);
            return this.pol;
        }


        public static OptionalPolicyType[] values()
        {
            return data.ToArray();
        }

    }
}
