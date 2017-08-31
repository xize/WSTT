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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class UacPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return "UAC Policy";
        }

        public override string GetDescription()
        {
            return "highers the uac policy from normal to high";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.UAC_POLICY;
        }

        public override bool IsEnabled()
        {
            if(Config.GetConfig().GetInt("uac-mode") == 4)
            {
                return true;
            }
            return false;
        }

        public override void Apply()
        {
            gui.uac_btn.Enabled = false;
            AutoIt.AutoItX.Run("UserAccountControlSettings.exe", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:NativeHWNDHost]");
            AutoIt.AutoItX.WinActivate("[CLASS:NativeHWNDHost]");

            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("{UP}{UP}{UP}{UP}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("{ENTER}");

            Config.GetConfig().Put("uac-mode", 4);
            SetGuiEnabled(this);
            gui.uac_btn.Enabled = true;
        }

        public override void Unapply()
        {
            gui.uac_btn.Enabled = false;
            AutoIt.AutoItX.Run("UserAccountControlSettings.exe", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:NativeHWNDHost]");
            AutoIt.AutoItX.WinActivate("[CLASS:NativeHWNDHost]");

            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("{UP}{UP}{UP}{UP}");
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("{ENTER}");

            Config.GetConfig().Put("uac-mode", 3);
            SetGuiDisabled(this);
            gui.uac_btn.Enabled = true;
        }

        public override Button GetButton()
        {
            return gui.uac_btn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.uac_progress;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return true;
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return true;
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
            return true;
        }
    }
}
