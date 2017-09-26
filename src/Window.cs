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
using windows_security_tweak_tool;
using windows_security_tweak_tool.src;
using windows_security_tweak_tool.src.policies;

namespace windows_security_tweak_tool.src
{
    public partial class Window : Form
    {

        private OptionalWindow optionalw;

        public Window()
        {
            Config.GetConfig().ReadConfig();
            InitializeComponent();
            if(this.optionalw == null)
            {
               this.optionalw = new OptionalWindow();
            }
            initializeGuiWithPolicies(); //cannot use this yet because of a issue with instance loading ;-)

            this.Text = String.Format("Windows Security Tweaker Tool {0}b(WSTT)", Application.ProductVersion);
        }

        private void initializeGuiWithPolicies()
        {
            Logger.getSubTreeLogger().LogTitle("initialize policy components!");
            foreach (SecurityPolicyType a in SecurityPolicyType.Values())
            {
                SecurityPolicy p = a.GetPolicy(this);

                DateTime startTime = DateTime.Now;

                Logger.getSubTreeLogger().LogTitle("===[initializing policy: "+ p.GetName()+"]===");

                if(p.GetPolicyType() != SecurityPolicyType.UPDATE_POLICY)
                {

                    tooltip.SetToolTip(p.GetButton(), p.GetDescription());
                    tooltip.SetToolTip(p.GetProgressbar(), p.GetDescription());

                    if (p.IsEnabled())
                    {
                        p.GetButton().Text = "Undo";
                        p.GetProgressbar().Value = 100;
                    }


                    if (!p.IsSecpolEnabled() && p.IsSecpolDepended())
                    {
                            Console.WriteLine("Warning: policy " + p.GetName() + " has been disabled unsupported windows edition, no secpol.msc found!");
                            p.GetButton().Enabled = false;
                            p.GetProgressbar().Enabled = false;
                            p.GetButton().Text = "unsupported!";
                    } else if(p.IsMacro() && !(File.Exists("AutoItX3.Assembly.dll") && File.Exists("AutoItX3.dll") && File.Exists("AutoItX3_x64.dll")))
                    {
                        Console.WriteLine("Warning: policy " + p.GetName() + " has been disabled, no AutoIT files found!");
                        p.GetButton().Enabled = false;
                        p.GetProgressbar().Enabled = false;
                        p.GetButton().Text = "AutoIT dll missing!";
                    }
                }

                DateTime endTime = DateTime.Now;

                double ms = (endTime-startTime).TotalMilliseconds;

                Logger.getSubTreeLogger().LogTree("is enabled?: "+ (p.IsEnabled() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("has incompatibility issues between multiple versions of windows?: "+ (p.HasIncompatibilityIssues() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("is macro depended?: " + (p.IsMacro() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("is safe for bussiness?: " + (p.IsSafeForBussiness() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("depends on secpol?: " + (p.IsSecpolDepended() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("is secpol enabled on this system?: " + (p.IsSecpolEnabled() ? "yes" : "no. therefor all policies being depended on secpol are disabled!"));
                Logger.getSubTreeLogger().LogTree("is manual action required for this policy?: " + (p.IsUserControlRequired() ? "yes" : "no"));
                Logger.getSubTreeLogger().LogTree("completed at: "+(int)ms+"ms ticks");
                Logger.getSubTreeLogger().LogTreeEnd("===[the policy has been initialized with success!]===");
            }
        }

        public OptionalWindow getOptionalWindow()
        {
            return optionalw;
        }

        private void callTempPolicyEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.TEMP_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void callwscriptEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.WSCRIPT_POLICY.GetPolicy(this);
            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void callUACEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.UAC_POLICY.GetPolicy(this);
            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void callNetbiosEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NETBIOS_POLICY.GetPolicy(this);
            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void callRenameEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.RENAME_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void callRemoteRegEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.REMOTE_REGISTRY_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void callRDPEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.RDP_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void callNTLMEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NTLM_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {

                DialogResult dialog = MessageBox.Show("if you are a bussiness and the users are connected to the domain controller this option will break your settings, this option only suits home users if you want to continue this click yes", "Warning: do not use this on clients connected to domain controllers!", MessageBoxButtons.YesNo);

                if(dialog == DialogResult.No)
                {
                    return;
                }

                p.Apply();
            }
        }

        private void callMBREvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.MBR_POLICY.GetPolicy(this);

            DialogResult result = MessageBox.Show("If you plan to use this feature please note that we have not developed MBRFilter\n\nMBRFilter is licensed under the GPLv2 License and maintained by Yves Younan, Cisco Talos at https://github.com/vrtadmin/MBRFilter\n\nby clicking \"yes\" you agree with their license", "Warning Third party driver", MessageBoxButtons.YesNo);

            if(result == DialogResult.No)
            {
                return;
            }

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void callMBRfilterlabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process proc = Process.Start("https://github.com/vrtadmin/MBRFilter");
            proc.Dispose();
        }

        private void callSafeApplyEvent(object sender, EventArgs e)
        {
            safeapplybtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.Values())
            {
                if(pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.GetPolicy(this);
                    p.GetButton().Enabled = false;
                }
            }

            foreach (SecurityPolicyType pt in SecurityPolicyType.Values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.GetPolicy(this);
                    if(p.IsSafeForBussiness())
                    {
                        if(!p.IsEnabled() && !p.IsUserControlRequired())
                        {
                            p.Apply();
                        }
                    }
                }
            }

            foreach (SecurityPolicyType pt in SecurityPolicyType.Values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.GetPolicy(this);
                    p.GetButton().Enabled = true;
                }
            }
            safeapplybtn.Enabled = true;
            MessageBox.Show("All \"safe\" policies have been applied!", "Policies with success applied!");
        }

        private void callApplyEvent(object sender, EventArgs e)
        {
            applyforcebtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.Values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY)
                {
                    SecurityPolicy p = pt.GetPolicy(this);

                    if (!p.IsUserControlRequired() && !p.IsEnabled())
                    {
                        if(p.IsSecpolDepended() && !p.IsSecpolEnabled())
                        {
                            continue;
                        }
                        p.Apply();
                    }
                }
            }
            applyforcebtn.Enabled = true;
            MessageBox.Show("All policies have been applied!, those who are not require user control.", "Policies with success applied!");
    }

        private void callUndoEvent(object sender, EventArgs e)
        {
            undobtn.Enabled = false;
            foreach (SecurityPolicyType pt in SecurityPolicyType.Values())
            {
                if (pt != SecurityPolicyType.UPDATE_POLICY && !pt.GetPolicy(this).IsUserControlRequired())
                {
                    SecurityPolicy p = pt.GetPolicy(this);
                    if (!p.IsUserControlRequired() && p.IsEnabled())
                    {
                        if (p.IsSecpolDepended() && !p.IsSecpolEnabled())
                        {
                            continue;
                        }
                        p.Unapply();
                    }
                }
            }
            undobtn.Enabled = true;
        }

        private void callInsecureServicesEvent(object sender, EventArgs e) 
        {
            SecurityPolicy p = SecurityPolicyType.IN_SECURE_SERVICES_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void callBogusCertEvent(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.CERT_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void boguscertlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process a = Process.Start("https://technet.microsoft.com/en-us/sysinternals/");
            a.Dispose();
        }

        private void window_Load(object sender, EventArgs e){}

        private void netsharebtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.NETSHARE_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void openOptionalOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionalw.Visible = true;
            openOptionalOptionsToolStripMenuItem.Enabled = false;
        }

        private void llmnrbtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.LLMNR_POLICY.GetPolicy(this);
            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void resetPoliciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Config.GetConfig().GetDataFolder()+@"\config.txt"))
            {
                File.Delete(Config.GetConfig().GetDataFolder()+@"\config.txt");
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

            SecurityPolicy p = SecurityPolicyType.UPDATE_POLICY.GetPolicy(this);
            p.Apply();

            MessageBox.Show("WSTT needs to be restarted ;-)");

            Application.Exit();

        }

        private void unsignedbtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.UNSIGNED_POLICY.GetPolicy(this);
            p.Apply();
        }

        private void smbbtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.SMB_SHARING_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
        }

        private void autoplaybtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.AUTOPLAY_POLICY.GetPolicy(this);

            if (p.IsEnabled())
            {
                p.Unapply();
            }
            else
            {
                p.Apply();
            }
        }

        private void regsvr32btn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.REGSERVR32_PROXY_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void powershellbtn_Click(object sender, EventArgs e)
        {
            SecurityPolicy p = SecurityPolicyType.POWERSHELL_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }
    }
}
