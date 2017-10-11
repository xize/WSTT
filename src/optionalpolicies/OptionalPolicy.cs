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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.ninite;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    abstract class OptionalPolicy : NiniteCreator
    {

        protected OptionalWindow gui;

        public void SetGui(OptionalWindow gui)
        {
            if(this.gui == null)
            {
                this.gui = gui;
            }
        }

        public abstract string GetName();

        public abstract string GetDescription();

        public bool HasDescription()
        {
            if(GetDescription() != null)
            {
                return true;
            }
            return false;
        }

        public abstract OptionalPolicyType GetOptionalPolicyType();

        public abstract void Apply();

        public abstract void Unapply();

        public abstract Button GetButton();

        public virtual bool IsEnabled()
        {
            return false;
        }

        public virtual bool IsCertificateDepended()
        {
            return false;
        }

        public virtual Certificate GetCertificate()
        {
            return null;
        }

        public bool HasButton()
        {
            return ((GetButton() != null) ? true : false);
        }

        public abstract ProgressBar GetProgressbar();

        public bool HasProgressbar()
        {
            return ((GetProgressbar() != null) ? true : false);
        }

    }
}
