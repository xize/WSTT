using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src
{
    public partial class Window2 : Form
    {

        private int savestatus = 0;


        public Window2()
        {
            InitializeComponent();
            filebtn.Click += new EventHandler(FileBtnClickEvent);
            settingbtn.Click += new EventHandler(SettingBtnClickEvent);
        }

        public int Status
        {
            get
            {
                return this.savestatus;
            }
            set
            {
                this.savestatus = value;
            }
        }

        public Image GetWindowTitle
        {
            get
            {
                if(this.savestatus == 0)
                {
                    return Properties.Resources.wstt_title_saved;
                } else
                {
                    return Properties.Resources.wstt_title_unsaved;
                }
            }
        }

        
        public new void Update()
        {
            this.panel1.BackgroundImage = GetWindowTitle;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Window2_Load(object sender, EventArgs e)
        {

        }

        private void filebtn_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FileBtnClickEvent(object sender, EventArgs e)
        {
            filesmenustrip.Show(this, new Point(72, 70));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingBtnClickEvent(object sender, EventArgs e)
        {
            settingsmenustrip.Show(this, new Point(114, 70));
        }
    }
}
