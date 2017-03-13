/*
    A security toolkit for windows    

    Copyright(C) 2016 Guido Lucassen

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

namespace windows_tweak_tool.src.policies
{
    class UnsafeServicePolicy : SecurityPolicy
    {
        public override void apply()
        {
            throw new NotImplementedException();
        }

        public override Button getButton()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }

        public override string getName()
        {
            throw new NotImplementedException();
        }

        public override ProgressBar getProgressbar()
        {
            throw new NotImplementedException();
        }

        public override SecurityPolicyType getType()
        {
            throw new NotImplementedException();
        }

        public override bool hasIncompatibilityIssues()
        {
            throw new NotImplementedException();
        }

        public override bool isEnabled()
        {
            throw new NotImplementedException();
        }

        public override bool isLanguageDepended()
        {
            throw new NotImplementedException();
        }

        public override bool isMacro()
        {
            throw new NotImplementedException();
        }

        public override bool isSafeForBussiness()
        {
            throw new NotImplementedException();
        }

        public override bool isSecpolDepended()
        {
            throw new NotImplementedException();
        }

        public override bool isUserControlRequired()
        {
            throw new NotImplementedException();
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }
    }
}
