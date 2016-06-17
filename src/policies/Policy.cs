using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies
{
    interface Policy
    {

        string getName();

        PolicyType getType();

        string getDescription();

        bool isEnabled();

        void setEnabled();

        void setDisabled();

    }
}
