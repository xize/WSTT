/*
    A security toolkit for windows    

    Copyright(C) 2017 Guido Lucassen

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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class TempPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "sets the policies to protect known malware directories against malware";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.TEMP_POLICY;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("policy-malware-restriction");
        }

        public override void apply()
        {
            getButton().Enabled = false;
            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....

            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Sleep(400);

            //create policy rules
            AutoIt.AutoItX.Send("{ALT}");
            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
            //AutoIt.AutoItX.Send("{ENTER}"); /* figuring out what the meaning of this enter is? perhaps language issues? or has it todo with incompatibility... */

            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Send("{ENTER}");

            setTrustedPolicy();
            AutoIt.AutoItX.Sleep(400);

            AutoIt.AutoItX.Send("{UP}{UP}");
            AutoIt.AutoItX.Send("{ENTER}");

            setEnforcementPropertyPolicy();
            AutoIt.AutoItX.Sleep(400);

            AutoIt.AutoItX.Send("{UP}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(600);

            addPolicyRule("%temp%");
            addPolicyRule("%programdata%\\*.*");
            addPolicyRule("%localappdata%\\*.exe");
            addPolicyRule("%localappdata%\\*.dll");
            addPolicyRule("%localappdata%\\*.au3");
            addPolicyRule("%systemdir%\\system32\\WindowsPowershell\\*\\*.exe");
            addPolicyRule("%systemdir%\\syswow64\\WindowsPowershell\\*\\*.exe");
            AutoIt.AutoItX.Sleep(400);

            closeMMCWindow();

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("policy-malware-restriction", true);
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            fixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");

            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{ALT}");
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{ENTER}");

            closeMMCWindow();
            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("policy-malware-restriction", false);
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        private void fixUnhappyTrigger()
        {
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinActivate("Beheersjablonen"); //TODO: find class name of this window
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinActivate("Beheersjablonen"); //TODO: find class name of this window
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
        }

        private void pressOK(string windowtitle)
        {
            AutoIt.AutoItX.Send("{ENTER}");
        }

        private void setTrustedPolicy()
        {
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");

            //AutoIt.AutoItX.Send("d");
            AutoIt.AutoItX.Send("{TAB}{TAB}{TAB}{TAB}FD"); /* F for english versions and D for dutch versions... still needs a review about this */
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("RC"); /* R for english versions and C for dutch versions... still needs a review about this */
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            if (hasIncompatibilityIssues())
            {
                if (getWindowsVersion() < 10)
                {
                    AutoIt.AutoItX.Send("{TAB}");
                }
            }
            AutoIt.AutoItX.Sleep(300);
            pressOK("[CLASS:#32770]");
        }

        private void setEnforcementPropertyPolicy()
        {
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");

            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            if (hasIncompatibilityIssues())
            {
                if (getWindowsVersion() < 10)
                {
                    AutoIt.AutoItX.Send("{TAB}");
                }
            }
            AutoIt.AutoItX.Sleep(300);
            pressOK("[CLASS:#32770]");
        }

        private void addPolicyRule(string name)
        {
            AutoIt.AutoItX.Send("{ALT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Send("{ENTER}");
      
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            //do not activate the window probably the main window get triggered!
            //AutoIt.AutoItX.WinActivate("[CLASS:#32770]");

            AutoIt.AutoItX.Sleep(400);

            AutoIt.AutoItX.Send(name);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
        }

        private void closeMMCWindow()
        {
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinClose("[CLASS:MMCMainFrame]");
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

        [Obsolete]
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
