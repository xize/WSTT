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
using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class UpdatePolicy : Policy
    {

        public override void apply()
        {
            Process proc = Process.Start("gpupdate.exe", "/force");
            while(!proc.HasExited){}
        }

        public override Button getButton()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            return "updates the policy, this is not a UI element.";
        }

        public override string getName()
        {
            return "update policy";
        }

        public override ProgressBar getProgressbar()
        {
            throw new NotImplementedException();
        }

        public override PolicyType getType()
        {
            return PolicyType.UPDATE_POLICY;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isEnabled()
        {
            return false;
        }

        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return true;
        }

        public override bool isSecpolDepended()
        {
            return true;
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }
    }
}
