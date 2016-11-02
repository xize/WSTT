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

        public override void apply()
        {
            getButton().Enabled = false;
            AutoItX3 it = createAutoIT("temp");
            it.Run("mmc.exe secpol.msc");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....

            it.Send("{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}");
            it.Sleep(400);

            //create policy rules
            it.Send("{ALT}");
            it.Send("{RIGHT}");
            it.Send("{ENTER}");
            it.Send("{DOWN}");
            it.Send("{ENTER}");
            it.Sleep(400);
            it.Send("{ENTER}");

            it.Send("{RIGHT}");
            it.Sleep(400);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("{DOWN}{DOWN}{DOWN}{DOWN}");
            it.Send("{ENTER}");

            setTrustedPolicy();
            it.Sleep(400);

            it.Send("{UP}{UP}");
            it.Send("{ENTER}");

            setEnforcementPropertyPolicy();
            it.Sleep(400);

            it.Send("{UP}");
            it.Send("{ENTER}");
            it.Sleep(400);

            addPolicyRule("%temp%");
            addPolicyRule("%localappdata%\\*.exe");
            addPolicyRule("%localappdata%\\*.dll");
            addPolicyRule("%localappdata%\\*.au3");
            addPolicyRule("%systemdir%\\system32\\WindowsPowershell\\*\\*.exe");
            addPolicyRule("%systemdir%\\syswow64\\WindowsPowershell\\*\\*.exe");
            it.Sleep(400);

            closeMMCWindow();

            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            removeAutoITtask("temp");
            Config.getConfig().put("policy-malware-restriction", true);
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            AutoItX3 it = createAutoIT("temp");
            it.Run("mmc.exe secpol.msc");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....
            it.WinActivate("[CLASS:MMCMainFrame]");

            it.Send("{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}");
            it.Sleep(400);
            it.Send("{ALT}");
            it.Send("{TAB}");
            it.Send("{ENTER}");
            it.Send("{DOWN}");
            it.Send("{ENTER}");
            it.Sleep(400);
            it.Send("{ENTER}");

            closeMMCWindow();
            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            removeAutoITtask("temp");
            Config.getConfig().put("policy-malware-restriction", false);
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        private void fixUnhappyTrigger()
        {
            AutoItX3 it = getAutoIT("temp");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: find class name of this window
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: find class name of this window
            it.Sleep(300);
            it.Send("{ENTER}");
        }

        private void pressOK(string windowtitle)
        {
            AutoItX3 it = getAutoIT("temp");
            it.Send("{ENTER}");
        }

        private void setTrustedPolicy()
        {
            AutoItX3 it = getAutoIT("temp");
            it.WinWait("[CLASS:#32770]");

            it.Send("d");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("{DOWN}");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("c");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            if (hasIncompatibilityIssues())
            {
                if (getWindowsVersion() < 10)
                {
                    it.Send("{TAB}");
                }
            }
            it.Sleep(300);
            pressOK("[CLASS:#32770]");
        }

        private void setEnforcementPropertyPolicy()
        {
            AutoItX3 it = getAutoIT("temp");
            it.WinWait("[CLASS:#32770]");

            it.Send("{RIGHT}");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("{RIGHT}");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            it.Send("{RIGHT}");
            it.Sleep(300);
            it.Send("{TAB}");
            it.Sleep(300);
            if (hasIncompatibilityIssues())
            {
                if (getWindowsVersion() < 10)
                {
                    it.Send("{TAB}");
                }
            }
            it.Sleep(300);
            pressOK("[CLASS:#32770]");
        }

        private void addPolicyRule(string name)
        {
            AutoItX3 it = getAutoIT("temp");

            it.Send("{ALT}");
            it.Send("{TAB}");
            it.Send("{ENTER}");
            it.Send("{DOWN}{DOWN}{DOWN}{DOWN}");
            it.Send("{ENTER}");
      
            it.WinWait("[CLASS:#32770]");
            it.WinActivate("[CLASS:#32770]");

            it.Send(name);
            it.Send("{ENTER}");
            it.Sleep(400);
        }

        private void closeMMCWindow()
        {
            AutoItX3 it = getAutoIT("temp");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinClose("[CLASS:MMCMainFrame]");
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

        public override bool isLanguageDepended()
        {
            return true;
        }

        public override bool hasIncompatibilityIssues()
        {
            //windows 7 and lower have an extra help url inside the windows in setTrustedPolicy() and setEnforcementPropertyPolicy() which means there needs to be one extra tab to be pressed.
            //therefor newer versions don't seem to have those links to the helpcenter....
            return true;
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
