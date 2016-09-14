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
            int x = it.WinGetPosWidth("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here
            int z = it.WinGetPosHeight("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here

            it.MouseClick("primary", x-27, z-120, 1, 0);
            it.Send("{TAB}{ENTER}");
            removeAutoITtask("uac");
            Config.getConfig().put("uac-mode", 4);
            gui.uac_btn.Enabled = true;
        }

        public override void unapply()
        {
            gui.uac_btn.Enabled = false;
            AutoItX3 it = createAutoIT("uac");
            it.Run("UserAccountControlSettings.exe");
            it.WinWait("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here
            it.WinActivate("Instellingen voor Gebruikersaccountbeheer");
            int x = it.WinGetPosWidth("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here
            int y = it.WinGetPosHeight("Instellingen voor Gebruikersaccountbeheer"); //TODO: add a language bundle here

            it.MouseClick("primary", x - 27, y - 100, 1, 0);
            it.Send("{TAB}{ENTER}");
            removeAutoITtask("uac");
            Config.getConfig().put("uac-mode", 3);
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
    }
}
