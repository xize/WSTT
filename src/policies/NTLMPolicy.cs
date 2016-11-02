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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class NTLMPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables incomming and outcomming NTLM traffic, since most of the computers have standard Remote Desktop Protocol Enabled and most of the times it is NTLM depended\n\nthis means your computer is vulnerable against hash function cracking and a hacker could enter your remote computer very easily\ndo not use this when you are logged into a domain/bussiness network";
        }

        public override PolicyType getType()
        {
            return PolicyType.NTLM_POLICY;
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
            AutoItX3 it = createAutoIT("NTLM");

            it.Run("mmc.exe secpol.msc");

            it.WinWait("[CLASS:MMCMainFrame]");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.Sleep(400);
            fixUnhappyTrigger();
            it.Send("{DOWN}{DOWN}{RIGHT}");
            it.Sleep(300);
            it.Send("{DOWN}{DOWN}{DOWN}");
            it.Sleep(400);
            it.Send("{TAB}");
            addNTLMPolicyOptions();
            closeWindow();

            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("NTLM-secure", true);
            removeAutoITtask("NTLM");
            setGuiEnabled(this);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            AutoItX3 it = createAutoIT("NTLM");

            it.Run("mmc.exe secpol.msc");

            it.WinWait("[CLASS:MMCMainFrame]");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.Sleep(400);
            fixUnhappyTrigger();
            it.Send("{DOWN}{DOWN}{RIGHT}");
            it.Sleep(300);
            it.Send("{DOWN}{DOWN}{DOWN}");
            it.Sleep(400);
            it.Send("{TAB}");
            setDefaultOptions();
            closeWindow();

            Policy p = PolicyType.UPDATE_POLICY.getPolicy(gui);
            p.apply();
            Config.getConfig().put("NTLM-secure", false);
            removeAutoITtask("NTLM");
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        private void loopToOptions()
        {
            AutoItX3 it = getAutoIT("NTLM");
            for (int i = 0; i < 68; i++)
            {
                it.Send("{DOWN}");
            }
        }

        private void addNTLMPolicyOptions()
        {
            AutoItX3 it = getAutoIT("NTLM");

            loopToOptions();

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{RIGHT}{RIGHT}");
            it.Sleep(300);
            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{ENTER}");
            it.Sleep(400);
            it.WinActivate("[CLASS:MMCMainFrame]");

            it.Send("{DOWN}{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{RIGHT}{RIGHT}");
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(400);
            it.WinActivate("[CLASS:MMCMainFrame]");

            it.Send("{DOWN}{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            it.Sleep(300);
            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{ENTER}");
            it.Sleep(600);
            it.WinActivate("[CLASS:MMCMainFrame]");

            it.Send("{DOWN}{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(400);
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.Sleep(400);
            
            it.Send("{DOWN}{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{RIGHT}{RIGHT}{RIGHT}{RIGHT}");
            it.Sleep(300);
            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{ENTER}");
            it.Sleep(400);
            it.WinActivate("[CLASS:MMCMainFrame]");
        }

        private void setDefaultOptions()
        {
            AutoItX3 it = getAutoIT("NTLM");

            loopToOptions();

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{LEFT}{LEFT}{ENTER}");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.Send("{DOWN}");

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{LEFT}{LEFT}{ENTER}");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.Send("{DOWN}");

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{LEFT}{LEFT}{LEFT}{LEFT}{ENTER}");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.Send("{DOWN}");

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{LEFT}{LEFT}{LEFT}{LEFT}{ENTER}");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinWait("[CLASS:MMCMainFrame]");
            it.Send("{DOWN}");

            it.Send("{ENTER}");
            it.WinWait("[CLASS:#32770]");
            it.Send("{LEFT}{LEFT}{ENTER}");
            it.WinActivate("[CLASS:MMCMainFrame]");
        }

        private void closeWindow()
        {
            AutoItX3 it = getAutoIT("NTLM");
            it.WinActivate("[CLASS:MMCMainFrame]");
            it.WinClose("[CLASS:MMCMainFrame]");
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
            AutoItX3 it = getAutoIT("NTLM");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: find window class
            it.Sleep(300);
            it.Send("{ENTER}");
            it.Sleep(300);
            it.WinActivate("Beheersjablonen"); //TODO: find window class
            it.Sleep(300);
            it.Send("{ENTER}");
        }

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
