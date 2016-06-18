using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_tweak_tool.src;
using windows_tweak_tool.src.policies;

namespace windows_tweak.src.policies
{
    class ScriptDisablePolicy : Policy
    {
        public override string getDescription()
        {
            return "disable wscript and powershell scripts";
        }

        public override string getName()
        {
            return getType().getName();
        }

        public override PolicyType getType()
        {
            return PolicyType.POLICY_WSCRIPT_AND_POWERSHELL;
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("scriptdisable");
        }

        public override void setEnabled()
        {
            if(File.Exists("reg/scriptdisable_del.reg"))
            {
                PolicyManager.getRegPolicy().setPolicyByRegFile("reg/scriptdisable_del.reg");
                File.Delete("reg/scriptdisable_del.reg");
                File.Delete("reg/scriptdisable_add.reg");
            }
            writeReg();
            PolicyManager.getRegPolicy().setPolicyByRegFile("reg/scriptdisable_add.reg");
            Config.getConfig().put("scriptdisable", true);
        }

        public override void setDisabled()
        {
            if(File.Exists("reg/scriptdisable_del.reg"))
            {
                PolicyManager.getRegPolicy().setPolicyByRegFile("reg/scriptdisable_del.reg");
                File.Delete("reg/scriptdisable_add.reg");
                File.Delete("reg/scriptdisable_del.reg");
            }
            Config.getConfig().put("scriptdisable", false);
        }

        public override bool hasRegistryIdentifier()
        {
            return true;
        }


        public override void writeReg()
        {
            string reg_add = "Windows Registry Editor Version 5.00\n";
            reg_add += "\n";
            string guid1 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid1+"]\n";
            reg_add += "\"LastModified\"=hex(b):04,b3,58,fe,eb,c4,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=\"C:\\windows\\syswow64\\WindowsPowerShell\"\n";
            string guid2 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid2+"]\n";
            reg_add += "\"LastModified\"=hex(b):9b,a4,c4,f7,eb,c4,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=\"C:\\windows\\system32\\WindowsPowerShell\"\n";
            string guid3 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid3+"]\n";
            reg_add += "\"LastModified\"=hex(b):63,fa,ed,76,ed,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_add += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,65,00,78,00,65,00,00,00\n";
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Script Host\\Settings]\n";
            reg_add += "\"Enabled\"=\"0\"";

            string reg_del = "Windows Registry Editor Version 5.00\n";
            reg_del += "\n";
            //string guid1 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid1 + "]\n";
            reg_del += "\"LastModified\"=hex(b):04,b3,58,fe,eb,c4,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=\"C:\\windows\\syswow64\\WindowsPowerShell\"\n";
            //string guid2 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid2 + "]\n";
            reg_del += "\"LastModified\"=hex(b):9b,a4,c4,f7,eb,c4,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=\"C:\\windows\\system32\\WindowsPowerShell\"\n";
            //string guid3 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid3 + "]\n";
            reg_del += "\"LastModified\"=hex(b):63,fa,ed,76,ed,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_del += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,65,00,78,00,65,00,00,00\n";
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Script Host\\Settings]\n";
            reg_del += "\"Enabled\"=\"0\"";

            FileStream fs1 = File.Create("reg/scriptdisable_add.reg");
            byte[] fs1bytes = Encoding.UTF8.GetBytes(reg_add);
            fs1.Write(fs1bytes, 0, fs1bytes.Length);
            fs1.Flush();
            fs1.Close();

            FileStream fs2 = File.Create("reg/scriptdisable_del.reg");
            byte[] fs2bytes = Encoding.UTF8.GetBytes(reg_del);
            fs2.Write(fs2bytes, 0, fs2bytes.Length);
            fs2.Flush();
            fs2.Close();
        }

    }
}
