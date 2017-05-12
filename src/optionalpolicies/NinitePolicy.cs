-/*
-    A security toolkit for windows    
-
-    Copyright(C) 2016 Guido Lucassen
-
-    This program is free software: you can redistribute it and/or modify
-    it under the terms of the GNU General Public License as published by
-    the Free Software Foundation, either version 3 of the License, or
-    (at your option) any later version.
-
-    This program is distributed in the hope that it will be useful,
-    but WITHOUT ANY WARRANTY; without even the implied warranty of
-    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
-    GNU General Public License for more details.
-
-    You should have received a copy of the GNU General Public License
-    along with this program.If not, see<http://www.gnu.org/licenses/>.
-*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool.src.ninite;

namespace windows_tweak_tool.src.optionalpolicies
{
    class NinitePolicy : OptionalPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "install applications by using third party installer called ninite.";
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.NINITE;
        }

        public override void apply()
        {
            foreach(NiniteOption option in NiniteOption.values())
            {
                if(option.isEnabled())
                {
                    this.Add(option);
                }
            }
            this.downloadNiniteInstaller(this.getNiniteURL());
        }

        public override void unapply()
        {
            //not supported   
        }

        public override Button getButton()
        {
            return gui.niniteinstallbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return null;
        }
    }
}
