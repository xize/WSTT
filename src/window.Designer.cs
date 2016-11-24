using System;
using System.Windows.Forms;
using windows_tweak_tool.src.policies;

namespace windows_tweak_tool
{
    partial class window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.temp_policy_load = new System.Windows.Forms.ProgressBar();
            this.temp_policy_btn = new System.Windows.Forms.Button();
            this.wscript_btn = new System.Windows.Forms.Button();
            this.wscript_progress = new System.Windows.Forms.ProgressBar();
            this.tempolicylabel = new System.Windows.Forms.Label();
            this.netbioslabel = new System.Windows.Forms.Label();
            this.netbiosbtn = new System.Windows.Forms.Button();
            this.netbiosprogress = new System.Windows.Forms.ProgressBar();
            this.wscriptlabel = new System.Windows.Forms.Label();
            this.renamelabel = new System.Windows.Forms.Label();
            this.renamebtn = new System.Windows.Forms.Button();
            this.renameprogress = new System.Windows.Forms.ProgressBar();
            this.uaclabel = new System.Windows.Forms.Label();
            this.uac_btn = new System.Windows.Forms.Button();
            this.uac_progress = new System.Windows.Forms.ProgressBar();
            this.rdplabel = new System.Windows.Forms.Label();
            this.rdpbtn = new System.Windows.Forms.Button();
            this.rdpprogress = new System.Windows.Forms.ProgressBar();
            this.remoteregistrylabel = new System.Windows.Forms.Label();
            this.remoteregbtn = new System.Windows.Forms.Button();
            this.remoteregprogress = new System.Windows.Forms.ProgressBar();
            this.safeapplybtn = new System.Windows.Forms.Button();
            this.undobtn = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.applyforcebtn = new System.Windows.Forms.Button();
            this.ntlmlabel = new System.Windows.Forms.Label();
            this.NTLMbtn = new System.Windows.Forms.Button();
            this.NTLMProgress = new System.Windows.Forms.ProgressBar();
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
            this.optionaloptionslabel = new System.Windows.Forms.Label();
            this.keepasslabel = new System.Windows.Forms.Label();
            this.keepassbtn = new System.Windows.Forms.Button();
            this.keepassprogress = new System.Windows.Forms.ProgressBar();
            this.chromelabel = new System.Windows.Forms.Label();
            this.chromebtn = new System.Windows.Forms.Button();
            this.chromeprogress = new System.Windows.Forms.ProgressBar();
            this.chromeaddonlabel = new System.Windows.Forms.Label();
            this.chromeaddonbtn = new System.Windows.Forms.Button();
            this.chromeaddonprogress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.insecureserviceslabel = new System.Windows.Forms.Label();
            this.insecureservicesbtn = new System.Windows.Forms.Button();
            this.insecureserviceprogress = new System.Windows.Forms.ProgressBar();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.boguscertlabel = new System.Windows.Forms.LinkLabel();
            this.boguscertbtn = new System.Windows.Forms.Button();
            this.boguscertprogress = new System.Windows.Forms.ProgressBar();
            this.mbrfilterlabel = new System.Windows.Forms.LinkLabel();
            this.mbrbtn = new System.Windows.Forms.Button();
            this.mbrprogress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.netsharebtn = new System.Windows.Forms.Button();
            this.netshareprogress = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temp_policy_load
            // 
            this.temp_policy_load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_policy_load.Location = new System.Drawing.Point(12, 44);
            this.temp_policy_load.Name = "temp_policy_load";
            this.temp_policy_load.Size = new System.Drawing.Size(403, 23);
            this.temp_policy_load.TabIndex = 0;
            // 
            // temp_policy_btn
            // 
            this.temp_policy_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_policy_btn.AutoSize = true;
            this.temp_policy_btn.Location = new System.Drawing.Point(421, 44);
            this.temp_policy_btn.Name = "temp_policy_btn";
            this.temp_policy_btn.Size = new System.Drawing.Size(75, 23);
            this.temp_policy_btn.TabIndex = 1;
            this.temp_policy_btn.Text = "Apply";
            this.temp_policy_btn.UseVisualStyleBackColor = true;
            this.temp_policy_btn.Click += new System.EventHandler(this.callTempPolicyEvent);
            // 
            // wscript_btn
            // 
            this.wscript_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wscript_btn.AutoSize = true;
            this.wscript_btn.Location = new System.Drawing.Point(421, 126);
            this.wscript_btn.Name = "wscript_btn";
            this.wscript_btn.Size = new System.Drawing.Size(75, 23);
            this.wscript_btn.TabIndex = 7;
            this.wscript_btn.Text = "Apply";
            this.wscript_btn.UseVisualStyleBackColor = true;
            this.wscript_btn.Click += new System.EventHandler(this.callwscriptEvent);
            // 
            // wscript_progress
            // 
            this.wscript_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wscript_progress.Location = new System.Drawing.Point(12, 126);
            this.wscript_progress.Name = "wscript_progress";
            this.wscript_progress.Size = new System.Drawing.Size(403, 23);
            this.wscript_progress.TabIndex = 6;
            // 
            // tempolicylabel
            // 
            this.tempolicylabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempolicylabel.AutoSize = true;
            this.tempolicylabel.Location = new System.Drawing.Point(12, 28);
            this.tempolicylabel.Name = "tempolicylabel";
            this.tempolicylabel.Size = new System.Drawing.Size(371, 13);
            this.tempolicylabel.TabIndex = 2;
            this.tempolicylabel.Text = "protect known malware directories (policies, needs windows ultimate) (macro):";
            this.tempolicylabel.Click += new System.EventHandler(this.tempolicylabel_Click);
            // 
            // netbioslabel
            // 
            this.netbioslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netbioslabel.AutoSize = true;
            this.netbioslabel.Location = new System.Drawing.Point(12, 69);
            this.netbioslabel.Name = "netbioslabel";
            this.netbioslabel.Size = new System.Drawing.Size(277, 13);
            this.netbioslabel.TabIndex = 5;
            this.netbioslabel.Text = "disable netbios over ip to protect against network viruses:";
            // 
            // netbiosbtn
            // 
            this.netbiosbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.netbiosbtn.AutoSize = true;
            this.netbiosbtn.Location = new System.Drawing.Point(421, 85);
            this.netbiosbtn.Name = "netbiosbtn";
            this.netbiosbtn.Size = new System.Drawing.Size(75, 23);
            this.netbiosbtn.TabIndex = 4;
            this.netbiosbtn.Text = "Apply";
            this.netbiosbtn.UseVisualStyleBackColor = true;
            this.netbiosbtn.Click += new System.EventHandler(this.callNetbiosEvent);
            // 
            // netbiosprogress
            // 
            this.netbiosprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netbiosprogress.Location = new System.Drawing.Point(12, 85);
            this.netbiosprogress.Name = "netbiosprogress";
            this.netbiosprogress.Size = new System.Drawing.Size(403, 23);
            this.netbiosprogress.TabIndex = 3;
            // 
            // wscriptlabel
            // 
            this.wscriptlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wscriptlabel.AutoSize = true;
            this.wscriptlabel.Location = new System.Drawing.Point(12, 110);
            this.wscriptlabel.Name = "wscriptlabel";
            this.wscriptlabel.Size = new System.Drawing.Size(221, 13);
            this.wscriptlabel.TabIndex = 8;
            this.wscriptlabel.Text = "disable wscript so that vbs scripts cannot run:";
            // 
            // renamelabel
            // 
            this.renamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renamelabel.AutoSize = true;
            this.renamelabel.Location = new System.Drawing.Point(12, 151);
            this.renamelabel.Name = "renamelabel";
            this.renamelabel.Size = new System.Drawing.Size(366, 13);
            this.renamelabel.TabIndex = 11;
            this.renamelabel.Text = "change the default extension of scripts to notepad to fight browser payloads:";
            // 
            // renamebtn
            // 
            this.renamebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renamebtn.AutoSize = true;
            this.renamebtn.Location = new System.Drawing.Point(421, 167);
            this.renamebtn.Name = "renamebtn";
            this.renamebtn.Size = new System.Drawing.Size(75, 23);
            this.renamebtn.TabIndex = 10;
            this.renamebtn.Text = "Apply";
            this.renamebtn.UseVisualStyleBackColor = true;
            this.renamebtn.Click += new System.EventHandler(this.callRenameEvent);
            // 
            // renameprogress
            // 
            this.renameprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameprogress.Location = new System.Drawing.Point(12, 167);
            this.renameprogress.Name = "renameprogress";
            this.renameprogress.Size = new System.Drawing.Size(403, 23);
            this.renameprogress.TabIndex = 9;
            // 
            // uaclabel
            // 
            this.uaclabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uaclabel.AutoSize = true;
            this.uaclabel.Location = new System.Drawing.Point(9, 235);
            this.uaclabel.Name = "uaclabel";
            this.uaclabel.Size = new System.Drawing.Size(251, 13);
            this.uaclabel.TabIndex = 23;
            this.uaclabel.Text = "higher security from \"User account control\" (macro):";
            // 
            // uac_btn
            // 
            this.uac_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uac_btn.AutoSize = true;
            this.uac_btn.Location = new System.Drawing.Point(418, 251);
            this.uac_btn.Name = "uac_btn";
            this.uac_btn.Size = new System.Drawing.Size(75, 23);
            this.uac_btn.TabIndex = 22;
            this.uac_btn.Text = "Apply";
            this.uac_btn.UseVisualStyleBackColor = true;
            this.uac_btn.Click += new System.EventHandler(this.callUACEvent);
            // 
            // uac_progress
            // 
            this.uac_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uac_progress.Location = new System.Drawing.Point(9, 251);
            this.uac_progress.Name = "uac_progress";
            this.uac_progress.Size = new System.Drawing.Size(406, 23);
            this.uac_progress.TabIndex = 21;
            // 
            // rdplabel
            // 
            this.rdplabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdplabel.AutoSize = true;
            this.rdplabel.Location = new System.Drawing.Point(9, 277);
            this.rdplabel.Name = "rdplabel";
            this.rdplabel.Size = new System.Drawing.Size(160, 13);
            this.rdplabel.TabIndex = 29;
            this.rdplabel.Text = "disable remote desktop protocol:";
            // 
            // rdpbtn
            // 
            this.rdpbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdpbtn.AutoSize = true;
            this.rdpbtn.Location = new System.Drawing.Point(418, 293);
            this.rdpbtn.Name = "rdpbtn";
            this.rdpbtn.Size = new System.Drawing.Size(75, 23);
            this.rdpbtn.TabIndex = 28;
            this.rdpbtn.Text = "Apply";
            this.rdpbtn.UseVisualStyleBackColor = true;
            this.rdpbtn.Click += new System.EventHandler(this.callRDPEvent);
            // 
            // rdpprogress
            // 
            this.rdpprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdpprogress.Location = new System.Drawing.Point(9, 293);
            this.rdpprogress.Name = "rdpprogress";
            this.rdpprogress.Size = new System.Drawing.Size(406, 23);
            this.rdpprogress.TabIndex = 27;
            // 
            // remoteregistrylabel
            // 
            this.remoteregistrylabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteregistrylabel.AutoSize = true;
            this.remoteregistrylabel.Location = new System.Drawing.Point(9, 319);
            this.remoteregistrylabel.Name = "remoteregistrylabel";
            this.remoteregistrylabel.Size = new System.Drawing.Size(114, 13);
            this.remoteregistrylabel.TabIndex = 32;
            this.remoteregistrylabel.Text = "disable remote registry:";
            // 
            // remoteregbtn
            // 
            this.remoteregbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteregbtn.AutoSize = true;
            this.remoteregbtn.Location = new System.Drawing.Point(418, 335);
            this.remoteregbtn.Name = "remoteregbtn";
            this.remoteregbtn.Size = new System.Drawing.Size(75, 23);
            this.remoteregbtn.TabIndex = 31;
            this.remoteregbtn.Text = "Apply";
            this.remoteregbtn.UseVisualStyleBackColor = true;
            this.remoteregbtn.Click += new System.EventHandler(this.callRemoteRegEvent);
            // 
            // remoteregprogress
            // 
            this.remoteregprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteregprogress.Location = new System.Drawing.Point(9, 335);
            this.remoteregprogress.Name = "remoteregprogress";
            this.remoteregprogress.Size = new System.Drawing.Size(406, 23);
            this.remoteregprogress.TabIndex = 30;
            // 
            // safeapplybtn
            // 
            this.safeapplybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.safeapplybtn.Location = new System.Drawing.Point(9, 807);
            this.safeapplybtn.Name = "safeapplybtn";
            this.safeapplybtn.Size = new System.Drawing.Size(158, 23);
            this.safeapplybtn.TabIndex = 39;
            this.safeapplybtn.Text = "Apply All Safe Policies";
            this.tooltip.SetToolTip(this.safeapplybtn, "this will only apply the policies which can work perfectly fine in bussiness envi" +
        "ronments");
            this.safeapplybtn.UseVisualStyleBackColor = true;
            this.safeapplybtn.Click += new System.EventHandler(this.callSafeApplyEvent);
            // 
            // undobtn
            // 
            this.undobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.undobtn.Location = new System.Drawing.Point(417, 807);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(75, 23);
            this.undobtn.TabIndex = 40;
            this.undobtn.Text = "Undo all";
            this.tooltip.SetToolTip(this.undobtn, "This will undo all the policies being set active");
            this.undobtn.UseVisualStyleBackColor = true;
            this.undobtn.Click += new System.EventHandler(this.callUndoEvent);
            // 
            // applyforcebtn
            // 
            this.applyforcebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyforcebtn.Location = new System.Drawing.Point(173, 807);
            this.applyforcebtn.Name = "applyforcebtn";
            this.applyforcebtn.Size = new System.Drawing.Size(100, 23);
            this.applyforcebtn.TabIndex = 89;
            this.applyforcebtn.Text = "Apply All (Forced)";
            this.tooltip.SetToolTip(this.applyforcebtn, "this will apply everything");
            this.applyforcebtn.UseVisualStyleBackColor = true;
            this.applyforcebtn.Click += new System.EventHandler(this.callApplyEvent);
            // 
            // ntlmlabel
            // 
            this.ntlmlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntlmlabel.AutoSize = true;
            this.ntlmlabel.Location = new System.Drawing.Point(11, 193);
            this.ntlmlabel.Name = "ntlmlabel";
            this.ntlmlabel.Size = new System.Drawing.Size(262, 13);
            this.ntlmlabel.TabIndex = 66;
            this.ntlmlabel.Text = "disable NTLM inbound and outbound policies (macro):";
            // 
            // NTLMbtn
            // 
            this.NTLMbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NTLMbtn.AutoSize = true;
            this.NTLMbtn.Location = new System.Drawing.Point(420, 209);
            this.NTLMbtn.Name = "NTLMbtn";
            this.NTLMbtn.Size = new System.Drawing.Size(75, 23);
            this.NTLMbtn.TabIndex = 65;
            this.NTLMbtn.Text = "Apply";
            this.NTLMbtn.UseVisualStyleBackColor = true;
            this.NTLMbtn.Click += new System.EventHandler(this.callNTLMEvent);
            // 
            // NTLMProgress
            // 
            this.NTLMProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NTLMProgress.Location = new System.Drawing.Point(11, 209);
            this.NTLMProgress.Name = "NTLMProgress";
            this.NTLMProgress.Size = new System.Drawing.Size(403, 23);
            this.NTLMProgress.TabIndex = 64;
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
            this.panel1.Location = new System.Drawing.Point(9, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 117);
            this.panel1.TabIndex = 68;
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
            this.ninitelabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // niniteselectallbtn
            // 
            this.niniteselectallbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.niniteselectallbtn.Location = new System.Drawing.Point(222, 91);
            this.niniteselectallbtn.Name = "niniteselectallbtn";
            this.niniteselectallbtn.Size = new System.Drawing.Size(75, 23);
            this.niniteselectallbtn.TabIndex = 20;
            this.niniteselectallbtn.Text = "Deselect";
            this.niniteselectallbtn.UseVisualStyleBackColor = true;
            this.niniteselectallbtn.Click += new System.EventHandler(this.niniteselectallbtn_Click);
            // 
            // niniteinstallbtn
            // 
            this.niniteinstallbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.niniteinstallbtn.Location = new System.Drawing.Point(303, 90);
            this.niniteinstallbtn.Name = "niniteinstallbtn";
            this.niniteinstallbtn.Size = new System.Drawing.Size(161, 23);
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
            this.niniteputtycheckbox.CheckedChanged += new System.EventHandler(this.niniteputtycheckbox_CheckedChanged);
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
            this.winscpcheckbox.CheckedChanged += new System.EventHandler(this.winscpcheckbox_CheckedChanged);
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
            this.ninitenotepadcheckbox.CheckedChanged += new System.EventHandler(this.ninitenotepadcheckbox_CheckedChanged);
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
            this.ninitefilezillacheckbox.CheckedChanged += new System.EventHandler(this.ninitefilezillacheckbox_CheckedChanged);
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
            this.ninitewinrarcheckbox.CheckedChanged += new System.EventHandler(this.ninitewinrarcheckbox_CheckedChanged);
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
            this.ninite7zipcheckbox.CheckedChanged += new System.EventHandler(this.ninite7zipcheckbox_CheckedChanged);
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
            this.niniteclassiccheckbox.CheckedChanged += new System.EventHandler(this.niniteclassiccheckbox_CheckedChanged);
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
            this.niniteimgburncheckbox.CheckedChanged += new System.EventHandler(this.niniteimgburncheckbox_CheckedChanged);
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
            this.ninitegoogledrivecheckbox.CheckedChanged += new System.EventHandler(this.ninitegoogledrivecheckbox_CheckedChanged);
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
            this.ninitedropboxcheckbox.CheckedChanged += new System.EventHandler(this.ninitedropboxcheckbox_CheckedChanged);
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
            this.ninitembamcheckbox.CheckedChanged += new System.EventHandler(this.ninitembamcheckbox_CheckedChanged);
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
            this.niniteessentialscheckbox.CheckedChanged += new System.EventHandler(this.niniteessentialscheckbox_CheckedChanged);
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
            this.ninitespotifycheckbox.CheckedChanged += new System.EventHandler(this.ninitespotifycheckbox_CheckedChanged);
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
            this.ninitevlcplayercheckbox.CheckedChanged += new System.EventHandler(this.ninitevlcplayercheckbox_CheckedChanged);
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
            this.niniteitunescheckbox.CheckedChanged += new System.EventHandler(this.niniteitunescheckbox_CheckedChanged);
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
            this.ninitethunderbirdcheckbox.CheckedChanged += new System.EventHandler(this.ninitethunderbirdcheckbox_CheckedChanged);
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
            this.niniteskypecheckbox.CheckedChanged += new System.EventHandler(this.niniteskypecheckbox_CheckedChanged);
            // 
            // optionaloptionslabel
            // 
            this.optionaloptionslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionaloptionslabel.AutoSize = true;
            this.optionaloptionslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionaloptionslabel.Location = new System.Drawing.Point(10, 534);
            this.optionaloptionslabel.Name = "optionaloptionslabel";
            this.optionaloptionslabel.Size = new System.Drawing.Size(101, 13);
            this.optionaloptionslabel.TabIndex = 69;
            this.optionaloptionslabel.Text = "optional options:";
            // 
            // keepasslabel
            // 
            this.keepasslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keepasslabel.AutoSize = true;
            this.keepasslabel.Location = new System.Drawing.Point(9, 670);
            this.keepasslabel.Name = "keepasslabel";
            this.keepasslabel.Size = new System.Drawing.Size(158, 13);
            this.keepasslabel.TabIndex = 72;
            this.keepasslabel.Text = "Install Keepass as Administrator:";
            // 
            // keepassbtn
            // 
            this.keepassbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keepassbtn.AutoSize = true;
            this.keepassbtn.Enabled = false;
            this.keepassbtn.Location = new System.Drawing.Point(418, 686);
            this.keepassbtn.Name = "keepassbtn";
            this.keepassbtn.Size = new System.Drawing.Size(75, 23);
            this.keepassbtn.TabIndex = 71;
            this.keepassbtn.Text = "Apply";
            this.keepassbtn.UseVisualStyleBackColor = true;
            // 
            // keepassprogress
            // 
            this.keepassprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keepassprogress.Enabled = false;
            this.keepassprogress.Location = new System.Drawing.Point(9, 686);
            this.keepassprogress.Name = "keepassprogress";
            this.keepassprogress.Size = new System.Drawing.Size(406, 23);
            this.keepassprogress.TabIndex = 70;
            // 
            // chromelabel
            // 
            this.chromelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromelabel.AutoSize = true;
            this.chromelabel.Location = new System.Drawing.Point(9, 712);
            this.chromelabel.Name = "chromelabel";
            this.chromelabel.Size = new System.Drawing.Size(369, 13);
            this.chromelabel.TabIndex = 75;
            this.chromelabel.Text = "Google Chrome 64 bit (Work/Bussiness Edition) with extra hardened security:";
            // 
            // chromebtn
            // 
            this.chromebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chromebtn.AutoSize = true;
            this.chromebtn.Enabled = false;
            this.chromebtn.Location = new System.Drawing.Point(418, 728);
            this.chromebtn.Name = "chromebtn";
            this.chromebtn.Size = new System.Drawing.Size(75, 23);
            this.chromebtn.TabIndex = 74;
            this.chromebtn.Text = "Apply";
            this.chromebtn.UseVisualStyleBackColor = true;
            // 
            // chromeprogress
            // 
            this.chromeprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeprogress.Enabled = false;
            this.chromeprogress.Location = new System.Drawing.Point(9, 728);
            this.chromeprogress.Name = "chromeprogress";
            this.chromeprogress.Size = new System.Drawing.Size(406, 23);
            this.chromeprogress.TabIndex = 73;
            // 
            // chromeaddonlabel
            // 
            this.chromeaddonlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonlabel.AutoSize = true;
            this.chromeaddonlabel.Location = new System.Drawing.Point(9, 754);
            this.chromeaddonlabel.Name = "chromeaddonlabel";
            this.chromeaddonlabel.Size = new System.Drawing.Size(164, 13);
            this.chromeaddonlabel.TabIndex = 78;
            this.chromeaddonlabel.Text = "Install safety addons into chrome:";
            // 
            // chromeaddonbtn
            // 
            this.chromeaddonbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonbtn.AutoSize = true;
            this.chromeaddonbtn.Enabled = false;
            this.chromeaddonbtn.Location = new System.Drawing.Point(418, 770);
            this.chromeaddonbtn.Name = "chromeaddonbtn";
            this.chromeaddonbtn.Size = new System.Drawing.Size(75, 23);
            this.chromeaddonbtn.TabIndex = 77;
            this.chromeaddonbtn.Text = "Apply";
            this.chromeaddonbtn.UseVisualStyleBackColor = true;
            // 
            // chromeaddonprogress
            // 
            this.chromeaddonprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeaddonprogress.Enabled = false;
            this.chromeaddonprogress.Location = new System.Drawing.Point(9, 770);
            this.chromeaddonprogress.Name = "chromeaddonprogress";
            this.chromeaddonprogress.Size = new System.Drawing.Size(406, 23);
            this.chromeaddonprogress.TabIndex = 76;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionSettingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsServerToolStripMenuItem,
            this.setAsClientToolStripMenuItem});
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.connectionSettingsToolStripMenuItem.Text = "settings";
            // 
            // setAsServerToolStripMenuItem
            // 
            this.setAsServerToolStripMenuItem.Enabled = false;
            this.setAsServerToolStripMenuItem.Name = "setAsServerToolStripMenuItem";
            this.setAsServerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.setAsServerToolStripMenuItem.Text = "set as server";
            // 
            // setAsClientToolStripMenuItem
            // 
            this.setAsClientToolStripMenuItem.Enabled = false;
            this.setAsClientToolStripMenuItem.Name = "setAsClientToolStripMenuItem";
            this.setAsClientToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.setAsClientToolStripMenuItem.Text = "set as client";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // insecureserviceslabel
            // 
            this.insecureserviceslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insecureserviceslabel.AutoSize = true;
            this.insecureserviceslabel.Location = new System.Drawing.Point(9, 361);
            this.insecureserviceslabel.Name = "insecureserviceslabel";
            this.insecureserviceslabel.Size = new System.Drawing.Size(169, 13);
            this.insecureserviceslabel.TabIndex = 82;
            this.insecureserviceslabel.Text = "disable insecure network services:";
            // 
            // insecureservicesbtn
            // 
            this.insecureservicesbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insecureservicesbtn.AutoSize = true;
            this.insecureservicesbtn.Enabled = false;
            this.insecureservicesbtn.Location = new System.Drawing.Point(418, 377);
            this.insecureservicesbtn.Name = "insecureservicesbtn";
            this.insecureservicesbtn.Size = new System.Drawing.Size(75, 23);
            this.insecureservicesbtn.TabIndex = 81;
            this.insecureservicesbtn.Text = "Apply";
            this.insecureservicesbtn.UseVisualStyleBackColor = true;
            this.insecureservicesbtn.Click += new System.EventHandler(this.callInsecureServicesEvent);
            // 
            // insecureserviceprogress
            // 
            this.insecureserviceprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insecureserviceprogress.Enabled = false;
            this.insecureserviceprogress.Location = new System.Drawing.Point(9, 377);
            this.insecureserviceprogress.Name = "insecureserviceprogress";
            this.insecureserviceprogress.Size = new System.Drawing.Size(406, 23);
            this.insecureserviceprogress.TabIndex = 80;
            // 
            // boguscertlabel
            // 
            this.boguscertlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boguscertlabel.AutoSize = true;
            this.boguscertlabel.Location = new System.Drawing.Point(8, 403);
            this.boguscertlabel.Name = "boguscertlabel";
            this.boguscertlabel.Size = new System.Drawing.Size(208, 13);
            this.boguscertlabel.TabIndex = 85;
            this.boguscertlabel.TabStop = true;
            this.boguscertlabel.Text = "remove bogus certificates (uses sigcheck):";
            this.boguscertlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.boguscertlabel_LinkClicked);
            // 
            // boguscertbtn
            // 
            this.boguscertbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boguscertbtn.AutoSize = true;
            this.boguscertbtn.Location = new System.Drawing.Point(417, 419);
            this.boguscertbtn.Name = "boguscertbtn";
            this.boguscertbtn.Size = new System.Drawing.Size(75, 23);
            this.boguscertbtn.TabIndex = 84;
            this.boguscertbtn.Text = "Apply";
            this.boguscertbtn.UseVisualStyleBackColor = true;
            this.boguscertbtn.Click += new System.EventHandler(this.callBogusCertEvent);
            // 
            // boguscertprogress
            // 
            this.boguscertprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boguscertprogress.Location = new System.Drawing.Point(8, 419);
            this.boguscertprogress.Name = "boguscertprogress";
            this.boguscertprogress.Size = new System.Drawing.Size(406, 23);
            this.boguscertprogress.TabIndex = 83;
            // 
            // mbrfilterlabel
            // 
            this.mbrfilterlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbrfilterlabel.AutoSize = true;
            this.mbrfilterlabel.Location = new System.Drawing.Point(8, 445);
            this.mbrfilterlabel.Name = "mbrfilterlabel";
            this.mbrfilterlabel.Size = new System.Drawing.Size(428, 13);
            this.mbrfilterlabel.TabIndex = 88;
            this.mbrfilterlabel.TabStop = true;
            this.mbrfilterlabel.Text = "install mbrfilter to prevent bootloader modification (created by: Yves Younan, Ci" +
    "sco Talos):";
            this.mbrfilterlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.callMBRfilterlabel);
            // 
            // mbrbtn
            // 
            this.mbrbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbrbtn.AutoSize = true;
            this.mbrbtn.Enabled = false;
            this.mbrbtn.Location = new System.Drawing.Point(206, 461);
            this.mbrbtn.Name = "mbrbtn";
            this.mbrbtn.Size = new System.Drawing.Size(288, 23);
            this.mbrbtn.TabIndex = 87;
            this.mbrbtn.Text = "disabled, has no uninstall way without damaging the MBR";
            this.mbrbtn.UseVisualStyleBackColor = true;
            this.mbrbtn.Click += new System.EventHandler(this.callMBREvent);
            // 
            // mbrprogress
            // 
            this.mbrprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbrprogress.Location = new System.Drawing.Point(10, 461);
            this.mbrprogress.Name = "mbrprogress";
            this.mbrprogress.Size = new System.Drawing.Size(190, 23);
            this.mbrprogress.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "disable netshares:";
            // 
            // netsharebtn
            // 
            this.netsharebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.netsharebtn.AutoSize = true;
            this.netsharebtn.Location = new System.Drawing.Point(422, 503);
            this.netsharebtn.Name = "netsharebtn";
            this.netsharebtn.Size = new System.Drawing.Size(75, 23);
            this.netsharebtn.TabIndex = 91;
            this.netsharebtn.Text = "Apply";
            this.netsharebtn.UseVisualStyleBackColor = true;
            this.netsharebtn.Click += new System.EventHandler(this.netsharebtn_Click);
            // 
            // netshareprogress
            // 
            this.netshareprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netshareprogress.Location = new System.Drawing.Point(13, 503);
            this.netshareprogress.Name = "netshareprogress";
            this.netshareprogress.Size = new System.Drawing.Size(406, 23);
            this.netshareprogress.TabIndex = 90;
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 844);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.netsharebtn);
            this.Controls.Add(this.netshareprogress);
            this.Controls.Add(this.applyforcebtn);
            this.Controls.Add(this.mbrfilterlabel);
            this.Controls.Add(this.mbrbtn);
            this.Controls.Add(this.mbrprogress);
            this.Controls.Add(this.boguscertlabel);
            this.Controls.Add(this.boguscertbtn);
            this.Controls.Add(this.boguscertprogress);
            this.Controls.Add(this.insecureserviceslabel);
            this.Controls.Add(this.insecureservicesbtn);
            this.Controls.Add(this.insecureserviceprogress);
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
            this.Controls.Add(this.ntlmlabel);
            this.Controls.Add(this.NTLMbtn);
            this.Controls.Add(this.NTLMProgress);
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.safeapplybtn);
            this.Controls.Add(this.remoteregistrylabel);
            this.Controls.Add(this.remoteregbtn);
            this.Controls.Add(this.remoteregprogress);
            this.Controls.Add(this.rdplabel);
            this.Controls.Add(this.rdpbtn);
            this.Controls.Add(this.rdpprogress);
            this.Controls.Add(this.uaclabel);
            this.Controls.Add(this.uac_btn);
            this.Controls.Add(this.uac_progress);
            this.Controls.Add(this.renamelabel);
            this.Controls.Add(this.renamebtn);
            this.Controls.Add(this.renameprogress);
            this.Controls.Add(this.wscriptlabel);
            this.Controls.Add(this.wscript_btn);
            this.Controls.Add(this.wscript_progress);
            this.Controls.Add(this.netbioslabel);
            this.Controls.Add(this.netbiosbtn);
            this.Controls.Add(this.netbiosprogress);
            this.Controls.Add(this.tempolicylabel);
            this.Controls.Add(this.temp_policy_btn);
            this.Controls.Add(this.temp_policy_load);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(526, 883);
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Security Tweaker Tool 14.0.25420.1b (WSTT)";
            this.Load += new System.EventHandler(this.window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar temp_policy_load;
        public Button temp_policy_btn;
        public ProgressBar wscript_progress;
        public Button wscript_btn;
        private System.Windows.Forms.Label tempolicylabel;
        private System.Windows.Forms.Label netbioslabel;
        public System.Windows.Forms.Button netbiosbtn;
        public System.Windows.Forms.ProgressBar netbiosprogress;
        private System.Windows.Forms.Label wscriptlabel;
        private System.Windows.Forms.Label renamelabel;
        public System.Windows.Forms.Button renamebtn;
        public System.Windows.Forms.ProgressBar renameprogress;
        private System.Windows.Forms.Label uaclabel;
        public System.Windows.Forms.Button uac_btn;
        public System.Windows.Forms.ProgressBar uac_progress;
        private System.Windows.Forms.Label rdplabel;
        public System.Windows.Forms.Button rdpbtn;
        public System.Windows.Forms.ProgressBar rdpprogress;
        private System.Windows.Forms.Label remoteregistrylabel;
        public System.Windows.Forms.Button remoteregbtn;
        public System.Windows.Forms.ProgressBar remoteregprogress;
        private System.Windows.Forms.Button safeapplybtn;
        private System.Windows.Forms.Button undobtn;
        private ToolTip tooltip;
        private Label ntlmlabel;
        public Button NTLMbtn;
        public ProgressBar NTLMProgress;
        private Panel panel1;
        private Button niniteselectallbtn;
        private Button niniteinstallbtn;
        private Label optionaloptionslabel;
        private Label keepasslabel;
        private Button keepassbtn;
        private ProgressBar keepassprogress;
        private Label chromelabel;
        private Button chromebtn;
        private ProgressBar chromeprogress;
        private Label chromeaddonlabel;
        private Button chromeaddonbtn;
        private ProgressBar chromeaddonprogress;
        private LinkLabel ninitelabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private ToolStripMenuItem setAsServerToolStripMenuItem;
        private ToolStripMenuItem setAsClientToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTip toolTip1;
        private Label insecureserviceslabel;
        private Button insecureservicesbtn;
        private ProgressBar insecureserviceprogress;
        private ToolTip toolTip2;
        private LinkLabel mbrfilterlabel;
        public Button mbrbtn;
        public ProgressBar mbrprogress;
        private Button applyforcebtn;
        public CheckBox niniteskypecheckbox;
        public CheckBox ninitedropboxcheckbox;
        public CheckBox ninitembamcheckbox;
        public CheckBox niniteessentialscheckbox;
        public CheckBox ninitespotifycheckbox;
        public CheckBox ninitevlcplayercheckbox;
        public CheckBox niniteitunescheckbox;
        public CheckBox ninitethunderbirdcheckbox;
        public CheckBox niniteclassiccheckbox;
        public CheckBox niniteimgburncheckbox;
        public CheckBox ninitegoogledrivecheckbox;
        public CheckBox ninitewinrarcheckbox;
        public CheckBox ninite7zipcheckbox;
        public CheckBox niniteputtycheckbox;
        public CheckBox winscpcheckbox;
        public CheckBox ninitenotepadcheckbox;
        public CheckBox ninitefilezillacheckbox;
        public Button boguscertbtn;
        public ProgressBar boguscertprogress;
        private LinkLabel boguscertlabel;
        private Label label1;
        public Button netsharebtn;
        public ProgressBar netshareprogress;
    }
}

