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

        public abstract void apply();

        public abstract void unapply();

        protected String generateGUID()
        {
            return "{"+Guid.NewGuid().ToString()+"}";
        }

    }
}
