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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class AutoPlayPolicy : SecurityPolicy
    {
        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables auto play so removable devices cannot auto run programs on the computer";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.AUTOPLAY_POLICY;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;
            await Task.Run(()=>ApplyAsync());
            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            RegistryKey key = GetRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            key.SetValue("NoDriveTypeAutoRun", 0x00);
            key.Close();
            key.Dispose();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;
            await Task.Run(()=>UnapplyAsync());
            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {
            RegistryKey key = GetRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            key.SetValue("NoDriveTypeAutoRun", 0xFF);
            key.Close();
            key.Dispose();
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsEnabled()
        {
            RegistryKey key = GetRegistry(@"Software\Microsoft\Windows\CurrentVersion\policies\Explorer\", REG.HKLM);
            try
            {
                var value = key.GetValue("NoDriveTypeAutoRun");
                key.Close();
                key.Dispose();
                return ((int)value != 0xFF ? true : false);
            } catch(NullReferenceException)
            {
                return false;
            }
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return true;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }

        public override Button GetButton()
        {
            return gui.autoplaybtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.autoplayprogress;
        }

    }
}
