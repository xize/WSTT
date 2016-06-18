using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies
{
    class TempExecutionPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override PolicyType getType()
        {
            return PolicyType.POLICY_TEMP_EXECUTION;
        }

        public override string getDescription()
        {
            return "prevents execution on the %temp% folder for normal users\r\ninstallers use trustedinstaller as user this mean that malware has almost zero chance to be installed on the system";
        }

        public override bool isEnabled()
        {

            bool enabled = Config.getConfig().getBoolean("softrestriction");

            if(enabled)
            {
                Console.WriteLine("software restriction is enabled");
            } else
            {
                Console.WriteLine("software restriction is disabled");
            }

            return enabled;
        }

        public override void setEnabled()
        {
            //PolicyManager.getRegPolicy().setPolicyByRegFile("reg/softrestriction_add.reg");
            Config.getConfig().put("softrestriction", true);
        }

        public override void setDisabled()
        {
            //PolicyManager.getRegPolicy().setPolicyByRegFile("reg/softrestriction_del.reg");
            Config.getConfig().put("softrestriction", false);
         }

        public override void writeReg()
        {
            string reg_add = "Windows Registry Editor Version 5.00\n";
            reg_add += "\n";
            string guid1 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid1 + "]\n";
            reg_add += "\"LastModified\"=hex(b):1e,57,0a,23,e5,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,64,00,\\\n";
            reg_add += "  6c,00,6c,00,00,00\n";
            string guid2 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid2 + "]\n";
            reg_add += "\"LastModified\"=hex(b):4a,0b,ab,1e,e5,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,65,00,\\\n";
            reg_add += "  78,00,65,00,00,00\n";
            string guid3 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid3 + "]\n";
            reg_add += "\"LastModified\"=hex(b):17,9d,21,70,ed,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,73,00,\\\n";
            reg_add += "  79,00,73,00,00,00\n";
            string guid4 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid4 + "]\n";
            reg_add += "\"LastModified\"=hex(b):63,fa,ed,76,ed,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_add += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,65,00,78,00,65,00,00,00\n";
            string guid5 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid5 + "]\n";
            reg_add += "\"LastModified\" = hex(b):4f,da,7c,5a,e6,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
            reg_add += "  2e,00,64,00,6c,00,6c,00,00,00\n";
            string guid6 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid6 + "]\n";
            reg_add += "\"LastModified\"=hex(b):dd,8d,42,7d,ed,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_add += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,64,00,6c,00,6c,00,00,00\n";
            string guid7 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid7 + "]\n";
            reg_add += "\"LastModified\"=hex(b):17,40,6d,54,e6,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
            reg_add += "  2e,00,65,00,78,00,65,00,00,00\n";
            string guid8 = generateGUID();
            reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid8 + "]\n";
            reg_add += "\"LastModified\"=hex(b):0d,2c,86,27,e5,c7,d1,01\n";
            reg_add += "\"Description\"=\"\"\n";
            reg_add += "\"SaferFlags\"=dword:00000000\n";
            reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,74,00,\\\n";
            reg_add += "  6d,00,70,00,00,00";

            string reg_del = "Windows Registry Editor Version 5.00\n";
            reg_del += "\n";
            //string guid1 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid1 + "]\n";
            reg_del += "\"LastModified\"=hex(b):1e,57,0a,23,e5,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,64,00,\\\n";
            reg_del += "  6c,00,6c,00,00,00\n";
            //string guid2 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid2 + "]\n";
            reg_del += "\"LastModified\"=hex(b):4a,0b,ab,1e,e5,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,65,00,\\\n";
            reg_del += "  78,00,65,00,00,00\n";
            //string guid3 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid3 + "]\n";
            reg_del += "\"LastModified\"=hex(b):17,9d,21,70,ed,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,73,00,\\\n";
            reg_del += "  79,00,73,00,00,00\n";
            //string guid4 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid4 + "]\n";
            reg_del += "\"LastModified\"=hex(b):63,fa,ed,76,ed,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_del += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,65,00,78,00,65,00,00,00\n";
            //string guid5 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid5 + "]\n";
            reg_del += "\"LastModified\" = hex(b):4f,da,7c,5a,e6,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
            reg_del += "  2e,00,64,00,6c,00,6c,00,00,00\n";
            //string guid6 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid6 + "]\n";
            reg_del += "\"LastModified\"=hex(b):dd,8d,42,7d,ed,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
            reg_del += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,64,00,6c,00,6c,00,00,00\n";
            //string guid7 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid7 + "]\n";
            reg_del += "\"LastModified\"=hex(b):17,40,6d,54,e6,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
            reg_del += "  2e,00,65,00,78,00,65,00,00,00\n";
            //string guid8 = generateGUID();
            reg_del += "[-HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\" + guid8 + "]\n";
            reg_del += "\"LastModified\"=hex(b):0d,2c,86,27,e5,c7,d1,01\n";
            reg_del += "\"Description\"=\"\"\n";
            reg_del += "\"SaferFlags\"=dword:00000000\n";
            reg_del += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,74,00,\\\n";
            reg_del += "  6d,00,70,00,00,00";

            FileStream fs1 = File.Create("softrestriction_add.reg");
            byte[] fs1bytes = Encoding.UTF8.GetBytes(reg_add);
            fs1.Write(fs1bytes, 0, fs1bytes.Length);
            fs1.Flush();
            fs1.Close();

            FileStream fs2 = File.Create("softrestriction_del.reg");
            byte[] fs2bytes = Encoding.UTF8.GetBytes(reg_del);
            fs2.Write(fs2bytes, 0, fs2bytes.Length);
            fs2.Flush();
            fs2.Close();
        }
    }
}
