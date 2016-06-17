using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies
{
    class JSFilePolicy : Policy
    {
        public string getDescription()
        {
            return "change file accosiation from javascript to notepad so it will not be executable like vbs files";
        }

        public string getName()
        {
            return getType().getName();
        }

        public PolicyType getType()
        {
            return PolicyType.POLICY_JS_FILE_ACC;
        }

        public bool isEnabled()
        {
            return Config.getConfig().getBoolean("JSFileACC");
        }

        public void setEnabled()
        {
            PolicyManager.getRegPolicy().setPolicyByRegFile("jsfile_add.reg");
            Config.getConfig().put("JSFileACC", true);
        }

        public void setDisabled()
        {
            PolicyManager.getRegPolicy().setPolicyByRegFile("jsfile_del.reg");
            Config.getConfig().put("JSFileACC", false);
        }
    }
}
