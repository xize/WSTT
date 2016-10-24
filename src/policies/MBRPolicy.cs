﻿/*
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
    class MBRPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "install MBRFilter to prevent bootloader modification, this will help you against rootkits and ransomware";
        }

        public override PolicyType getType()
        {
            return PolicyType.MBR_POLICY;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("mbrfilter");
        }

        public override void apply()
        {
            
        }

        public override void unapply()
        {
            
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override Button getButton()
        {
            return gui.mbrbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.mbrprogress;
        }
    }
}
