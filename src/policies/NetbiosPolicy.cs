using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies
{
    class NetbiosPolicy : Policy
    {
        public string getDescription()
        {
            return "disable netbios over ip";
        }

        public string getName()
        {
            return getType().getName();
        }

        public PolicyType getType()
        {
            return PolicyType.POLICY_NETBIOS_OVER_IP;
        }

        public bool isEnabled()
        {
            return Config.getConfig().getBoolean("netbios");
        }

        public void setEnabled()
        {
            Process proc1 = Process.Start("wmic.exe", "/interactive:off nicconfig where TcpipNetbiosOptions=0 call SetTcpipNetbios 2");
            if(proc1.HasExited)
            {
                proc1.Close();
            }
            Process proc2 = Process.Start("wmic.exe", "/interactive:off nicconfig where TcpipNetbiosOptions=1 call SetTcpipNetbios 2");
            if(proc2.HasExited)
            {
                proc2.Close();
            }
            Config.getConfig().put("netbios", true);
        }

        public void setDisabled()
        {
            Process proc1 = Process.Start("wmic.exe", "/interactive:off nicconfig where TcpipNetbiosOptions=0 call SetTcpipNetbios 1");
            if(proc1.HasExited)
            {
                proc1.Close();
            }
            Process proc2 = Process.Start("wmic.exe", "/interactive:off nicconfig where TcpipNetbiosOptions=1 call SetTcpipNetbios 1");
            if(proc2.HasExited)
            {
                proc2.Close();
            }
            Config.getConfig().put("netbios", false);
        }

    }
}
