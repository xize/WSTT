using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_security_tweak_tool.src.policies;
using windows_security_tweak_tool.src.socket.client;

namespace windows_security_tweak_tool.src.socket
{
    class WClient : WindowsClient
    {

        private Window gui;

        public WClient(Window win)
        {
            this.gui = win;
        }

        public void Connect(string ip)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected()
        {
            throw new NotImplementedException();
        }

        public void ApplyPolicy(SecurityPolicy p)
        {
            p.Apply();
        }

        public SecurityPolicy[] GetClientSecurityPolicies()
        {

            SecurityPolicy[] policies = new SecurityPolicy[SecurityPolicyType.Values().Length-1];

            int i = 0;
            foreach(SecurityPolicyType t in SecurityPolicyType.Values())
            {
                SecurityPolicy p = t.GetPolicy(gui);
                policies[i++] = p;
            }
            return policies; 
        }

        public string GetHost()
        {
            throw new NotImplementedException();
        }

        public string GetIPAddress()
        {
            throw new NotImplementedException();
        }

        public string GetMatchingHandShake()
        {
            throw new NotImplementedException();
        }

        public bool IsPolicyEnabled(SecurityPolicy p)
        {
            throw new NotImplementedException();
        }

        public void UnApplyPolicy(SecurityPolicy p)
        {
            throw new NotImplementedException();
        }
    }
}
