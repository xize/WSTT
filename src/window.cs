/*
    A security toolkit for windows    

    Copyright(C) 2016 Guido Lucassen

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.Text = String.Format("Windows Security Tweaker Tool {0}b(WSTT)", Application.ProductVersion);
        }

        private void initializeGuiWithPolicies()
        {

            bool msg = false;

            foreach (PolicyType a in PolicyType.values())
            {
                Policy p = a.getPolicy(this);

                if(p.getType() != PolicyType.UPDATE_POLICY)
                {

                    tooltip.SetToolTip(p.getButton(), p.getDescription());
                    tooltip.SetToolTip(p.getProgressbar(), p.getDescription());

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

        private void netbiosbtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.NETBIOS_POLICY.getPolicy(this);
            if(p.isEnabled())
            {
                p.unapply();
                netbiosbtn.Text = "Apply";
                netbiosprogress.Value = 0;
            } else
            {
                p.apply();
                netbiosbtn.Text = "Undo";
                netbiosprogress.Value = 100;
            }
        }

        private void renamebtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.RENAME_POLICY.getPolicy(this);

            if(p.isEnabled())
            {
                p.unapply();
                renamebtn.Text = "Apply";
                renameprogress.Value = 0;
            } else
            {
                p.apply();
                renamebtn.Text = "Undo";
                renameprogress.Value = 100;
            }
        }

        private void window_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.ninite.com/");
        }

        private void versionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void remoteregbtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.REMOTE_REGISTRY_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
                remoteregbtn.Text = "Apply";
                remoteregprogress.Value = 0;
            }
            else
            {
                p.apply();
                remoteregbtn.Text = "Undo";
                remoteregprogress.Value = 100;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void rdpbtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.RDP_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
                rdpbtn.Text = "Apply";
                rdpprogress.Value = 0;
            }
            else
            {
                p.apply();
                rdpbtn.Text = "Undo";
                rdpprogress.Value = 100;
            }
        }

        private void NTLMbtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.NTLM_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
                NTLMbtn.Text = "Apply";
                NTLMProgress.Value = 0;
            }
            else
            {
                p.apply();
                NTLMbtn.Text = "Undo";
                NTLMProgress.Value = 100;
            }
        }

        private void mbrbtn_Click(object sender, EventArgs e)
        {
            Policy p = PolicyType.MBR_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
                mbrbtn.Text = "Apply";
                mbrprogress.Value = 0;
            }
            else
            {
                p.apply();
                mbrbtn.Text = "Undo";
                mbrprogress.Value = 100;
            }
        }

        private void mbrprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
