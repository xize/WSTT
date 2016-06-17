using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                //for debugging purposes we set it on false to see if it actually finds the reg key within the class scope (if possible, java allows this type of behaviour not sure about C#)
                bool silence = false;

                if(silence)
                {
                    Process proc = Process.Start("regedit.exe", "/s " + name);
                    if (proc.HasExited)
                    {
                        proc.Close();
                    }
                } else
                {
                    Process proc = Process.Start("regedit.exe", " " + name);
                    if (proc.HasExited)
                    {
                        proc.Close();
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("you need to fire this under administrator!");
            }
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
