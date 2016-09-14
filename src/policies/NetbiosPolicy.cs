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
            Console.WriteLine("data: "+key.ToString());
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
    }
}
