/*
    A security toolkit for windows    

    Copyright(C) 2017 Guido Lucassen

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

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class OptionalPolicyType
    {

        public static HashSet<OptionalPolicyType> data = new HashSet<OptionalPolicyType>();

        public static OptionalPolicyType NINITE = new OptionalPolicyType("ninite", new NinitePolicy());
        public static OptionalPolicyType HP_KEYLOGGER = new OptionalPolicyType("hp_keylogger", new HPKeyloggerPolicy());

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
