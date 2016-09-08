using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class UpdatePolicy : Policy
    {

        public override void apply()
        {
            Process proc = Process.Start("gpupdate", "/force");
            while (proc.HasExited)
            {
                Console.WriteLine("I'm done with updating the policies! :D");
            }
        }

        public override Button getButton()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            return "updates the policy, this is not a UI element.";
        }

        public override string getName()
        {
            return "update policy";
        }

        public override ProgressBar getProgressbar()
        {
            throw new NotImplementedException();
        }

        public override PolicyType getType()
        {
            throw new NotImplementedException();
        }

        public override bool isEnabled()
        {
            return false;
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }
    }
}
