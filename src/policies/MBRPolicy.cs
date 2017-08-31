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
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using windows_security_tweak_tool.src.mbrfilter;

namespace windows_security_tweak_tool.src.policies
{
    class MBRPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().GetName();
        }

        public override string getDescription()
        {
            return "install MBRFilter to prevent bootloader modification, this will help you against rootkits and ransomware";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.MBR_POLICY;
        }

        public override bool isEnabled()
        {
            return MBRFilter.getMBRFilter().isInstalled();
        }

        public override void apply()
        {
            getButton().Enabled = false;
            MBRFilter.getMBRFilter().install();
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            MBRFilter.getMBRFilter().uninstall();
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
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

        public override bool isSafeForBussiness()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return true;
        }
    }
}
