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
    class TempPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "sets the policies to protect known malware directories against malware";
        }

        public override PolicyType getType()
        {
            return PolicyType.TEMP_POLICY;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("policy-malware-restriction");
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            AutoItX3 it = createAutoIT("temp");
            it.Run("mmc.exe secpol.msc");
            it.WinWait("Lokaal beveiligingsbeleid"); //TODO: add language bundle here.
            it.WinActivate("Lokaal beveiligingsbeleid"); //TODO: add language bundle here.

            int x = it.WinGetPosX("Lokaal beveiligingsbeleid");
            int y = it.WinGetPosY("Lokaal beveiligingsbeleid");

            it.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....
            it.MouseClick("primary", x+45, y+206, 1, 1);
            it.MouseClick("right", x+45, y+207, 1, 1);
            it.Sleep(300);
            it.MouseClick("primary", x+48, y+212, 1, 1);
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(400);
            closeMMCWindow();
            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            removeAutoITtask("temp");
            Config.getConfig().put("policy-malware-restriction", false);
            getButton().Enabled = true;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            AutoItX3 it = createAutoIT("temp");
            it.Run("mmc.exe secpol.msc");
            it.WinWait("Lokaal beveiligingsbeleid"); //TODO: add language bundle here.
            it.WinActivate("Lokaal beveiligingsbeleid"); //TODO: add language bundle here.
            it.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....

            int x = it.WinGetPosX("Lokaal beveiligingsbeleid");
            int y = it.WinGetPosY("Lokaal beveiligingsbeleid");

            it.MouseClick("primary", x+48, y+207, 1, 1);
            it.Sleep(500);
            it.MouseClick("right", x+45, y+207, 1, 1);
            it.Sleep(500);
            it.MouseClick("primary", x+58, y+212, 1, 1);
            it.Sleep(500);
            it.Send("{ENTER}");
            it.Sleep(500);
            setTrustedPolicy();
            setEnforcementPropertyPolicy();
            it.MouseClick("primary", x+280, y+139, 2, 1);
            it.Sleep(400);
            addPolicyRule("%temp%");
            addPolicyRule("%localappdata%\\*.exe");
            addPolicyRule("%localappdata%\\*.dll");
            addPolicyRule("%localappdata%\\*.au3");
            addPolicyRule("%systemdir%\\system32\\WindowsPowershell\\*\\*.exe");
            addPolicyRule("%systemdir%\\syswow64\\WindowsPowershell\\*\\*.exe");
            closeMMCWindow();
            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            removeAutoITtask("temp");
            Config.getConfig().put("policy-malware-restriction", true);
            getButton().Enabled = true;
        }

        private void fixUnhappyTrigger()
        {
            AutoItX3 it = getAutoIT("temp");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: add language bundle here
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: add language bundle here
            it.Sleep(300);
            it.Send("{ENTER}");
        }

        private void pressOK(string windowtitle)
        {
            AutoItX3 it = getAutoIT("temp");

            int x = it.WinGetPosX(windowtitle);
            int y = it.WinGetPosY(windowtitle);

            it.MouseClick("primary", x+200, y+430, 1, 1);
        }

        private void setTrustedPolicy()
        {
            AutoItX3 it = getAutoIT("temp");
            it.MouseClick("primary", 380, 200, 2, 1);
            it.WinWait("Eigenschappen van Vertrouwde uitgevers"); //TODO: add a language bundle here.

            int x = it.WinGetPosX("Eigenschappen van Vertrouwde uitgevers"); //TODO: add a language bundle here.
            int y = it.WinGetPosY("Eigenschappen van Vertrouwde uitgevers"); //TODO: add a language bundle here.

            it.MouseClick("primary", x+160, y+110, 1, 1);
            it.MouseClick("primary", x+160, y+200, 1, 1);
            it.MouseClick("primary", x+160, y+313, 1, 1);
            pressOK("Eigenschappen van Vertrouwde uitgevers");
        }

        private void setEnforcementPropertyPolicy()
        {
            AutoItX3 it = getAutoIT("temp");
            it.MouseClick("primary", 280, 160, 2, 1);
            it.WinWait("Eigenschappen van Afdwingen"); //TODO: add a language bundle here.

            int x = it.WinGetPosX("Eigenschappen van Afdwingen");
            int y = it.WinGetPosY("Eigenschappen van Afdwingen");

            it.MouseClick("primary", x+60, y+120, 1, 1);
            it.MouseClick("primary", x+60, y+250, 1, 1);
            pressOK("Eigenschappen van Afdwingen");
        }

        private void addPolicyRule(string name)
        {
            AutoItX3 it = getAutoIT("temp");
            it.MouseClick("right", 280, 480, 1, 1);
            it.Sleep(500);
            it.MouseClick("primary", 290, 556, 1, 1);
            it.WinWait("Regel voor nieuw pad"); //TODO: add a language bundle here.
            it.WinActivate("Regel voor nieuw pad"); //TODO: add a language bundle here.

            int x = it.WinGetPosX("Regel voor nieuw pad"); //TODO: add a langauge bundle here.
            int y = it.WinGetPosY("Regel voor nieuw pad"); //TODO: add a langauge bundle here.

            it.MouseClick("primary", x+100, y+148, 1, 1);
            it.Sleep(300);
            it.Send(name);
            it.Sleep(300);
            it.MouseClick("primary", x+180, y+445, 1, 1);
            it.Sleep(400);
        }

        private void closeMMCWindow()
        {
            AutoItX3 it = getAutoIT("temp");
            it.WinActive("Lokaal beveiligingsbeleid");
            it.MouseClick("primary", 785, 3, 1, 0);
        }

        public override ProgressBar getProgressbar()
        {
            return gui.temp_policy_load;
        }

        public override Button getButton()
        {
            return gui.temp_policy_btn;
        }

        public override bool isSecpolDepended()
        {
            return true;
        }

        public override bool isMacro()
        {
            return true;
        }
    }
}
