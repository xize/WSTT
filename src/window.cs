using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool;
using windows_tweak_tool.src.policies;

namespace windows_tweak_tool
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
            Policy p = PolicyType.POLICY_TEMP_EXECUTION.getPolicy();

            if (p.isEnabled())
            {
                this.progressBar1.Value = 100;
                this.button1.Text = "Disable";
            }
            else
            {
                Console.WriteLine("init enabling progessbar failed, policy was false");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void progressBar13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void progressBar22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Policy p = PolicyType.POLICY_TEMP_EXECUTION.getPolicy();

            if(p.isEnabled())
            {
                p.setDisabled();
                progressBar1.Value = 0;
                button1.Text = "Apply";
            } else
            {
                p.setEnabled();
                progressBar1.Value = 100;
                button1.Text = "Disable";
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
