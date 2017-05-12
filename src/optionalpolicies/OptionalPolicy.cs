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
using System.Windows.Forms;
using windows_tweak_tool.src.ninite;

namespace windows_tweak_tool.src.optionalpolicies
{
    abstract class OptionalPolicy : NiniteCreator
    {

        protected OptionalWindow gui;

        public void setGui(OptionalWindow gui)
        {
            if(this.gui == null)
            {
                this.gui = gui;
            }
        }

        public abstract string getName();

        public abstract string getDescription();

        public abstract OptionalPolicyType getType();

        public abstract void apply();

        public abstract void unapply();

        public abstract Button getButton();

        public virtual bool isEnabled()
        {
            return true;
        }

        public bool hasButton()
        {
            return ((getButton() != null) ? true : false);
        }

        public abstract ProgressBar getProgressbar();

        public bool hasProgressbar()
        {
            return ((getProgressbar() != null) ? true : false);
        }

    }
}
