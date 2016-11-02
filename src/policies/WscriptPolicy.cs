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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class WscriptPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables wscript so it's impossible for malware to execute wscript scripts through a webpage :)";
        }

        public override PolicyType getType()
        {
            return PolicyType.WSCRIPT_POLICY;
        }

        public override bool isEnabled()
        {

            RegistryKey key = getRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);

            if(key.GetValue("Enabled") != null)
            {
                int value = (int)key.GetValue("Enabled");

                if (value == 0)
                {
                    key.Close();
                    return true;
                }
            }
            key.Close();
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);
            key.SetValue("Enabled", 0);
            key.Close();
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);
            key.SetValue("Enabled", 1);
            key.Close();
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.wscript_progress;
        }

        public override Button getButton()
        {
            return gui.wscript_btn;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }
    }
}