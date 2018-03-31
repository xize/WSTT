using System;
using System.Windows.Forms;
using windows_security_tweak_tool.src.policies;
using windows_security_tweak_tool.src.controls;

namespace windows_security_tweak_tool.src
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
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
            this.discoverycheckbox = new System.Windows.Forms.CheckBox();
            this.ntlmlabel = new System.Windows.Forms.Label();
            this.NTLMbtn = new System.Windows.Forms.Button();
            this.NTLMProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOptionalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPoliciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insecureserviceslabel = new System.Windows.Forms.Label();
            this.insecureservicesbtn = new System.Windows.Forms.Button();
            this.insecureserviceprogress = new System.Windows.Forms.ProgressBar();
            this.boguscertlabel = new System.Windows.Forms.LinkLabel();
            this.boguscertbtn = new System.Windows.Forms.Button();
            this.mbrfilterlabel = new System.Windows.Forms.LinkLabel();
            this.mbrbtn = new System.Windows.Forms.Button();
            this.mbrprogress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.netsharebtn = new System.Windows.Forms.Button();
            this.netshareprogress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.llmnrbtn = new System.Windows.Forms.Button();
            this.llmnrprogress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.unsignedbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.smbbtn = new System.Windows.Forms.Button();
            this.smbprogress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.autoplaybtn = new System.Windows.Forms.Button();
            this.autoplayprogress = new System.Windows.Forms.ProgressBar();
            this.boguscertprogress = new System.Windows.Forms.ProgressBar();
            this.unsignedprogress = new System.Windows.Forms.ProgressBar();
            this.disablepowershellcheck = new System.Windows.Forms.CheckBox();
            this.windowsupdatepeerbtn = new System.Windows.Forms.Button();
            this.windowsupdatepeerprogress = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temp_policy_load
            // 
            this.temp_policy_load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_policy_load.Location = new System.Drawing.Point(12, 44);
            this.temp_policy_load.Name = "temp_policy_load";
            this.temp_policy_load.Size = new System.Drawing.Size(282, 23);
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
            this.safeapplybtn.Location = new System.Drawing.Point(9, 762);
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
            this.undobtn.Location = new System.Drawing.Point(419, 762);
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
            this.applyforcebtn.Location = new System.Drawing.Point(173, 762);
            this.applyforcebtn.Name = "applyforcebtn";
            this.applyforcebtn.Size = new System.Drawing.Size(100, 23);
            this.applyforcebtn.TabIndex = 89;
            this.applyforcebtn.Text = "Apply All (Forced)";
            this.tooltip.SetToolTip(this.applyforcebtn, "this will apply everything");
            this.applyforcebtn.UseVisualStyleBackColor = true;
            this.applyforcebtn.Click += new System.EventHandler(this.callApplyEvent);
            // 
            // discoverycheckbox
            // 
            this.discoverycheckbox.AutoSize = true;
            this.discoverycheckbox.Location = new System.Drawing.Point(305, 383);
            this.discoverycheckbox.Name = "discoverycheckbox";
            this.discoverycheckbox.Size = new System.Drawing.Size(113, 17);
            this.discoverycheckbox.TabIndex = 111;
            this.discoverycheckbox.Text = "disable discovery?";
            this.tooltip.SetToolTip(this.discoverycheckbox, "discovery is a service which makes it easier to detect hardware across the networ" +
        "k.\r\nprinters and such may require this feature to work properly.");
            this.discoverycheckbox.UseVisualStyleBackColor = true;
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
            this.openOptionalOptionsToolStripMenuItem,
            this.setAsServerToolStripMenuItem,
            this.setAsClientToolStripMenuItem,
            this.resetPoliciesToolStripMenuItem});
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.connectionSettingsToolStripMenuItem.Text = "settings";
            // 
            // openOptionalOptionsToolStripMenuItem
            // 
            this.openOptionalOptionsToolStripMenuItem.Name = "openOptionalOptionsToolStripMenuItem";
            this.openOptionalOptionsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.openOptionalOptionsToolStripMenuItem.Text = "Open Optional options";
            this.openOptionalOptionsToolStripMenuItem.Click += new System.EventHandler(this.openOptionalOptionsToolStripMenuItem_Click);
            // 
            // setAsServerToolStripMenuItem
            // 
            this.setAsServerToolStripMenuItem.Enabled = false;
            this.setAsServerToolStripMenuItem.Name = "setAsServerToolStripMenuItem";
            this.setAsServerToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.setAsServerToolStripMenuItem.Text = "set as server";
            // 
            // setAsClientToolStripMenuItem
            // 
            this.setAsClientToolStripMenuItem.Enabled = false;
            this.setAsClientToolStripMenuItem.Name = "setAsClientToolStripMenuItem";
            this.setAsClientToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.setAsClientToolStripMenuItem.Text = "set as client";
            // 
            // resetPoliciesToolStripMenuItem
            // 
            this.resetPoliciesToolStripMenuItem.Name = "resetPoliciesToolStripMenuItem";
            this.resetPoliciesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.resetPoliciesToolStripMenuItem.Text = "hard reset windows group policies";
            this.resetPoliciesToolStripMenuItem.Click += new System.EventHandler(this.resetPoliciesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Enabled = false;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.insecureservicesbtn.Location = new System.Drawing.Point(420, 377);
            this.insecureservicesbtn.Name = "insecureservicesbtn";
            this.insecureservicesbtn.Size = new System.Drawing.Size(73, 23);
            this.insecureservicesbtn.TabIndex = 81;
            this.insecureservicesbtn.Text = "Apply";
            this.insecureservicesbtn.UseVisualStyleBackColor = true;
            this.insecureservicesbtn.Click += new System.EventHandler(this.callInsecureServicesEvent);
            // 
            // insecureserviceprogress
            // 
            this.insecureserviceprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insecureserviceprogress.Location = new System.Drawing.Point(9, 377);
            this.insecureserviceprogress.Name = "insecureserviceprogress";
            this.insecureserviceprogress.Size = new System.Drawing.Size(290, 23);
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
            this.boguscertbtn.Text = "Run!";
            this.boguscertbtn.UseVisualStyleBackColor = true;
            this.boguscertbtn.Click += new System.EventHandler(this.callBogusCertEvent);
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
            this.mbrbtn.Location = new System.Drawing.Point(417, 461);
            this.mbrbtn.Name = "mbrbtn";
            this.mbrbtn.Size = new System.Drawing.Size(73, 23);
            this.mbrbtn.TabIndex = 87;
            this.mbrbtn.Text = "Apply";
            this.mbrbtn.UseVisualStyleBackColor = true;
            this.mbrbtn.Click += new System.EventHandler(this.callMBREvent);
            // 
            // mbrprogress
            // 
            this.mbrprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbrprogress.Location = new System.Drawing.Point(10, 461);
            this.mbrprogress.Name = "mbrprogress";
            this.mbrprogress.Size = new System.Drawing.Size(404, 23);
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
            this.netsharebtn.Location = new System.Drawing.Point(420, 503);
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
            this.netshareprogress.Location = new System.Drawing.Point(11, 503);
            this.netshareprogress.Name = "netshareprogress";
            this.netshareprogress.Size = new System.Drawing.Size(406, 23);
            this.netshareprogress.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "disabling LLMNR broadcasting:";
            // 
            // llmnrbtn
            // 
            this.llmnrbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llmnrbtn.AutoSize = true;
            this.llmnrbtn.Location = new System.Drawing.Point(420, 545);
            this.llmnrbtn.Name = "llmnrbtn";
            this.llmnrbtn.Size = new System.Drawing.Size(75, 23);
            this.llmnrbtn.TabIndex = 94;
            this.llmnrbtn.Text = "Apply";
            this.llmnrbtn.UseVisualStyleBackColor = true;
            this.llmnrbtn.Click += new System.EventHandler(this.llmnrbtn_Click);
            // 
            // llmnrprogress
            // 
            this.llmnrprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llmnrprogress.Location = new System.Drawing.Point(10, 545);
            this.llmnrprogress.Name = "llmnrprogress";
            this.llmnrprogress.Size = new System.Drawing.Size(407, 23);
            this.llmnrprogress.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "show all unsigned dll and exe files not signed by Microsoft in C:\\windows";
            // 
            // unsignedbtn
            // 
            this.unsignedbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unsignedbtn.AutoSize = true;
            this.unsignedbtn.Location = new System.Drawing.Point(400, 586);
            this.unsignedbtn.Name = "unsignedbtn";
            this.unsignedbtn.Size = new System.Drawing.Size(94, 23);
            this.unsignedbtn.TabIndex = 100;
            this.unsignedbtn.Text = "Run!";
            this.unsignedbtn.UseVisualStyleBackColor = true;
            this.unsignedbtn.Click += new System.EventHandler(this.unsignedbtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "disable SMB sharing:";
            // 
            // smbbtn
            // 
            this.smbbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smbbtn.AutoSize = true;
            this.smbbtn.Location = new System.Drawing.Point(421, 627);
            this.smbbtn.Name = "smbbtn";
            this.smbbtn.Size = new System.Drawing.Size(71, 23);
            this.smbbtn.TabIndex = 103;
            this.smbbtn.Text = "Apply";
            this.smbbtn.UseVisualStyleBackColor = true;
            this.smbbtn.Click += new System.EventHandler(this.smbbtn_Click);
            // 
            // smbprogress
            // 
            this.smbprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smbprogress.Location = new System.Drawing.Point(8, 627);
            this.smbprogress.Name = "smbprogress";
            this.smbprogress.Size = new System.Drawing.Size(409, 23);
            this.smbprogress.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 652);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "disable autoplay:";
            // 
            // autoplaybtn
            // 
            this.autoplaybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoplaybtn.AutoSize = true;
            this.autoplaybtn.Location = new System.Drawing.Point(422, 668);
            this.autoplaybtn.Name = "autoplaybtn";
            this.autoplaybtn.Size = new System.Drawing.Size(71, 23);
            this.autoplaybtn.TabIndex = 106;
            this.autoplaybtn.Text = "Apply";
            this.autoplaybtn.UseVisualStyleBackColor = true;
            this.autoplaybtn.Click += new System.EventHandler(this.autoplaybtn_Click);
            // 
            // autoplayprogress
            // 
            this.autoplayprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoplayprogress.Location = new System.Drawing.Point(9, 668);
            this.autoplayprogress.Name = "autoplayprogress";
            this.autoplayprogress.Size = new System.Drawing.Size(409, 23);
            this.autoplayprogress.TabIndex = 105;
            // 
            // boguscertprogress
            // 
            this.boguscertprogress.Location = new System.Drawing.Point(12, 419);
            this.boguscertprogress.Name = "boguscertprogress";
            this.boguscertprogress.Size = new System.Drawing.Size(399, 23);
            this.boguscertprogress.TabIndex = 108;
            // 
            // unsignedprogress
            // 
            this.unsignedprogress.Location = new System.Drawing.Point(8, 586);
            this.unsignedprogress.Name = "unsignedprogress";
            this.unsignedprogress.Size = new System.Drawing.Size(383, 23);
            this.unsignedprogress.TabIndex = 109;
            // 
            // disablepowershellcheck
            // 
            this.disablepowershellcheck.AutoSize = true;
            this.disablepowershellcheck.Location = new System.Drawing.Point(300, 48);
            this.disablepowershellcheck.Name = "disablepowershellcheck";
            this.disablepowershellcheck.Size = new System.Drawing.Size(118, 17);
            this.disablepowershellcheck.TabIndex = 110;
            this.disablepowershellcheck.Text = "disable powershell?";
            this.disablepowershellcheck.UseVisualStyleBackColor = true;
            // 
            // windowsupdatepeerbtn
            // 
            this.windowsupdatepeerbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsupdatepeerbtn.AutoSize = true;
            this.windowsupdatepeerbtn.Location = new System.Drawing.Point(422, 710);
            this.windowsupdatepeerbtn.Name = "windowsupdatepeerbtn";
            this.windowsupdatepeerbtn.Size = new System.Drawing.Size(71, 23);
            this.windowsupdatepeerbtn.TabIndex = 113;
            this.windowsupdatepeerbtn.Text = "Apply";
            this.windowsupdatepeerbtn.UseVisualStyleBackColor = true;
            this.windowsupdatepeerbtn.Click += new System.EventHandler(this.windowsupdatepeerbtn_Click);
            // 
            // windowsupdatepeerprogress
            // 
            this.windowsupdatepeerprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsupdatepeerprogress.Location = new System.Drawing.Point(9, 710);
            this.windowsupdatepeerprogress.Name = "windowsupdatepeerprogress";
            this.windowsupdatepeerprogress.Size = new System.Drawing.Size(409, 23);
            this.windowsupdatepeerprogress.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "disable peer to peer windows updates";
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 799);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.windowsupdatepeerbtn);
            this.Controls.Add(this.windowsupdatepeerprogress);
            this.Controls.Add(this.discoverycheckbox);
            this.Controls.Add(this.disablepowershellcheck);
            this.Controls.Add(this.unsignedprogress);
            this.Controls.Add(this.boguscertprogress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.autoplaybtn);
            this.Controls.Add(this.autoplayprogress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smbbtn);
            this.Controls.Add(this.smbprogress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unsignedbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llmnrbtn);
            this.Controls.Add(this.llmnrprogress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.netsharebtn);
            this.Controls.Add(this.netshareprogress);
            this.Controls.Add(this.applyforcebtn);
            this.Controls.Add(this.mbrfilterlabel);
            this.Controls.Add(this.mbrbtn);
            this.Controls.Add(this.mbrprogress);
            this.Controls.Add(this.boguscertlabel);
            this.Controls.Add(this.boguscertbtn);
            this.Controls.Add(this.insecureserviceslabel);
            this.Controls.Add(this.insecureservicesbtn);
            this.Controls.Add(this.insecureserviceprogress);
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
            this.MinimumSize = new System.Drawing.Size(526, 838);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Security Tweaker Tool 14.0.25420.1b (WSTT)";
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private ToolStripMenuItem setAsServerToolStripMenuItem;
        private ToolStripMenuItem setAsClientToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label insecureserviceslabel;
        private LinkLabel mbrfilterlabel;
        public Button mbrbtn;
        public ProgressBar mbrprogress;
        private Button applyforcebtn;
        public Button boguscertbtn;
        private LinkLabel boguscertlabel;
        private Label label1;
        public Button netsharebtn;
        public ProgressBar netshareprogress;
        private Label label2;
        public Button llmnrbtn;
        public ProgressBar llmnrprogress;
        public ToolStripMenuItem openOptionalOptionsToolStripMenuItem;
        private Label label4;
        public Button unsignedbtn;
        private ToolStripMenuItem resetPoliciesToolStripMenuItem;
        public ProgressBar insecureserviceprogress;
        public Button insecureservicesbtn;
        private Label label3;
        public Button smbbtn;
        public ProgressBar smbprogress;
        private Label label5;
        public Button autoplaybtn;
        public ProgressBar autoplayprogress;
        public ProgressBar boguscertprogress;
        public ProgressBar unsignedprogress;
        public CheckBox disablepowershellcheck;
        public CheckBox discoverycheckbox;
        public Button windowsupdatepeerbtn;
        public ProgressBar windowsupdatepeerprogress;
        private Label label6;
    }
}