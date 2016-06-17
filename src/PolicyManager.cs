using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src
{
    class PolicyManager
    {

       private static PolicyManager policy;

       private PolicyManager() {} /* only instance inside the class */

        public bool checkPolicy(string path, String key, object expected)
        {
            object result = getValue(path, key);
            if(result == expected && result.Equals(expected))
            {
                return true;
            }
            return false;
        }

        public void setPolicy(string path, string key, object data)
        {
            Registry.SetValue(path, key, data);
        }

        public void setPolicyByRegFile(string name)
        {
            Process.Start("regedit.exe", "/s "+name);
        }

        private object getValue(string path, string key)
        {
            return Registry.GetValue(path, key, null);
        }

        public static PolicyManager getRegPolicy()
        {
            if(policy == null)
            {
                policy = new PolicyManager();
            }
            return policy;
        }

    }
}
