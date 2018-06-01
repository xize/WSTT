using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.Properties;

namespace windows_security_tweak_tool.src.controls
{
    public partial class DescriptionProgressBar : UserControl
    {

        public DescriptionProgressBar()
        {
            InitializeComponent();
        }

        public string Description
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public bool SetActive
        {
            get
            {
                return (this.progressBar1.Value == 100 ? true : false);
            }
            set
            {
                this.progressBar1.Value = (value ? 100 : 0);
            }
        }

        public string AddCheckBox
        {
            get
            {
                if(b.Text == "")
                {
                    //b.Hide();
                    b.Hide();
                    b.Text = "";
                }
                return b.Text;
            }
            set
            {
                this.b.Text = value;
                if(b.Text != "")
                {
                    b.Show();
                }

            }
        }

        public bool CheckboxChecked
        {
            get
            {
                return b.Checked;
            }
        }


        private void DescriptionProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
