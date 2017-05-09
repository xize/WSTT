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
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool;
using windows_tweak_tool.src;
using windows_tweak_tool.src.policies;

namespace windows_tweak_tool
{
    public partial class Window : Form
    {

        private OptionalWindow optionalw;
        private bool mouseDown = false;
        private Point lastLocation;

        public Window()
        {
            Config.getConfig().readConfig();
            InitializeComponent();
            if (this.optionalw == null)
            {
               this.optionalw = new OptionalWindow();
            }
            initializeGuiWithPolicies(); //cannot use this yet because of a issue with instance loading ;-)
            this.Text = String.Format("Windows Security Tweaker Tool {0}b(WSTT)", Application.ProductVersion);
            makeMoveAbleGui();
        }

        private void makeMoveAbleGui()
        {
            foreach(Control c in this.Controls)
            {
                setMoveAble(c);
                if(c.Controls.Count > 1)
                {
                    foreach(Control submodule in c.Controls)
                    {
                        setMoveAble(submodule);
                    }
                }
            }
        }

        private void initializeGuiWithPolicies()
        {

            /*

            foreach (SecurityPolicyType a in SecurityPolicyType.values())
            {
                SecurityPolicy p = a.getPolicy(this);

                if(p.getType() != SecurityPolicyType.UPDATE_POLICY)
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
                }
            }
            */
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public OptionalWindow getOptionalWindow()
        {
            return optionalw;
        }

        private void callTempPolicyEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.TEMP_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
        }

        private void callwscriptEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.WSCRIPT_POLICY.getPolicy(this);
            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void callUACEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.UAC_POLICY.getPolicy(this);
            if(p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
        }

        private void callNetbiosEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NETBIOS_POLICY.getPolicy(this);
            if(p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
        }

        private void callRenameEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.RENAME_POLICY.getPolicy(this);

            if(p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
        }

        private void versionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void callRemoteRegEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.REMOTE_REGISTRY_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void callRDPEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.RDP_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void callNTLMEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NTLM_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {

                DialogResult dialog = MessageBox.Show("if you are a bussiness and the users are connected to the domain controller this option will break your settings, this option only suits home users if you want to continue this click yes", "Warning: do not use this on clients connected to domain controllers!", MessageBoxButtons.YesNo);

                if(dialog == DialogResult.No)
                {
                    return;
                }

                p.apply();
            }
        }

        private void callMBREvent(object sender, EventArgs e)
        {
            SecurityPolicy p = null;

            DialogResult result = MessageBox.Show("If you plan to use this feature please note that we have not developed MBRFilter\n\nMBRFilter is licensed under the GPLv2 License and maintained by Yves Younan, Cisco Talos at https://github.com/vrtadmin/MBRFilter\n\nby clicking \"yes\" you agree with their license", "Warning Third party driver", MessageBoxButtons.YesNo);

            if(result == DialogResult.No)
            {
                return;
            }

            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void callMBRfilterlabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process proc = Process.Start("https://github.com/vrtadmin/MBRFilter");
            proc.Dispose();
        }

        /*
        private void callSafeApplyEvent(object sender, EventArgs e)
        {
            safeapplybtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.values())
            {
                if(pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.getPolicy(this);
                    p.getButton().Enabled = false;
                }
            }

            foreach (SecurityPolicyType pt in SecurityPolicyType.values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.getPolicy(this);
                    if(p.isSafeForBussiness())
                    {
                        if(!p.isEnabled() && !p.isUserControlRequired())
                        {
                            p.apply();
                        }
                    }
                }
            }

            foreach (SecurityPolicyType pt in SecurityPolicyType.values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.getPolicy(this);
                    p.getButton().Enabled = true;
                }
            }
            safeapplybtn.Enabled = true;
            MessageBox.Show("All \"safe\" policies have been applied!", "Policies with success applied!");
        }

        private void callApplyEvent(object sender, EventArgs e)
        {
            applyforcebtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.getPolicy(this);
                    if(!p.isUserControlRequired() && !p.isEnabled())
                    {
                        if(p.isSecpolDepended() && !p.isSecpolEnabled())
                        {
                            continue;
                        }
                        p.apply();
                    }
                }
            }
            applyforcebtn.Enabled = true;
            MessageBox.Show("All policies have been applied!, those who are not require user control.", "Policies with success applied!");
    }

        private void callUndoEvent(object sender, EventArgs e)
        {
            undobtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY && !pt.getPolicy(this).isUserControlRequired())
                {
                    SecurityPolicy p = pt.getPolicy(this);
                    if (!p.isUserControlRequired() && p.isEnabled())
                    {
                        if (p.isSecpolDepended() && !p.isSecpolEnabled())
                        {
                            continue;
                        }
                        p.unapply();
                    }
                }
            }
            undobtn.Enabled = true;
        }
        */

        private void callInsecureServicesEvent(object sender, EventArgs e) 
        {

        }

        private void callBogusCertEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.CERT_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void tempolicylabel_Click(object sender, EventArgs e)
        {

        }

        private void boguscertlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process a = Process.Start("https://technet.microsoft.com/en-us/sysinternals/");
            a.Dispose();
        }

        private void window_Load(object sender, EventArgs e)
        {

        }

        private void netsharebtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NETSHARE_POLICY.getPolicy(this);

            if (p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
        }

        private void openOptionalOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionalw.Visible = true;
           // openOptionalOptionsToolStripMenuItem.Enabled = false;
        }

        private void llmnrbtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.LLMNR_POLICY.getPolicy(this);
            if (p.isEnabled())
            {
                p.unapply();
            }
            else
            {
                p.apply();
            }
        }

        private void resetPoliciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Config.getConfig().getDataFolder()+@"\config.txt"))
            {
                File.Delete(Config.getConfig().getDataFolder()+@"\config.txt");
            }

            string[] cmdargs = { "/c RD /S /Q \"%WinDir%\\System32\\GroupPolicyUsers\"", "/c RD /S /Q \"%WinDir%\\System32\\GroupPolicy\"" };
            foreach(string arg in cmdargs)
            {
                ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
                info.Arguments = arg;
                Process pr = Process.Start(info);
                pr.WaitForExit();
                pr.Dispose();
            }

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.getPolicy(this);
            p.apply();

            MessageBox.Show("WSTT needs to be restarted ;-)");

            Application.Exit();

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void securityControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void setMoveAble(Control c)
        {
            c.MouseDown += new MouseEventHandler(Form1_MouseDown);
            c.MouseMove += new MouseEventHandler(Form1_MouseMove);
            c.MouseUp += new MouseEventHandler(Form1_MouseUp);
        }

        private void securityControl_DARK1_Load(object sender, EventArgs e)
        {

        }
    }
}
