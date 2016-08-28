using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class WscriptPolicy : Policy
    {
        private RegistryKey reg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE").OpenSubKey("Microsoft").OpenSubKey("Windows Script Host").OpenSubKey("Settings", true);

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables wscript to be runnable :)";
        }

        public override PolicyType getType()
        {
            return PolicyType.WSCRIPT_POLICY;
        }

        public override bool isEnabled()
        {
            if(reg.GetValue("Enabled") != null)
            {
                int value = (int)reg.GetValue("Enabled");

                if (value == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override void unapply()
        {
            reg.SetValue("Enabled", 1);
        }

        public override void apply()
        {
            reg.SetValue("Enabled", 0);
        }

        public override ProgressBar getProgressbar()
        {
            return Program.getGui().wscript_progress;
        }

        public override Button getButton()
        {
            return Program.getGui().wscript_btn;
        }
    }
}