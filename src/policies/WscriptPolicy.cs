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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class WscriptPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables wscript so it's impossible for malware to execute wscript scripts through a webpage :)";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.WSCRIPT_POLICY;
        }

        public override bool IsEnabled()
        {

            RegistryKey key = GetRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);

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

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(()=>ApplyAsync());

            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            RegistryKey key = GetRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);
            key.SetValue("Enabled", 0);
            key.Close();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(()=>UnapplyAsync());

            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {
            RegistryKey key = GetRegistry(@"SOFTWARE\Microsoft\Windows Script Host\Settings", REG.HKLM);
            key.SetValue("Enabled", 1);
            key.Close();
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.wscript_progress;
        }

        public override Button GetButton()
        {
            return gui.wscript_btn;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return false;
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return true;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }
    }
}