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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class NTLMPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables incomming and outcomming NTLM traffic, since most of the computers have standard Remote Desktop Protocol Enabled and most of the times it is NTLM depended\n\nthis means your computer is vulnerable against hash function cracking and a hacker could enter your remote computer very easily\ndo not use this when you are logged into a domain/bussiness network";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.NTLM_POLICY;
        }

        public override bool isEnabled()
        {
            bool bol = Config.getConfig().getBoolean("NTLM-secure");
            if(bol)
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;

            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            //fixUnhappyTrigger();
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{TAB}");
            addNTLMPolicyOptions();
            closeWindow();

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("NTLM-secure", true);
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;

            AutoIt.AutoItX.Run("mmc.exe secpol.msc", null, 0);

            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Sleep(400);
            //fixUnhappyTrigger();
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{RIGHT}");

            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{DOWN}{DOWN}{DOWN}");
            AutoIt.AutoItX.Sleep(400);
            AutoIt.AutoItX.Send("{TAB}");
            setDefaultOptions();
            closeWindow();

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("NTLM-secure", false);
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        private void loopToOptions()
        {
            for (int i = 0; i < 69; i++)
            {
                AutoIt.AutoItX.Send("{DOWN}");
            }
        }

        private void addNTLMPolicyOptions()
        {

            loopToOptions();
            
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{RIGHT}{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
          //  AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");

            AutoIt.AutoItX.Send("{DOWN}{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{RIGHT}{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
         //   AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");

            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
            //TODO: observing when the macro gets stuck here on the OK dialog.
            //AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(600);
          //  AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");

            AutoIt.AutoItX.Send("{DOWN}{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
          //  AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            //AutoIt.AutoItX.Sleep(400);
            
            AutoIt.AutoItX.Send("{DOWN}{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(400);
          //  AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
        }

        private void setDefaultOptions()
        {

            loopToOptions();

            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{LEFT}{LEFT}{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);

            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{LEFT}{LEFT}{ENTER}");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Send("{DOWN}");
            AutoIt.AutoItX.Sleep(300);

            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{LEFT}{LEFT}{LEFT}{LEFT}{ENTER}");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Send("{DOWN}");

            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{LEFT}{LEFT}{LEFT}{LEFT}{ENTER}");
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinWait("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.Send("{DOWN}");

            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.WinWait("[CLASS:#32770]");
            AutoIt.AutoItX.Send("{LEFT}{LEFT}{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            //AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
        }

        private void closeWindow()
        {
            AutoIt.AutoItX.WinActivate("[CLASS:MMCMainFrame]");
            AutoIt.AutoItX.WinClose("[CLASS:MMCMainFrame]");
        }

        public override Button getButton()
        {
            return gui.NTLMbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.NTLMProgress;
        }

        public override bool isMacro()
        {
            return true;
        }

        public override bool isSecpolDepended()
        {
            return true;
        }

        private void fixUnhappyTrigger()
        {
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinActivate("Beheersjablonen"); //TODO: find window class
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.WinActivate("Beheersjablonen"); //TODO: find window class
            AutoIt.AutoItX.Sleep(300);
            AutoIt.AutoItX.Send("{ENTER}");
        }

        [Obsolete]
        public override bool isLanguageDepended()
        {
            return true;
        }

        public override bool hasIncompatibilityIssues()
        {
            //needs to be checked
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }
    }
}
