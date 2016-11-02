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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class UacPolicy : Policy
    {

        public override string getName()
        {
            return "UAC Policy";
        }

        public override string getDescription()
        {
            return "highers the uac policy from normal to high";
        }

        public override PolicyType getType()
        {
            return PolicyType.UAC_POLICY;
        }

        public override bool isEnabled()
        {
            if(Config.getConfig().getInt("uac-mode") == 4)
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            gui.uac_btn.Enabled = false;
            AutoItX3 it = createAutoIT("uac");
            it.Run("UserAccountControlSettings.exe");
            it.WinWait("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here
            it.WinActivate("Instellingen voor Gebruikersaccountbeheer");

            it.Send("{TAB}");
            it.Send("{UP}{UP}{UP}{UP}");
            it.Sleep(400);
            it.Send("{TAB}");
            it.Send("{ENTER}");

            removeAutoITtask("uac");
            Config.getConfig().put("uac-mode", 4);
            setGuiEnabled(this);
            gui.uac_btn.Enabled = true;
        }

        public override void unapply()
        {
            gui.uac_btn.Enabled = false;
            AutoItX3 it = createAutoIT("uac");
            it.Run("UserAccountControlSettings.exe");
            it.WinWait("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here
            it.WinActivate("Instellingen voor Gebruikersaccountbeheer");

            it.Send("{TAB}");
            it.Send("{UP}{UP}{UP}{UP}");
            it.Send("{DOWN}");
            it.Sleep(400);
            it.Send("{TAB}");
            it.Send("{ENTER}");

            removeAutoITtask("uac");
            Config.getConfig().put("uac-mode", 3);
            setGuiDisabled(this);
            gui.uac_btn.Enabled = true;
        }

        public override Button getButton()
        {
            return gui.uac_btn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.uac_progress;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return true;
        }

        public override bool isLanguageDepended()
        {
            return true;
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
            return true;
        }
    }
}
