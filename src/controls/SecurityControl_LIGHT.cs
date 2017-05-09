using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.controls
{
    public partial class SecurityControl_LIGHT : UserControl
    {

        private bool isWIP = false;

        public SecurityControl_LIGHT()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClick;


        protected void button_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public bool WIP
        {
            get
            {
                if (isWIP)
                {
                    this.ButtonColor = Color.Black;
                    this.flatButton1.ForeColor = Color.Gray;
                    this.flatButton1.Text = "WIP";
                    this.flatButton1.Enabled = false;
                    this.flatButton1.Update();
                }
                else
                {
                    this.ButtonColor = Color.LightBlue;
                    this.flatButton1.ForeColor = Color.White;
                    this.flatButton1.Text = "run!";
                    this.flatButton1.Enabled = true;
                    this.flatButton1.Update();
                }
                return isWIP;
            }
            set
            {
                this.isWIP = value;
            }
        }

        public string ButtonText
        {
            get { return this.flatButton1.Text; }
            set { this.flatButton1.Text = value; }
        }

        public Color ButtonColor
        {
            get { return flatButton1.BackColor; }
            set { this.flatButton1.BackColor = value; }
        }

        public string[] Description
        {
            get { return label1.Text.Split('\n'); }
            set { this.label1.Text = getDescription(value); }
        }

        private string getDescription(string[] values)
        {
            string a = "";
            foreach (string line in values)
            {
                a += line + "\n";
            }
            return a;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void SecurityControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
