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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_tweak_tool;
using windows_tweak_tool.src;
using windows_tweak_tool.src.ninite;
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

            foreach (PolicyType a in PolicyType.values().getAll())
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
                }
            }
        }

        private void callTempPolicyEvent(object sender, EventArgs e)
        {
            Policy p = PolicyType.TEMP_POLICY.getPolicy(this);

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
            Policy p = PolicyType.WSCRIPT_POLICY.getPolicy(this);
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
            Policy p = PolicyType.UAC_POLICY.getPolicy(this);
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
            Policy p = PolicyType.NETBIOS_POLICY.getPolicy(this);
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
            Policy p = PolicyType.RENAME_POLICY.getPolicy(this);

            if(p.isEnabled())
            {
                p.unapply();
            } else
            {
                p.apply();
            }
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

        private void callRemoteRegEvent(object sender, EventArgs e)
        {
            Policy p = PolicyType.REMOTE_REGISTRY_POLICY.getPolicy(this);

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
            Policy p = PolicyType.RDP_POLICY.getPolicy(this);

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
            Policy p = PolicyType.NTLM_POLICY.getPolicy(this);

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
            Policy p = null;

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
            Process.Start("https://github.com/vrtadmin/MBRFilter");
        }

        private void callSafeApplyEvent(object sender, EventArgs e)
        {
            safeapplybtn.Enabled = false;
            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if(pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = false;
                }
            }

            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    if(p.isSafeForBussiness())
                    {
                        if(!p.isEnabled() && !p.isUserControlRequired())
                        {
                            p.apply();
                        }
                    }
                }
            }

            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = true;
                }
            }
            safeapplybtn.Enabled = true;
            MessageBox.Show("All \"safe\" policies have been applied!", "Policies with success applied!");
        }

        private void callApplyEvent(object sender, EventArgs e)
        {
            applyforcebtn.Enabled = false;
            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = false;
                }
            }

            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                        if (!p.isEnabled() && !p.isUserControlRequired())
                        {
                            p.apply();
                        }
                }
            }

            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = true;
                }
            }
            applyforcebtn.Enabled = true;
            MessageBox.Show("All policies have been applied!, those who are not require user control.", "Policies with success applied!");
    }

        private void callUndoEvent(object sender, EventArgs e)
        {
            undobtn.Enabled = false;
            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = false;
                }
            }


            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    if (p.isEnabled() && !p.isUserControlRequired())
                    {
                        p.unapply();
                    }
                }
            }

            foreach (PolicyType pt in PolicyType.values().getAll())
            {
                if (pt != PolicyType.UPDATE_POLICY)
                {
                    Policy p = pt.getPolicy(this);
                    p.getButton().Enabled = false;
                }
            }

            undobtn.Enabled = false;
        }

        private void callInsecureServicesEvent(object sender, EventArgs e)
        {

        }

        private void callBogusCertEvent(object sender, EventArgs e)
        {
            Policy p = PolicyType.CERT_POLICY.getPolicy(this);

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

        private void niniteselectallbtn_Click(object sender, EventArgs e)
        {
            if(niniteselectallbtn.Text == "Select all")
            {
                foreach (NiniteOption option in NiniteOption.values())
                {
                    option.getCheckbox().Checked = true;
                }
                niniteselectallbtn.Text = "Undo";
            } else
            {
                foreach (NiniteOption option in NiniteOption.values())
                {
                    option.getCheckbox().Checked = false;
                }
                niniteselectallbtn.Text = "Select all";
            }
        }

        private void niniteinstallbtn_Click(object sender, EventArgs e)
        {
            NiniteCreator creator = new NiniteCreator();
            foreach (NiniteOption option in NiniteOption.values())
            {
                if(option.isEnabled())
                {
                    creator.Add(option);
                }
            }
            creator.downloadNiniteInstaller(creator.getNiniteURL());
        }

        private void niniteputtycheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void winscpcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitenotepadcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitefilezillacheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitewinrarcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninite7zipcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void niniteclassiccheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void niniteimgburncheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitegoogledrivecheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitedropboxcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitembamcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void niniteessentialscheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitespotifycheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitevlcplayercheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void niniteitunescheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ninitethunderbirdcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void niniteskypecheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
