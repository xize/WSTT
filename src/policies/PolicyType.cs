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

namespace windows_tweak_tool.src.policies
{
    class PolicyType {

        protected static HashSet<PolicyType> types = new HashSet<PolicyType>();

        public static PolicyType TEMP_POLICY = new PolicyType("temp_policy", new TempPolicy());
        public static PolicyType WSCRIPT_POLICY = new PolicyType("wscript_policy", new WscriptPolicy());
        public static PolicyType UPDATE_POLICY = new PolicyType("update_policy", new UpdatePolicy());
        public static PolicyType UAC_POLICY = new PolicyType("uac_policy", new UacPolicy());
        public static PolicyType NETBIOS_POLICY = new PolicyType("netbios_policy", new NetbiosPolicy());
        public static PolicyType RENAME_POLICY = new PolicyType("rename_policy", new RenamePolicy());
        public static PolicyType REMOTE_REGISTRY_POLICY = new PolicyType("remote_registry_policy", new RemoteRegistryPolicy());
        public static PolicyType RDP_POLICY = new PolicyType("rdp_policy", new RDPPolicy());
        public static PolicyType NTLM_POLICY = new PolicyType("ntlm_policy", new NTLMPolicy());
        //public static PolicyType MBR_POLICY = new PolicyType("mbr_policy", new MBRPolicy());
        public static PolicyType CERT_POLICY = new PolicyType("cert_policy", new CertPolicy());

        private string name;
        private Policy pol;

        private PolicyType(string name, Policy pol)
        {
            types.Add(this);
            this.name = name;
            this.pol = pol;
        }

        public string getName()
        {
            return name;
        }

        public Policy getPolicy(window wind)
        {
            pol.setGui(wind);
            return pol;
        }

        public static PolicyType valueOf(string name)
        {
            foreach(PolicyType type in values().getAll())
            {
                if(type.getName().ToUpper() == name.ToUpper())
                {
                    return type;
                }
            }
            return null;
        }

        public static Iterator<PolicyType> values()
        {
            return new Iterator<PolicyType>(types);
        }
    }

    class Iterator<T>
    {
        private T[] elements;
        private int index = 0;

        public Iterator(HashSet<T> data)
        {
            this.elements = data.ToArray();
        }

        public bool hasNext()
        {
            if(index <= this.elements.Length)
            {
                return true;
            }
            return false;
        }

        public T next()
        {
            if(this.hasNext())
            {
                return this.elements[index++];
            }
            throw new Exception("Iterator exception: cannot get empty object");
        }

        public T[] getAll()
        {
            return elements;
        }

    }
}
