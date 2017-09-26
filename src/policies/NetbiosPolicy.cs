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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace windows_security_tweak_tool.src.policies
{
    class NetbiosPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disable netbios so network viruses have a harder time";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.NETBIOS_POLICY;
        }

        public override bool IsEnabled()
        {
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);
            string[] adapters = key.GetSubKeyNames();

            foreach (string adapter in adapters)
            {
                RegistryKey adaptersetting = key.OpenSubKey(adapter, true);

                object options = adaptersetting.GetValue("NetbiosOptions");
                if(options != null)
                {
                    int option = (int)options;
                    if(option == 2)
                    {
                        key.Close();
                        return true;
                    }
                }
            }
            key.Close();
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);
            string[] adapters = key.GetSubKeyNames();

            foreach (string adapter in adapters)
            {

                Console.WriteLine("writing to adapter: " + adapter + " setting netbios to value 2");

                RegistryKey adaptersetting = key.OpenSubKey(adapter, true);

                object options = adaptersetting.GetValue("NetbiosOptions");

                if (options != null)
                {
                    adaptersetting.SetValue("NetbiosOptions", 2);
                }
            }
            key.Close();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            GetButton().Enabled = true;
            SetGuiDisabled(this);
        }

        public void UnapplyAsync()
        {
            RegistryKey key = GetRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);

            string[] adapters = key.GetSubKeyNames();

            foreach (string adapter in adapters)
            {
                RegistryKey adaptersetting = key.OpenSubKey(adapter, true);

                object options = adaptersetting.GetValue("NetbiosOptions");

                if (options != null)
                {
                    adaptersetting.SetValue("NetbiosOptions", 0);
                }
            }
            key.Close();
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override Button GetButton()
        {
            return gui.netbiosbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.netbiosprogress;
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
