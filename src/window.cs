using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool;
using windows_tweak_tool.src;
using windows_tweak_tool.src.policies;

namespace windows_tweak_tool
{
    public partial class window : Form
    {
        public window()
        {
            Config.getConfig().readConfig();
            InitializeComponent();
            initializeGuiWithPolicies(); //cannot use this yet because of a issue with instance loading ;-)
        }

        private void initializeGuiWithPolicies()
        {

            bool msg = false;

            foreach (PolicyType a in PolicyType.values())
            {
                Policy p = a.getPolicy(this);
                if(p.getType() != PolicyType.UPDATE_POLICY)
                {
                    if (p.isEnabled())
                    {
                        p.getButton().Text = "Undo";
                        p.getProgressbar().Value = 100;
                    }


                    if (!p.isSecpolEnabled() && p.isSecpolDepended())
                    {
                            Console.WriteLine("Warning: policy " + p.getName() + " has been disabled unsupported windows edition, no secpol.msc found!");
                            p.getButton().Enabled = false;
                            p.getProgressbar().Enabled = false;
                            p.getButton().Text = "unsupported!";
                    }

                    if (!p.isAutoItInstalled() && p.isMacro())
                    {
                        if(msg == false)
                        {
                            msg = !msg;
                            MessageBox.Show("you are missing a important dependency please download at: https://www.autoitscript.com/site/autoit/downloads/");
                        }
                            Console.WriteLine("Warning: policy " + p.getName() + " has been disabled, missing AutoIT dll file");
                            p.getButton().Enabled = false;
                            p.getProgressbar().Enabled = false;
                            p.getButton().Text = "Error!";
                    }
                }
               

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
            Policy p = PolicyType.TEMP_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
                temp_policy_load.Value = 0;
                temp_policy_btn.Text = "Apply";
            } else
            {
                p.apply();
                temp_policy_load.Value = 100;
                temp_policy_btn.Text = "Undo";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void wscript_btn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.WSCRIPT_POLICY.getPolicy(this);
            if (p.isEnabled())
            {
                p.unapply();
                wscript_progress.Value = 0;
                wscript_btn.Text = "Apply";
            }
            else
            {
                p.apply();
                wscript_progress.Value = 100;
                wscript_btn.Text = "Undo";
            }
        }

        private void wscript_progress_Click(object sender, EventArgs e)
        {

        }

        private void uac_btn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.UAC_POLICY.getPolicy(this);
            if(p.isEnabled())
            {
                p.unapply();
                uac_btn.Text = "Apply";
                uac_progress.Value = 0;
            } else
            {
                p.apply();
                uac_btn.Text = "Undo";
                uac_progress.Value = 100;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
