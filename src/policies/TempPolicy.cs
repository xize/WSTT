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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class TempPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "sets the policies to protect known malware directories against malware";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.TEMP_POLICY;
        }

        public override bool IsEnabled()
        {
            return Config.GetConfig().GetBoolean("policy-malware-restriction");
        }

        public override void Apply()
        {
            GetButton().Enabled = false;

            Logger.getSubTreeLogger().LogTitle("starting "+GetPolicyType().GetName()+"...");
            Logger.getSubTreeLogger().LogTree("waiting till secpol has been started.");

            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            Logger.getSubTreeLogger().LogTree("secpol has been started with success!");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            Logger.getSubTreeLogger().LogTree("applying unhappytrigger (reactivating focus on the secpol window since sommetime it is lost due some reason)");
            FixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....
            Logger.getSubTreeLogger().LogTree("unhappytrigger is finished, applying macro.");

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

            Logger.getSubTreeLogger().LogTree("applying setTrustedPolicy()...");
            SetTrustedPolicy();
            Logger.getSubTreeLogger().LogTree("done applying setTrustedPolicy()!");

            AutoIt.AutoItX.Sleep(400);

            AutoIt.AutoItX.Send("{UP}{UP}");
            AutoIt.AutoItX.Send("{ENTER}");

            Logger.getSubTreeLogger().LogTree("applying setEnforcementPropertyPolicy()...");
            SetEnforcementPropertyPolicy();
            Logger.getSubTreeLogger().LogTree("done setTrustedPolicy()!");

            AutoIt.AutoItX.Sleep(400);

            AutoIt.AutoItX.Send("{UP}");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(600);

            Logger.getSubTreeLogger().LogTree("adding the following software restrictions to:");
            AddPolicyRule("%temp%");
            AddPolicyRule("%programdata%\\*.*");
            AddPolicyRule("%localappdata%\\*.exe");
            AddPolicyRule("%localappdata%\\*.dll");
            AddPolicyRule("%localappdata%\\*.au3");
            AddPolicyRule("%systemdir%\\system32\\WindowsPowershell\\*\\*.exe");
            AddPolicyRule("%systemdir%\\syswow64\\WindowsPowershell\\*\\*.exe");
            AutoIt.AutoItX.Sleep(400);

            CloseMMCWindow();

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.GetPolicy(gui);
            p.Apply();
            Config.GetConfig().Put("policy-malware-restriction", true);
            Logger.getSubTreeLogger().LogTreeEnd("done adding software restrictions!");
            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public override void Unapply()
        {
            GetButton().Enabled = false;

            Logger.getSubTreeLogger().LogTitle("undoing " + GetPolicyType().GetName() + "...");
            Logger.getSubTreeLogger().LogTree("waiting till secpol has been started.");

            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);
            Logger.getSubTreeLogger().LogTree("secpol has been started with success!");
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            Logger.getSubTreeLogger().LogTree("applying unhappytrigger (reactivating focus on the secpol window since sommetime it is lost due some reason)");
            FixUnhappyTrigger(); //fix a issue whereby windows 10 complains about a missing GEO location file which cause to freezes the automation....
            Logger.getSubTreeLogger().LogTree("unhappytrigger is finished, applying macro.");
            Logger.getSubTreeLogger().LogTree("starting macro, and removing the policy...");
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

            CloseMMCWindow();
            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.GetPolicy(gui);
            p.Apply();
            Config.GetConfig().Put("policy-malware-restriction", false);
            Logger.getSubTreeLogger().LogTreeEnd("done undoing software restrictions!");
            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        private void FixUnhappyTrigger()
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

        private void PressOK(string windowtitle)
        {
            AutoIt.AutoItX.Send("{ENTER}");
        }

        private void SetTrustedPolicy()
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
            if (HasIncompatibilityIssues())
            {
                if (GetWindowsVersion() < 10)
                {
                    AutoIt.AutoItX.Send("{TAB}");
                }
            }
            AutoIt.AutoItX.Sleep(300);
            PressOK("[CLASS:#32770]");
        }

        private void SetEnforcementPropertyPolicy()
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
            if (HasIncompatibilityIssues())
            {
                if (GetWindowsVersion() < 10)
                {
                    AutoIt.AutoItX.Send("{TAB}");
                }
            }
            AutoIt.AutoItX.Sleep(300);
            PressOK("[CLASS:#32770]");
        }

        private void AddPolicyRule(string name)
        {

            Logger.getSubTreeLogger().LogTree("software restriction path: "+name);

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

        private void CloseMMCWindow()
        {
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinClose("[CLASS:MMCMainFrame]");
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.temp_policy_load;
        }

        public override Button GetButton()
        {
            return gui.temp_policy_btn;
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        public override bool IsSecpolDepended()
        {
            return true;
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
            //windows 7 and lower have an extra help url inside the windows in setTrustedPolicy() and setEnforcementPropertyPolicy() which means there needs to be one extra tab to be pressed.
            //therefor newer versions don't seem to have those links to the helpcenter....
            return true;
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
