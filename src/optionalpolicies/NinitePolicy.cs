using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool.src.ninite;

namespace windows_tweak_tool.src.optionalpolicies
{
    class NinitePolicy : OptionalPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "install applications by using third party installer called ninite.";
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.NINITE;
        }

        public override void apply()
        {
            foreach(NiniteOption option in NiniteOption.values())
            {
                if(option.isEnabled())
                {
                    this.Add(option);
                }
            }
            this.downloadNiniteInstaller(this.getNiniteURL());
        }

        public override void unapply()
        {
            //not supported   
        }

        public override Button getButton()
        {
            return window.niniteinstallbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return null;
        }
    }
}
