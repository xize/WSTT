using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    abstract class Policy
    {

        public abstract string getName();

        public abstract PolicyType getType();

        public abstract string getDescription();

        public abstract bool isEnabled();

        public abstract void setEnabled();

        public abstract void setDisabled();

        public void writeReg()
        {
            switch(getType().getName())
            {
                case "JS_FILE_ACC":
                    PolicyManager.getRegPolicy().setPolicyByRegFile("reg/jsfile_add.reg");
                    break;
                case "NETBIOS_OVER_IP":
                    MessageBox.Show("POLICY_NETBIOS_OVER_IP does not use registry keys!");
                    break;
                case "TEMP_EXECUTION":

                    string reg_add = "Windows Registry Editor Version 5.00\n";
                    reg_add += "\n";
                    string guid1 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid1+"]\n";
                    reg_add += "\"LastModified\"=hex(b):1e,57,0a,23,e5,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,64,00,\\\n";
                    reg_add += "  6c,00,6c,00,00,00\n";
                    string guid2 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid2+"]\n";
                    reg_add += "\"LastModified\"=hex(b):4a,0b,ab,1e,e5,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,65,00,\\\n";
                    reg_add += "  78,00,65,00,00,00\n";
                    string guid3 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid3+"]\n";
                    reg_add += "\"LastModified\"=hex(b):17,9d,21,70,ed,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,2e,00,73,00,\\\n";
                    reg_add += "  79,00,73,00,00,00\n";
                    string guid4 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid4+"]\n";
                    reg_add += "\"LastModified\"=hex(b):63,fa,ed,76,ed,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
                    reg_add += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,65,00,78,00,65,00,00,00\n";
                    string guid5 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid5+"]\n";
                    reg_add += "\"LastModified\" = hex(b):4f,da,7c,5a,e6,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
                    reg_add += "  2e,00,64,00,6c,00,6c,00,00,00\n";
                    string guid6 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid6+"]\n";
                    reg_add += "\"LastModified\"=hex(b):dd,8d,42,7d,ed,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,4c,00,6f,00,63,00,61,00,6c,00,41,00,70,00,70,00,44,00,\\\n";
                    reg_add += "  61,00,74,00,61,00,25,00,5c,00,2a,00,2e,00,64,00,6c,00,6c,00,00,00\n";
                    string guid7 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid7+"]\n";
                    reg_add += "\"LastModified\"=hex(b):17,40,6d,54,e6,c7,d1,01\n";
                    reg_add += "\"Description\"=\"\"\n";
                    reg_add += "\"SaferFlags\"=dword:00000000\n";
                    reg_add += "\"ItemData\"=hex(2):25,00,74,00,65,00,6d,00,70,00,25,00,5c,00,2a,00,5c,00,2a,00,\\\n";
                    reg_add += "  2e,00,65,00,78,00,65,00,00,00\n";
                    string guid8 = generateGUID();
                    reg_add += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Safer\\CodeIdentifiers\\0\\Paths\\"+guid8+"]\n";
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
                    break;
                case "WSCRIPT_AND_POWERSHELL":
                    //TODO: write reg for WSCRIPT_AND_POWERSHELL
                    break;
            }
        }

        private String generateGUID()
        {
            return "{"+Guid.NewGuid().ToString()+"}";
        }

    }
}
