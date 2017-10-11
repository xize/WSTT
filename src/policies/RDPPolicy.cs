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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class RDPPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables remote desktop protocol so people are not able to remotely control your computer";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.RDP_POLICY;
        }

        public override bool IsEnabled()
        {
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\Control\Remote Assistance", REG.HKLM);
            object denyconnections = key.GetValue("fAllowToGetHelp");
            bool state = (int)denyconnections != 0;
            if(state)
            {
                key.Close();
                return true;
            }
            key.Close();
            return false;
        }

        public override void Apply()
        {
            GetButton().Enabled = false;
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\Control\Remote Assistance", REG.HKLM);
            key.SetValue("fAllowToGetHelp", 1);
            key.Close();
            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public override void Unapply()
        {
            GetButton().Enabled = false;
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\Control\Remote Assistance", REG.HKLM);
            key.SetValue("fAllowToGetHelp", 0);
            key.Close();
            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        public override Button GetButton()
        {
            return gui.rdpbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.rdpprogress;
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSecpolDepended()
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
