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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.ninite;
using windows_security_tweak_tool.src.optionalpolicies;

namespace windows_security_tweak_tool.src
{
    public class OptionalWindow : Form
    {

        public OptionalWindow()
        {
            InitializeComponent();
            //initialize event since visual studio keeps reseting this...
            this.FormClosing += onCloseOptionalWindow;

            foreach (OptionalPolicyType t in OptionalPolicyType.Values())
            {
                OptionalPolicy p = t.GetPolicy(this);

                if (p.IsEnabled())
                {
                    p.GetProgressbar().Value = 100;
                    p.GetButton().Text = "undo";
                    toolTip1.SetToolTip(p.GetButton(), p.GetDescription());
                    toolTip1.SetToolTip(p.GetProgressbar(), p.GetDescription());
                } else
                {
                    if (p.IsCertificateDepended())
                    {
                        if (p.GetCertificate().isExpired())
                        {
                            p.GetButton().Text = "Disabled, expired certificate please update WSTT!";
                            p.GetButton().Enabled = false;
                        }
                    }
                }
            }
        }

        private Label chromeaddonlabel;
        public Button chromeaddonbtn;
        public ProgressBar chromeaddonprogress;
        private Label chromelabel;
        public Button chromebtn;
        public ProgressBar chromeprogress;
        private Label keepasslabel;
        public Button keepassbtn;
        public ProgressBar keepassprogress;
        private Label optionaloptionslabel;
        private Panel panel1;
        private LinkLabel ninitelabel;
        public Button niniteselectallbtn;
        public Button niniteinstallbtn;
        public CheckBox niniteputtycheckbox;
        public CheckBox winscpcheckbox;
        public CheckBox ninitenotepadcheckbox;
        public CheckBox ninitefilezillacheckbox;
        public CheckBox ninitewinrarcheckbox;
        public CheckBox ninite7zipcheckbox;
        public CheckBox niniteclassiccheckbox;
        public CheckBox niniteimgburncheckbox;
        public CheckBox ninitegoogledrivecheckbox;
        public CheckBox ninitedropboxcheckbox;
        public CheckBox ninitembamcheckbox;
        public CheckBox niniteessentialscheckbox;
        public CheckBox ninitespotifycheckbox;
        public CheckBox ninitevlcplayercheckbox;
        public CheckBox niniteitunescheckbox;
        public CheckBox ninitethunderbirdcheckbox;
        private Button button1;
        private Button button2;
        private Label label2;
        public Button button3;
        public ProgressBar progressBar1;
        private Label label1;
        public Button HPCheckbtn;
        public ProgressBar HPCheckProgress;
        private ToolTip toolTip1;
        private IContainer components;
        public CheckBox niniteskypecheckbox;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionalWindow));
            this.chromeaddonlabel = new System.Windows.Forms.Label();
            this.chromeaddonbtn = new System.Windows.Forms.Button();
            this.chromeaddonprogress = new System.Windows.Forms.ProgressBar();
            this.chromelabel = new System.Windows.Forms.Label();
            this.chromebtn = new System.Windows.Forms.Button();
            this.chromeprogress = new System.Windows.Forms.ProgressBar();
            this.keepasslabel = new System.Windows.Forms.Label();
            this.keepassbtn = new System.Windows.Forms.Button();
            this.keepassprogress = new System.Windows.Forms.ProgressBar();
            this.optionaloptionslabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ninitelabel = new System.Windows.Forms.LinkLabel();
            this.niniteselectallbtn = new System.Windows.Forms.Button();
            this.niniteinstallbtn = new System.Windows.Forms.Button();
            this.niniteputtycheckbox = new System.Windows.Forms.CheckBox();
            this.winscpcheckbox = new System.Windows.Forms.CheckBox();
            this.ninitenotepadcheckbox = new System.Windows.Forms.CheckBox();
            this.ninitefilezillacheckbox = new System.Windows.Forms.CheckBox();
            this.ninitewinrarcheckbox = new System.Windows.Forms.CheckBox();
            this.ninite7zipcheckbox = new System.Windows.Forms.CheckBox();
            this.niniteclassiccheckbox = new System.Windows.Forms.CheckBox();
            this.niniteimgburncheckbox = new System.Windows.Forms.CheckBox();
            this.ninitegoogledrivecheckbox = new System.Windows.Forms.CheckBox();
            this.ninitedropboxcheckbox = new System.Windows.Forms.CheckBox();
            this.ninitembamcheckbox = new System.Windows.Forms.CheckBox();
            this.niniteessentialscheckbox = new System.Windows.Forms.CheckBox();
            this.ninitespotifycheckbox = new System.Windows.Forms.CheckBox();
            this.ninitevlcplayercheckbox = new System.Windows.Forms.CheckBox();
            this.niniteitunescheckbox = new System.Windows.Forms.CheckBox();
            this.ninitethunderbirdcheckbox = new System.Windows.Forms.CheckBox();
            this.niniteskypecheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.HPCheckbtn = new System.Windows.Forms.Button();
            this.HPCheckProgress = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromeaddonlabel
            // 
            this.chromeaddonlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonlabel.AutoSize = true;
            this.chromeaddonlabel.Location = new System.Drawing.Point(11, 274);
            this.chromeaddonlabel.Name = "chromeaddonlabel";
            this.chromeaddonlabel.Size = new System.Drawing.Size(164, 13);
            this.chromeaddonlabel.TabIndex = 89;
            this.chromeaddonlabel.Text = "Install safety addons into chrome:";
            // 
            // chromeaddonbtn
            // 
            this.chromeaddonbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonbtn.AutoSize = true;
            this.chromeaddonbtn.Location = new System.Drawing.Point(401, 290);
            this.chromeaddonbtn.Name = "chromeaddonbtn";
            this.chromeaddonbtn.Size = new System.Drawing.Size(94, 23);
            this.chromeaddonbtn.TabIndex = 88;
            this.chromeaddonbtn.Text = "run";
            this.chromeaddonbtn.UseVisualStyleBackColor = true;
            this.chromeaddonbtn.Click += new System.EventHandler(this.chromeaddonbtn_Click);
            // 
            // chromeaddonprogress
            // 
            this.chromeaddonprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonprogress.Enabled = false;
            this.chromeaddonprogress.Location = new System.Drawing.Point(11, 290);
            this.chromeaddonprogress.Name = "chromeaddonprogress";
            this.chromeaddonprogress.Size = new System.Drawing.Size(406, 23);
            this.chromeaddonprogress.TabIndex = 87;
            // 
            // chromelabel
            // 
            this.chromelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromelabel.AutoSize = true;
            this.chromelabel.Location = new System.Drawing.Point(11, 232);
            this.chromelabel.Name = "chromelabel";
            this.chromelabel.Size = new System.Drawing.Size(369, 13);
            this.chromelabel.TabIndex = 86;
            this.chromelabel.Text = "Google Chrome 64 bit (Work/Bussiness Edition) with extra hardened security:";
            // 
            // chromebtn
            // 
            this.chromebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chromebtn.AutoSize = true;
            this.chromebtn.Location = new System.Drawing.Point(401, 248);
            this.chromebtn.Name = "chromebtn";
            this.chromebtn.Size = new System.Drawing.Size(94, 23);
            this.chromebtn.TabIndex = 85;
            this.chromebtn.Text = "apply";
            this.chromebtn.UseVisualStyleBackColor = true;
            this.chromebtn.Click += new System.EventHandler(this.chromebtn_Click);
            // 
            // chromeprogress
            // 
            this.chromeprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeprogress.Location = new System.Drawing.Point(11, 248);
            this.chromeprogress.Name = "chromeprogress";
            this.chromeprogress.Size = new System.Drawing.Size(406, 23);
            this.chromeprogress.TabIndex = 84;
            // 
            // keepasslabel
            // 
            this.keepasslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keepasslabel.AutoSize = true;
            this.keepasslabel.Location = new System.Drawing.Point(11, 190);
            this.keepasslabel.Name = "keepasslabel";
            this.keepasslabel.Size = new System.Drawing.Size(158, 13);
            this.keepasslabel.TabIndex = 83;
            this.keepasslabel.Text = "Install Keepass as Administrator:";
            // 
            // keepassbtn
            // 
            this.keepassbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keepassbtn.AutoSize = true;
            this.keepassbtn.Location = new System.Drawing.Point(401, 206);
            this.keepassbtn.Name = "keepassbtn";
            this.keepassbtn.Size = new System.Drawing.Size(94, 23);
            this.keepassbtn.TabIndex = 82;
            this.keepassbtn.Text = "apply";
            this.keepassbtn.UseVisualStyleBackColor = true;
            this.keepassbtn.Click += new System.EventHandler(this.keepassbtn_Click);
            // 
            // keepassprogress
            // 
            this.keepassprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keepassprogress.Location = new System.Drawing.Point(11, 206);
            this.keepassprogress.Name = "keepassprogress";
            this.keepassprogress.Size = new System.Drawing.Size(406, 23);
            this.keepassprogress.TabIndex = 81;
            // 
            // optionaloptionslabel
            // 
            this.optionaloptionslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionaloptionslabel.AutoSize = true;
            this.optionaloptionslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionaloptionslabel.Location = new System.Drawing.Point(12, 9);
            this.optionaloptionslabel.Name = "optionaloptionslabel";
            this.optionaloptionslabel.Size = new System.Drawing.Size(101, 13);
            this.optionaloptionslabel.TabIndex = 80;
            this.optionaloptionslabel.Text = "optional options:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ninitelabel);
            this.panel1.Controls.Add(this.niniteselectallbtn);
            this.panel1.Controls.Add(this.niniteinstallbtn);
            this.panel1.Controls.Add(this.niniteputtycheckbox);
            this.panel1.Controls.Add(this.winscpcheckbox);
            this.panel1.Controls.Add(this.ninitenotepadcheckbox);
            this.panel1.Controls.Add(this.ninitefilezillacheckbox);
            this.panel1.Controls.Add(this.ninitewinrarcheckbox);
            this.panel1.Controls.Add(this.ninite7zipcheckbox);
            this.panel1.Controls.Add(this.niniteclassiccheckbox);
            this.panel1.Controls.Add(this.niniteimgburncheckbox);
            this.panel1.Controls.Add(this.ninitegoogledrivecheckbox);
            this.panel1.Controls.Add(this.ninitedropboxcheckbox);
            this.panel1.Controls.Add(this.ninitembamcheckbox);
            this.panel1.Controls.Add(this.niniteessentialscheckbox);
            this.panel1.Controls.Add(this.ninitespotifycheckbox);
            this.panel1.Controls.Add(this.ninitevlcplayercheckbox);
            this.panel1.Controls.Add(this.niniteitunescheckbox);
            this.panel1.Controls.Add(this.ninitethunderbirdcheckbox);
            this.panel1.Controls.Add(this.niniteskypecheckbox);
            this.panel1.Location = new System.Drawing.Point(11, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 163);
            this.panel1.TabIndex = 79;
            // 
            // ninitelabel
            // 
            this.ninitelabel.AutoSize = true;
            this.ninitelabel.Location = new System.Drawing.Point(1, -1);
            this.ninitelabel.Name = "ninitelabel";
            this.ninitelabel.Size = new System.Drawing.Size(306, 13);
            this.ninitelabel.TabIndex = 79;
            this.ninitelabel.TabStop = true;
            this.ninitelabel.Text = "ninite installer (for more programs visit https://www.ninite.com/):";
            // 
            // niniteselectallbtn
            // 
            this.niniteselectallbtn.AutoSize = true;
            this.niniteselectallbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.niniteselectallbtn.Location = new System.Drawing.Point(0, 117);
            this.niniteselectallbtn.Name = "niniteselectallbtn";
            this.niniteselectallbtn.Size = new System.Drawing.Size(484, 23);
            this.niniteselectallbtn.TabIndex = 20;
            this.niniteselectallbtn.Text = "Deselect all";
            this.niniteselectallbtn.UseVisualStyleBackColor = true;
            this.niniteselectallbtn.Click += new System.EventHandler(this.niniteselectallbtn_Click);
            // 
            // niniteinstallbtn
            // 
            this.niniteinstallbtn.AutoSize = true;
            this.niniteinstallbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.niniteinstallbtn.Location = new System.Drawing.Point(0, 140);
            this.niniteinstallbtn.Name = "niniteinstallbtn";
            this.niniteinstallbtn.Size = new System.Drawing.Size(484, 23);
            this.niniteinstallbtn.TabIndex = 19;
            this.niniteinstallbtn.Text = "Install programs with Ninite!";
            this.niniteinstallbtn.UseVisualStyleBackColor = true;
            this.niniteinstallbtn.Click += new System.EventHandler(this.niniteinstallbtn_Click);
            // 
            // niniteputtycheckbox
            // 
            this.niniteputtycheckbox.AutoSize = true;
            this.niniteputtycheckbox.Checked = true;
            this.niniteputtycheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.niniteputtycheckbox.Location = new System.Drawing.Point(95, 91);
            this.niniteputtycheckbox.Name = "niniteputtycheckbox";
            this.niniteputtycheckbox.Size = new System.Drawing.Size(50, 17);
            this.niniteputtycheckbox.TabIndex = 18;
            this.niniteputtycheckbox.Text = "Putty";
            this.niniteputtycheckbox.UseVisualStyleBackColor = true;
            // 
            // winscpcheckbox
            // 
            this.winscpcheckbox.AutoSize = true;
            this.winscpcheckbox.Location = new System.Drawing.Point(2, 91);
            this.winscpcheckbox.Name = "winscpcheckbox";
            this.winscpcheckbox.Size = new System.Drawing.Size(66, 17);
            this.winscpcheckbox.TabIndex = 17;
            this.winscpcheckbox.Text = "WinSCP";
            this.winscpcheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitenotepadcheckbox
            // 
            this.ninitenotepadcheckbox.AutoSize = true;
            this.ninitenotepadcheckbox.Checked = true;
            this.ninitenotepadcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ninitenotepadcheckbox.Location = new System.Drawing.Point(389, 68);
            this.ninitenotepadcheckbox.Name = "ninitenotepadcheckbox";
            this.ninitenotepadcheckbox.Size = new System.Drawing.Size(79, 17);
            this.ninitenotepadcheckbox.TabIndex = 16;
            this.ninitenotepadcheckbox.Text = "Notepad++";
            this.ninitenotepadcheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitefilezillacheckbox
            // 
            this.ninitefilezillacheckbox.AutoSize = true;
            this.ninitefilezillacheckbox.Checked = true;
            this.ninitefilezillacheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ninitefilezillacheckbox.Location = new System.Drawing.Point(303, 68);
            this.ninitefilezillacheckbox.Name = "ninitefilezillacheckbox";
            this.ninitefilezillacheckbox.Size = new System.Drawing.Size(61, 17);
            this.ninitefilezillacheckbox.TabIndex = 15;
            this.ninitefilezillacheckbox.Text = "FileZilla";
            this.ninitefilezillacheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitewinrarcheckbox
            // 
            this.ninitewinrarcheckbox.AutoSize = true;
            this.ninitewinrarcheckbox.Checked = true;
            this.ninitewinrarcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ninitewinrarcheckbox.Location = new System.Drawing.Point(214, 68);
            this.ninitewinrarcheckbox.Name = "ninitewinrarcheckbox";
            this.ninitewinrarcheckbox.Size = new System.Drawing.Size(68, 17);
            this.ninitewinrarcheckbox.TabIndex = 14;
            this.ninitewinrarcheckbox.Text = "WinRAR";
            this.ninitewinrarcheckbox.UseVisualStyleBackColor = true;
            // 
            // ninite7zipcheckbox
            // 
            this.ninite7zipcheckbox.AutoSize = true;
            this.ninite7zipcheckbox.Location = new System.Drawing.Point(95, 68);
            this.ninite7zipcheckbox.Name = "ninite7zipcheckbox";
            this.ninite7zipcheckbox.Size = new System.Drawing.Size(48, 17);
            this.ninite7zipcheckbox.TabIndex = 13;
            this.ninite7zipcheckbox.Text = "7-zip";
            this.ninite7zipcheckbox.UseVisualStyleBackColor = true;
            // 
            // niniteclassiccheckbox
            // 
            this.niniteclassiccheckbox.AutoSize = true;
            this.niniteclassiccheckbox.Checked = true;
            this.niniteclassiccheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.niniteclassiccheckbox.Location = new System.Drawing.Point(3, 68);
            this.niniteclassiccheckbox.Name = "niniteclassiccheckbox";
            this.niniteclassiccheckbox.Size = new System.Drawing.Size(84, 17);
            this.niniteclassiccheckbox.TabIndex = 12;
            this.niniteclassiccheckbox.Text = "Classic Start";
            this.niniteclassiccheckbox.UseVisualStyleBackColor = true;
            // 
            // niniteimgburncheckbox
            // 
            this.niniteimgburncheckbox.AutoSize = true;
            this.niniteimgburncheckbox.Checked = true;
            this.niniteimgburncheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.niniteimgburncheckbox.Location = new System.Drawing.Point(389, 45);
            this.niniteimgburncheckbox.Name = "niniteimgburncheckbox";
            this.niniteimgburncheckbox.Size = new System.Drawing.Size(65, 17);
            this.niniteimgburncheckbox.TabIndex = 11;
            this.niniteimgburncheckbox.Text = "ImgBurn";
            this.niniteimgburncheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitegoogledrivecheckbox
            // 
            this.ninitegoogledrivecheckbox.AutoSize = true;
            this.ninitegoogledrivecheckbox.Location = new System.Drawing.Point(303, 45);
            this.ninitegoogledrivecheckbox.Name = "ninitegoogledrivecheckbox";
            this.ninitegoogledrivecheckbox.Size = new System.Drawing.Size(88, 17);
            this.ninitegoogledrivecheckbox.TabIndex = 9;
            this.ninitegoogledrivecheckbox.Text = "Google Drive";
            this.ninitegoogledrivecheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitedropboxcheckbox
            // 
            this.ninitedropboxcheckbox.AutoSize = true;
            this.ninitedropboxcheckbox.Location = new System.Drawing.Point(214, 45);
            this.ninitedropboxcheckbox.Name = "ninitedropboxcheckbox";
            this.ninitedropboxcheckbox.Size = new System.Drawing.Size(66, 17);
            this.ninitedropboxcheckbox.TabIndex = 8;
            this.ninitedropboxcheckbox.Text = "Dropbox";
            this.ninitedropboxcheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitembamcheckbox
            // 
            this.ninitembamcheckbox.AutoSize = true;
            this.ninitembamcheckbox.Location = new System.Drawing.Point(95, 45);
            this.ninitembamcheckbox.Name = "ninitembamcheckbox";
            this.ninitembamcheckbox.Size = new System.Drawing.Size(91, 17);
            this.ninitembamcheckbox.TabIndex = 7;
            this.ninitembamcheckbox.Text = "Malwarebytes";
            this.ninitembamcheckbox.UseVisualStyleBackColor = true;
            // 
            // niniteessentialscheckbox
            // 
            this.niniteessentialscheckbox.AutoSize = true;
            this.niniteessentialscheckbox.Location = new System.Drawing.Point(3, 45);
            this.niniteessentialscheckbox.Name = "niniteessentialscheckbox";
            this.niniteessentialscheckbox.Size = new System.Drawing.Size(73, 17);
            this.niniteessentialscheckbox.TabIndex = 6;
            this.niniteessentialscheckbox.Text = "Essentials";
            this.niniteessentialscheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitespotifycheckbox
            // 
            this.ninitespotifycheckbox.AutoSize = true;
            this.ninitespotifycheckbox.Checked = true;
            this.ninitespotifycheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ninitespotifycheckbox.Location = new System.Drawing.Point(389, 22);
            this.ninitespotifycheckbox.Name = "ninitespotifycheckbox";
            this.ninitespotifycheckbox.Size = new System.Drawing.Size(58, 17);
            this.ninitespotifycheckbox.TabIndex = 5;
            this.ninitespotifycheckbox.Text = "Spotify";
            this.ninitespotifycheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitevlcplayercheckbox
            // 
            this.ninitevlcplayercheckbox.AutoSize = true;
            this.ninitevlcplayercheckbox.Location = new System.Drawing.Point(305, 22);
            this.ninitevlcplayercheckbox.Name = "ninitevlcplayercheckbox";
            this.ninitevlcplayercheckbox.Size = new System.Drawing.Size(78, 17);
            this.ninitevlcplayercheckbox.TabIndex = 4;
            this.ninitevlcplayercheckbox.Text = "VLC Player";
            this.ninitevlcplayercheckbox.UseVisualStyleBackColor = true;
            // 
            // niniteitunescheckbox
            // 
            this.niniteitunescheckbox.AutoSize = true;
            this.niniteitunescheckbox.Checked = true;
            this.niniteitunescheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.niniteitunescheckbox.Location = new System.Drawing.Point(214, 22);
            this.niniteitunescheckbox.Name = "niniteitunescheckbox";
            this.niniteitunescheckbox.Size = new System.Drawing.Size(55, 17);
            this.niniteitunescheckbox.TabIndex = 3;
            this.niniteitunescheckbox.Text = "Itunes";
            this.niniteitunescheckbox.UseVisualStyleBackColor = true;
            // 
            // ninitethunderbirdcheckbox
            // 
            this.ninitethunderbirdcheckbox.AutoSize = true;
            this.ninitethunderbirdcheckbox.Checked = true;
            this.ninitethunderbirdcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ninitethunderbirdcheckbox.Location = new System.Drawing.Point(95, 22);
            this.ninitethunderbirdcheckbox.Name = "ninitethunderbirdcheckbox";
            this.ninitethunderbirdcheckbox.Size = new System.Drawing.Size(83, 17);
            this.ninitethunderbirdcheckbox.TabIndex = 2;
            this.ninitethunderbirdcheckbox.Text = "Thunderbird";
            this.ninitethunderbirdcheckbox.UseVisualStyleBackColor = true;
            // 
            // niniteskypecheckbox
            // 
            this.niniteskypecheckbox.AutoSize = true;
            this.niniteskypecheckbox.Checked = true;
            this.niniteskypecheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.niniteskypecheckbox.Location = new System.Drawing.Point(3, 22);
            this.niniteskypecheckbox.Name = "niniteskypecheckbox";
            this.niniteskypecheckbox.Size = new System.Drawing.Size(56, 17);
            this.niniteskypecheckbox.TabIndex = 1;
            this.niniteskypecheckbox.Text = "Skype";
            this.niniteskypecheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(13, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Apply all";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(94, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 91;
            this.button2.Text = "Unapply all";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "add policies to google chrome:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(401, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 97;
            this.button3.Text = "not implemented";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(11, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 23);
            this.progressBar1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "remove HP keylogger (audio driver) (MicTray.exe)";
            // 
            // HPCheckbtn
            // 
            this.HPCheckbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HPCheckbtn.AutoSize = true;
            this.HPCheckbtn.Location = new System.Drawing.Point(401, 374);
            this.HPCheckbtn.Name = "HPCheckbtn";
            this.HPCheckbtn.Size = new System.Drawing.Size(94, 23);
            this.HPCheckbtn.TabIndex = 100;
            this.HPCheckbtn.Text = "check";
            this.HPCheckbtn.UseVisualStyleBackColor = true;
            this.HPCheckbtn.Click += new System.EventHandler(this.HPCheckbtn_Click);
            // 
            // HPCheckProgress
            // 
            this.HPCheckProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPCheckProgress.Location = new System.Drawing.Point(11, 374);
            this.HPCheckProgress.Name = "HPCheckProgress";
            this.HPCheckProgress.Size = new System.Drawing.Size(406, 23);
            this.HPCheckProgress.TabIndex = 99;
            // 
            // OptionalWindow
            // 
            this.ClientSize = new System.Drawing.Size(510, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HPCheckbtn);
            this.Controls.Add(this.HPCheckProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chromeaddonlabel);
            this.Controls.Add(this.chromeaddonbtn);
            this.Controls.Add(this.chromeaddonprogress);
            this.Controls.Add(this.chromelabel);
            this.Controls.Add(this.chromebtn);
            this.Controls.Add(this.chromeprogress);
            this.Controls.Add(this.keepasslabel);
            this.Controls.Add(this.keepassbtn);
            this.Controls.Add(this.keepassprogress);
            this.Controls.Add(this.optionaloptionslabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(526, 485);
            this.Name = "OptionalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optional options:";
            this.Load += new System.EventHandler(this.OptionalWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void onCloseOptionalWindow(object sender, CancelEventArgs e)
        {
            this.Visible = false;
            Program.getGui().openOptionalOptionsToolStripMenuItem.Enabled = true;
            e.Cancel = true;
        }

        private void niniteselectallbtn_Click(object sender, EventArgs e)
        {
            if (niniteselectallbtn.Text == "Select all")
            {
                foreach (NiniteOption option in NiniteOption.Values())
                {
                    option.GetCheckbox().Checked = true;
                }
                niniteselectallbtn.Text = "Deselect";
            }
            else
            {
                foreach (NiniteOption option in NiniteOption.Values())
                {
                    option.GetCheckbox().Checked = false;
                }
                niniteselectallbtn.Text = "Select all";
            }
        }

        private void niniteinstallbtn_Click(object sender, EventArgs e)
        {
            NinitePolicy policy = new NinitePolicy();
            policy.SetGui(this);
            policy.Apply();

            /*
            NiniteCreator creator = new NiniteCreator();
            foreach (NiniteOption option in NiniteOption.values())
            {
                if (option.isEnabled())
                {
                    creator.Add(option);
                }
            }
            creator.downloadNiniteInstaller(creator.getNiniteURL());
    */
            
    }

        private void keepassbtn_Click(object sender, EventArgs e)
        {
            OptionalPolicy p = OptionalPolicyType.KEEPASS_ADMIN_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void chromebtn_Click(object sender, EventArgs e)
        {
            OptionalPolicy p = OptionalPolicyType.CHROME_64BIT_POLICY.GetPolicy(this);

            if(p.IsEnabled())
            {
                p.Unapply();
            } else
            {
                p.Apply();
            }
        }

        private void HPCheckbtn_Click(object sender, EventArgs e)
        {
            OptionalPolicy p = OptionalPolicyType.HP_KEYLOGGER_POLICY.GetPolicy(this);

            p.Apply();

        }

        private void OptionalWindow_Load(object sender, EventArgs e)
        {
        }

        private void chromeaddonbtn_Click(object sender, EventArgs e)
        {
            OptionalPolicy p = OptionalPolicyType.CHROME_ADDON_POLICY.GetPolicy(this);
            p.Apply();
        }
    }
}
