﻿/*
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Diagnostics;
using Microsoft.Win32;

namespace windows_tweak_tool.src.policies
{
    class NetbiosPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disable netbios so network viruses have a harder time";
        }

        public override PolicyType getType()
        {
            return PolicyType.NETBIOS_POLICY;
        }

        public override bool isEnabled()
        {
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);
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

        public override void apply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);
            string[] adapters = key.GetSubKeyNames();

            foreach(string adapter in adapters)
            {
                RegistryKey adaptersetting = key.OpenSubKey(adapter, true);

                object options = adaptersetting.GetValue("NetbiosOptions");

                if (options != null)
                {
                    adaptersetting.SetValue("NetbiosOptions", 2);
                }
            }
            key.Close();
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces", REG.HKLM);

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
            getButton().Enabled = true;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override Button getButton()
        {
            return gui.netbiosbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.netbiosprogress;
        }

        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }
    }
}
