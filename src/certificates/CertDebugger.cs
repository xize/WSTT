using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src
{
    public partial class CertDebugger : Form
    {
        private DialogResult r;

        public CertDebugger()
        {
            InitializeComponent();
            panel1.Click += new EventHandler(panel1_onClick);
            label4.Click += new EventHandler(panel1_onClick);
        }

        private void CertDebugger_Load(object sender, EventArgs e)
        {

        }

        private void panel1_onClick(object sender, EventArgs e)
        {
            this.r = openFileDialog1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                string path = openFileDialog1.FileName;
                try
                {
                    X509Certificate cert = X509Certificate.CreateFromSignedFile(path);
                    DateTime time = DateTime.Parse(cert.GetExpirationDateString());
                    textBox1.Text = cert.GetCertHashString();
                    textBox2.Text = ""+time.Ticks;
            } catch(Exception)
                {
                textBox1.Text = "invalid!";
                textBox2.Text = "invalid!";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
