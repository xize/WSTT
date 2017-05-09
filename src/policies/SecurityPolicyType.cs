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
using System;
using System.Collections.Generic;
using System.Linq;
using windows_tweak_tool.src.optionalpolicies;

namespace windows_tweak_tool.src.policies
{
    class SecurityPolicyType {

        protected static HashSet<SecurityPolicyType> types = new HashSet<SecurityPolicyType>();

        public static SecurityPolicyType TEMP_POLICY = new SecurityPolicyType("temp_policy", new TempPolicy());
        public static SecurityPolicyType WSCRIPT_POLICY = new SecurityPolicyType("wscript_policy", new WscriptPolicy());
        public static SecurityPolicyType UPDATE_POLICY = new SecurityPolicyType("update_policy", new UpdatePolicy());
        public static SecurityPolicyType UAC_POLICY = new SecurityPolicyType("uac_policy", new UacPolicy());
        public static SecurityPolicyType NETBIOS_POLICY = new SecurityPolicyType("netbios_policy", new NetbiosPolicy());
        public static SecurityPolicyType RENAME_POLICY = new SecurityPolicyType("rename_policy", new RenamePolicy());
        public static SecurityPolicyType REMOTE_REGISTRY_POLICY = new SecurityPolicyType("remote_registry_policy", new RemoteRegistryPolicy());
        public static SecurityPolicyType RDP_POLICY = new SecurityPolicyType("rdp_policy", new RDPPolicy());
        public static SecurityPolicyType NTLM_POLICY = new SecurityPolicyType("ntlm_policy", new NTLMPolicy());
        //public static PolicyType MBR_POLICY = new PolicyType("mbr_policy", new MBRPolicy());
        public static SecurityPolicyType CERT_POLICY = new SecurityPolicyType("cert_policy", new CertPolicy());
        public static SecurityPolicyType NETSHARE_POLICY = new SecurityPolicyType("netshare_policy", new NetSharePolicy());
        public static SecurityPolicyType LLMNR_POLICY = new SecurityPolicyType("llmnr_policy", new LLMNRPolicy());
        public static SecurityPolicyType IN_SECURE_SERVICES_POLICY = new SecurityPolicyType("in_secure_services_policy", new InSecureServicesPolicy());

        private string name;
        private SecurityPolicy pol;

        public SecurityPolicyType(string name, SecurityPolicy pol)
        {
            types.Add(this);
            this.name = name;
            this.pol = pol;
        }

        public string getName()
        {
            return name;
        }

        public SecurityPolicy getPolicy(Window wind)
        {
            pol.setGui(wind);
            return pol;
        }

        public static SecurityPolicyType valueOf(string name)
        {
            foreach(SecurityPolicyType type in values())
            {
                if(type.getName().ToUpper() == name.ToUpper())
                {
                    return type;
                }
            }
            return null;
        }

        public static SecurityPolicyType[] values()
        {
            return types.ToArray();
        }
    }
}
