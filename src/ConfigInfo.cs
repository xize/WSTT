using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool
{
    interface ConfigInfo
    {

        String getString(String node);

        int getInt(String node);

        double getDouble(String node);

        Boolean getBoolean(string node);

        void put(String node, Object obj);
    }
}
