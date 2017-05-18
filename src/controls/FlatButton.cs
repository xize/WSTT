using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.controls
{
    public class FlatButton : Button
    {

        public FlatButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.LightBlue;
        }

    }
}
