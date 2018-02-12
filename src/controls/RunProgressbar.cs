using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.controls
{
    [Obsolete]
    public class RunProgressbar : ProgressBar
    {

        public async void RunOnceAnimationAsync()
        {
            this.Value = 100;
            await Task.Delay(TimeSpan.FromSeconds(5));
            this.Value = 0;
        }

    }
}
