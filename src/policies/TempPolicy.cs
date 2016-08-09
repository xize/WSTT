using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies
{
    class TempPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "sets the policies to protect known malware directories against malware";
        }

        public override PolicyType getType()
        {
            return PolicyType.TEMP_POLICY;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("policy-malware-restriction");
        }

        public override void unapply()
        {
            Process proc = Process.Start("src\\policies\\autoit\\SoftwareRestriction_clear.exe");
            while(true)
            {
				if(proc.HasExited)
                {
                    Config.getConfig().put("policy-malware-restriction", false);
                    break;
                }
            }
        }

        public override void apply()
        {
            Process proc = Process.Start("src\\policies\\autoit\\SoftwareRestriction_create.exe");
            while(true)
            {
				if(proc.HasExited)
                {
                    Config.getConfig().put("policy-malware-restriction", true);
                    break;
                }
            }
        }
    }
}
