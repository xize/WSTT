using System;
using System.Windows.Forms;
using windows_security_tweak_tool.src.controls;
using windows_security_tweak_tool.src.policies;

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
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.flatButton1 = new windows_security_tweak_tool.src.controls.FlatButton();
            this.panel31 = new System.Windows.Forms.Panel();
            this.flatButton2 = new windows_security_tweak_tool.src.controls.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT12 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel28 = new System.Windows.Forms.Panel();
            this.securityControl_DARK12 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel27 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT11 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel26 = new System.Windows.Forms.Panel();
            this.securityControl_DARK11 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel25 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT10 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel24 = new System.Windows.Forms.Panel();
            this.securityControl_DARK10 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel23 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT9 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel22 = new System.Windows.Forms.Panel();
            this.securityControl_DARK9 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel21 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT8 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel20 = new System.Windows.Forms.Panel();
            this.securityControl_DARK8 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel19 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT7 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel18 = new System.Windows.Forms.Panel();
            this.securityControl_DARK7 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT6 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel16 = new System.Windows.Forms.Panel();
            this.securityControl_DARK6 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel15 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT5 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel14 = new System.Windows.Forms.Panel();
            this.securityControl_DARK5 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel13 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT4 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel12 = new System.Windows.Forms.Panel();
            this.securityControl_DARK4 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel11 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT3 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel10 = new System.Windows.Forms.Panel();
            this.securityControl_DARK3 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel9 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT2 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel8 = new System.Windows.Forms.Panel();
            this.securityControl_DARK2 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel7 = new System.Windows.Forms.Panel();
            this.securityControl_LIGHT1 = new windows_security_tweak_tool.src.controls.SecurityControl_LIGHT();
            this.panel6 = new System.Windows.Forms.Panel();
            this.securityControl_DARK1 = new windows_security_tweak_tool.src.controls.SecurityControl_DARK();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flatButton5 = new windows_security_tweak_tool.src.controls.FlatButton();
            this.flatButton4 = new windows_security_tweak_tool.src.controls.FlatButton();
            this.flatButton3 = new windows_security_tweak_tool.src.controls.FlatButton();
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
            this.boguscertprogress = new System.Windows.Forms.ProgressBar();
            this.mbrfilterlabel = new System.Windows.Forms.LinkLabel();
            this.mbrbtn = new System.Windows.Forms.Button();
            this.mbrprogress = new System.Windows.Forms.ProgressBar();
            this.netsharebtn = new System.Windows.Forms.Button();
            this.netshareprogress = new System.Windows.Forms.ProgressBar();
            this.llmnrbtn = new System.Windows.Forms.Button();
            this.llmnrprogress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.unsignedbtn = new System.Windows.Forms.Button();
            this.unsignedprogress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.smbbtn = new System.Windows.Forms.Button();
            this.smbprogress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.WSTT;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel30);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.panel32);
            this.panel30.Controls.Add(this.panel31);
            this.panel30.Location = new System.Drawing.Point(333, 122);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(168, 59);
            this.panel30.TabIndex = 3;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.flatButton1);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel32.Location = new System.Drawing.Point(0, 30);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(168, 28);
            this.panel32.TabIndex = 1;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(3, 3);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(162, 23);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "open optional settings";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.flatButton2);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel31.Location = new System.Drawing.Point(0, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(168, 30);
            this.panel31.TabIndex = 0;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton2.ForeColor = System.Drawing.Color.White;
            this.flatButton2.Location = new System.Drawing.Point(3, 3);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(162, 24);
            this.flatButton2.TabIndex = 0;
            this.flatButton2.Text = "check for updates";
            this.flatButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "disabling LLMNR broadcasting:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "disable netshares:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 408);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel29);
            this.panel5.Controls.Add(this.panel28);
            this.panel5.Controls.Add(this.panel27);
            this.panel5.Controls.Add(this.panel26);
            this.panel5.Controls.Add(this.panel25);
            this.panel5.Controls.Add(this.panel24);
            this.panel5.Controls.Add(this.panel23);
            this.panel5.Controls.Add(this.panel22);
            this.panel5.Controls.Add(this.panel21);
            this.panel5.Controls.Add(this.panel20);
            this.panel5.Controls.Add(this.panel19);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(262, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 408);
            this.panel5.TabIndex = 1;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.securityControl_LIGHT12);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(0, 363);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(264, 33);
            this.panel29.TabIndex = 12;
            // 
            // securityControl_LIGHT12
            // 
            this.securityControl_LIGHT12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT12.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT12.ButtonText = "run!";
            this.securityControl_LIGHT12.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT12.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT12.Name = "securityControl_LIGHT12";
            this.securityControl_LIGHT12.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT12.TabIndex = 6;
            this.securityControl_LIGHT12.WIP = false;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.securityControl_DARK12);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 330);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(264, 33);
            this.panel28.TabIndex = 11;
            // 
            // securityControl_DARK12
            // 
            this.securityControl_DARK12.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK12.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK12.ButtonText = "run!";
            this.securityControl_DARK12.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK12.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK12.Name = "securityControl_DARK12";
            this.securityControl_DARK12.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK12.TabIndex = 6;
            this.securityControl_DARK12.WIP = false;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.securityControl_LIGHT11);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(0, 297);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(264, 33);
            this.panel27.TabIndex = 10;
            // 
            // securityControl_LIGHT11
            // 
            this.securityControl_LIGHT11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT11.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT11.ButtonText = "run!";
            this.securityControl_LIGHT11.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT11.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT11.Name = "securityControl_LIGHT11";
            this.securityControl_LIGHT11.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT11.TabIndex = 5;
            this.securityControl_LIGHT11.WIP = false;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.securityControl_DARK11);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(0, 264);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(264, 33);
            this.panel26.TabIndex = 9;
            // 
            // securityControl_DARK11
            // 
            this.securityControl_DARK11.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK11.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK11.ButtonText = "run!";
            this.securityControl_DARK11.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK11.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK11.Name = "securityControl_DARK11";
            this.securityControl_DARK11.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK11.TabIndex = 5;
            this.securityControl_DARK11.WIP = false;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.securityControl_LIGHT10);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 231);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(264, 33);
            this.panel25.TabIndex = 8;
            // 
            // securityControl_LIGHT10
            // 
            this.securityControl_LIGHT10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT10.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT10.ButtonText = "run!";
            this.securityControl_LIGHT10.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT10.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT10.Name = "securityControl_LIGHT10";
            this.securityControl_LIGHT10.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT10.TabIndex = 4;
            this.securityControl_LIGHT10.WIP = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.securityControl_DARK10);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 198);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(264, 33);
            this.panel24.TabIndex = 7;
            // 
            // securityControl_DARK10
            // 
            this.securityControl_DARK10.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK10.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK10.ButtonText = "run!";
            this.securityControl_DARK10.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK10.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK10.Name = "securityControl_DARK10";
            this.securityControl_DARK10.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK10.TabIndex = 4;
            this.securityControl_DARK10.WIP = false;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.securityControl_LIGHT9);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 165);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(264, 33);
            this.panel23.TabIndex = 6;
            // 
            // securityControl_LIGHT9
            // 
            this.securityControl_LIGHT9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT9.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT9.ButtonText = "run!";
            this.securityControl_LIGHT9.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT9.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT9.Name = "securityControl_LIGHT9";
            this.securityControl_LIGHT9.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT9.TabIndex = 3;
            this.securityControl_LIGHT9.WIP = false;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.securityControl_DARK9);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 132);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(264, 33);
            this.panel22.TabIndex = 5;
            // 
            // securityControl_DARK9
            // 
            this.securityControl_DARK9.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK9.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK9.ButtonText = "run!";
            this.securityControl_DARK9.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK9.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK9.Name = "securityControl_DARK9";
            this.securityControl_DARK9.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK9.TabIndex = 3;
            this.securityControl_DARK9.WIP = false;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.securityControl_LIGHT8);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 99);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(264, 33);
            this.panel21.TabIndex = 4;
            // 
            // securityControl_LIGHT8
            // 
            this.securityControl_LIGHT8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT8.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT8.ButtonText = "run!";
            this.securityControl_LIGHT8.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT8.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT8.Name = "securityControl_LIGHT8";
            this.securityControl_LIGHT8.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT8.TabIndex = 2;
            this.securityControl_LIGHT8.WIP = false;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.securityControl_DARK8);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 66);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(264, 33);
            this.panel20.TabIndex = 3;
            // 
            // securityControl_DARK8
            // 
            this.securityControl_DARK8.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK8.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK8.ButtonText = "run!";
            this.securityControl_DARK8.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK8.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK8.Name = "securityControl_DARK8";
            this.securityControl_DARK8.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK8.TabIndex = 2;
            this.securityControl_DARK8.WIP = false;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.securityControl_LIGHT7);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 33);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(264, 33);
            this.panel19.TabIndex = 2;
            // 
            // securityControl_LIGHT7
            // 
            this.securityControl_LIGHT7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT7.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT7.ButtonText = "run!";
            this.securityControl_LIGHT7.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT7.Location = new System.Drawing.Point(1, 0);
            this.securityControl_LIGHT7.Name = "securityControl_LIGHT7";
            this.securityControl_LIGHT7.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT7.TabIndex = 1;
            this.securityControl_LIGHT7.WIP = false;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.securityControl_DARK7);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(264, 33);
            this.panel18.TabIndex = 1;
            // 
            // securityControl_DARK7
            // 
            this.securityControl_DARK7.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK7.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK7.ButtonText = "run!";
            this.securityControl_DARK7.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK7.Location = new System.Drawing.Point(1, 0);
            this.securityControl_DARK7.Name = "securityControl_DARK7";
            this.securityControl_DARK7.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK7.TabIndex = 1;
            this.securityControl_DARK7.WIP = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 408);
            this.panel4.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.securityControl_LIGHT6);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 363);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(262, 33);
            this.panel17.TabIndex = 11;
            // 
            // securityControl_LIGHT6
            // 
            this.securityControl_LIGHT6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT6.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT6.ButtonText = "run!";
            this.securityControl_LIGHT6.Description = new string[] {
        "some text",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT6.Location = new System.Drawing.Point(0, 0);
            this.securityControl_LIGHT6.Name = "securityControl_LIGHT6";
            this.securityControl_LIGHT6.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT6.TabIndex = 5;
            this.securityControl_LIGHT6.WIP = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.securityControl_DARK6);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 330);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(262, 33);
            this.panel16.TabIndex = 10;
            // 
            // securityControl_DARK6
            // 
            this.securityControl_DARK6.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK6.ButtonColor = System.Drawing.Color.Black;
            this.securityControl_DARK6.ButtonText = "WIP";
            this.securityControl_DARK6.Description = new string[] {
        "use mbrfilter as protection against rootkits",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK6.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK6.Name = "securityControl_DARK6";
            this.securityControl_DARK6.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK6.TabIndex = 5;
            this.securityControl_DARK6.WIP = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.securityControl_LIGHT5);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 297);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(262, 33);
            this.panel15.TabIndex = 9;
            // 
            // securityControl_LIGHT5
            // 
            this.securityControl_LIGHT5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT5.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT5.ButtonText = "run!";
            this.securityControl_LIGHT5.Description = new string[] {
        "remove bogus root certificates",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT5.Location = new System.Drawing.Point(0, 0);
            this.securityControl_LIGHT5.Name = "securityControl_LIGHT5";
            this.securityControl_LIGHT5.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT5.TabIndex = 4;
            this.securityControl_LIGHT5.WIP = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.securityControl_DARK5);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 264);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(262, 33);
            this.panel14.TabIndex = 8;
            // 
            // securityControl_DARK5
            // 
            this.securityControl_DARK5.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK5.ButtonColor = System.Drawing.Color.Black;
            this.securityControl_DARK5.ButtonText = "WIP";
            this.securityControl_DARK5.Description = new string[] {
        "disable insecure network services",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK5.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK5.Name = "securityControl_DARK5";
            this.securityControl_DARK5.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK5.TabIndex = 4;
            this.securityControl_DARK5.WIP = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.securityControl_LIGHT4);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 231);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(262, 33);
            this.panel13.TabIndex = 7;
            // 
            // securityControl_LIGHT4
            // 
            this.securityControl_LIGHT4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT4.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT4.ButtonText = "run!";
            this.securityControl_LIGHT4.Description = new string[] {
        "disable remote registry",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT4.Location = new System.Drawing.Point(0, 0);
            this.securityControl_LIGHT4.Name = "securityControl_LIGHT4";
            this.securityControl_LIGHT4.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT4.TabIndex = 3;
            this.securityControl_LIGHT4.WIP = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.securityControl_DARK4);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 198);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(262, 33);
            this.panel12.TabIndex = 6;
            // 
            // securityControl_DARK4
            // 
            this.securityControl_DARK4.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK4.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK4.ButtonText = "run!";
            this.securityControl_DARK4.Description = new string[] {
        "disable remote desktop protocol",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK4.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK4.Name = "securityControl_DARK4";
            this.securityControl_DARK4.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK4.TabIndex = 3;
            this.securityControl_DARK4.WIP = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.securityControl_LIGHT3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 165);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(262, 33);
            this.panel11.TabIndex = 5;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // securityControl_LIGHT3
            // 
            this.securityControl_LIGHT3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT3.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT3.ButtonText = "run!";
            this.securityControl_LIGHT3.Description = new string[] {
        "higher UAC",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT3.Location = new System.Drawing.Point(0, 0);
            this.securityControl_LIGHT3.Name = "securityControl_LIGHT3";
            this.securityControl_LIGHT3.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT3.TabIndex = 2;
            this.securityControl_LIGHT3.WIP = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.securityControl_DARK3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(262, 33);
            this.panel10.TabIndex = 4;
            // 
            // securityControl_DARK3
            // 
            this.securityControl_DARK3.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK3.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK3.ButtonText = "run!";
            this.securityControl_DARK3.Description = new string[] {
        "disable NTLM for ingoing and outgoing",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK3.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK3.Name = "securityControl_DARK3";
            this.securityControl_DARK3.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK3.TabIndex = 2;
            this.securityControl_DARK3.WIP = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.securityControl_LIGHT2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 99);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 33);
            this.panel9.TabIndex = 3;
            // 
            // securityControl_LIGHT2
            // 
            this.securityControl_LIGHT2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT2.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT2.ButtonText = "run!";
            this.securityControl_LIGHT2.Description = new string[] {
        "rename scripts to notepad",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT2.Location = new System.Drawing.Point(0, 0);
            this.securityControl_LIGHT2.Name = "securityControl_LIGHT2";
            this.securityControl_LIGHT2.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT2.TabIndex = 1;
            this.securityControl_LIGHT2.WIP = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.securityControl_DARK2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 33);
            this.panel8.TabIndex = 2;
            // 
            // securityControl_DARK2
            // 
            this.securityControl_DARK2.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK2.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK2.ButtonText = "run!";
            this.securityControl_DARK2.Description = new string[] {
        "disable wscript host",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK2.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK2.Name = "securityControl_DARK2";
            this.securityControl_DARK2.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK2.TabIndex = 1;
            this.securityControl_DARK2.WIP = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.securityControl_LIGHT1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 33);
            this.panel7.TabIndex = 1;
            // 
            // securityControl_LIGHT1
            // 
            this.securityControl_LIGHT1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.securityControl_LIGHT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_LIGHT1.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_LIGHT1.ButtonText = "run!";
            this.securityControl_LIGHT1.Description = new string[] {
        "disable netbios over ip.",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_LIGHT1.Location = new System.Drawing.Point(0, 1);
            this.securityControl_LIGHT1.Name = "securityControl_LIGHT1";
            this.securityControl_LIGHT1.Size = new System.Drawing.Size(262, 32);
            this.securityControl_LIGHT1.TabIndex = 0;
            this.securityControl_LIGHT1.WIP = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.securityControl_DARK1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 33);
            this.panel6.TabIndex = 0;
            // 
            // securityControl_DARK1
            // 
            this.securityControl_DARK1.BackColor = System.Drawing.Color.Gainsboro;
            this.securityControl_DARK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.securityControl_DARK1.ButtonColor = System.Drawing.Color.LightBlue;
            this.securityControl_DARK1.ButtonText = "run!";
            this.securityControl_DARK1.Description = new string[] {
        "protect known malware directories",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.securityControl_DARK1.Location = new System.Drawing.Point(0, 0);
            this.securityControl_DARK1.Name = "securityControl_DARK1";
            this.securityControl_DARK1.Size = new System.Drawing.Size(262, 32);
            this.securityControl_DARK1.TabIndex = 0;
            this.securityControl_DARK1.WIP = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flatButton5);
            this.panel3.Controls.Add(this.flatButton4);
            this.panel3.Controls.Add(this.flatButton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 608);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 54);
            this.panel3.TabIndex = 2;
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton5.ForeColor = System.Drawing.Color.White;
            this.flatButton5.Location = new System.Drawing.Point(439, 18);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Size = new System.Drawing.Size(75, 23);
            this.flatButton5.TabIndex = 2;
            this.flatButton5.Text = "undo all";
            this.flatButton5.UseVisualStyleBackColor = false;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton4.ForeColor = System.Drawing.Color.White;
            this.flatButton4.Location = new System.Drawing.Point(93, 18);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(124, 23);
            this.flatButton4.TabIndex = 1;
            this.flatButton4.Text = "Apply safe policies";
            this.flatButton4.UseVisualStyleBackColor = false;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton3.ForeColor = System.Drawing.Color.White;
            this.flatButton3.Location = new System.Drawing.Point(12, 18);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Size = new System.Drawing.Size(75, 23);
            this.flatButton3.TabIndex = 0;
            this.flatButton3.Text = "Apply All";
            this.flatButton3.UseVisualStyleBackColor = false;
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
            this.openOptionalOptionsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openOptionalOptionsToolStripMenuItem.Text = "Open Optional options";
            this.openOptionalOptionsToolStripMenuItem.Click += new System.EventHandler(this.openOptionalOptionsToolStripMenuItem_Click);
            // 
            // setAsServerToolStripMenuItem
            // 
            this.setAsServerToolStripMenuItem.Enabled = false;
            this.setAsServerToolStripMenuItem.Name = "setAsServerToolStripMenuItem";
            this.setAsServerToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.setAsServerToolStripMenuItem.Text = "set as server";
            // 
            // setAsClientToolStripMenuItem
            // 
            this.setAsClientToolStripMenuItem.Enabled = false;
            this.setAsClientToolStripMenuItem.Name = "setAsClientToolStripMenuItem";
            this.setAsClientToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.setAsClientToolStripMenuItem.Text = "set as client";
            // 
            // resetPoliciesToolStripMenuItem
            // 
            this.resetPoliciesToolStripMenuItem.Name = "resetPoliciesToolStripMenuItem";
            this.resetPoliciesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.resetPoliciesToolStripMenuItem.Text = "reset windows group policies";
            this.resetPoliciesToolStripMenuItem.Click += new System.EventHandler(this.resetPoliciesToolStripMenuItem_Click);
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
            this.boguscertbtn.Text = "Run!";
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
            this.llmnrprogress.Location = new System.Drawing.Point(11, 545);
            this.llmnrprogress.Name = "llmnrprogress";
            this.llmnrprogress.Size = new System.Drawing.Size(406, 23);
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
            // unsignedprogress
            // 
            this.unsignedprogress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unsignedprogress.Location = new System.Drawing.Point(10, 586);
            this.unsignedprogress.Name = "unsignedprogress";
            this.unsignedprogress.Size = new System.Drawing.Size(384, 23);
            this.unsignedprogress.TabIndex = 99;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.optionsToolStripMenuItem.Text = "options";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem1.Text = "help";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(507, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(489, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "_";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smbbtn);
            this.Controls.Add(this.smbprogress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unsignedbtn);
            this.Controls.Add(this.unsignedprogress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llmnrbtn);
            this.Controls.Add(this.llmnrprogress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.netsharebtn);
            this.Controls.Add(this.netshareprogress);
            this.Controls.Add(this.mbrfilterlabel);
            this.Controls.Add(this.mbrbtn);
            this.Controls.Add(this.mbrprogress);
            this.Controls.Add(this.boguscertlabel);
            this.Controls.Add(this.boguscertbtn);
            this.Controls.Add(this.boguscertprogress);
            this.Controls.Add(this.insecureserviceslabel);
            this.Controls.Add(this.insecureservicesbtn);
            this.Controls.Add(this.insecureserviceprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(526, 661);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Security Tweaker Tool 14.0.25420.1b (WSTT)";
            this.Load += new System.EventHandler(this.window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolTip tooltip;
        private Panel panel1;
        public Button NTLMbtn;
        public ProgressBar NTLMProgress;
        private Label label1;
        private Label label2;
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
        public ProgressBar boguscertprogress;
        private LinkLabel boguscertlabel;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel28;
        private Panel panel27;
        private Panel panel26;
        private Panel panel25;
        private Panel panel24;
        private Panel panel23;
        private Panel panel22;
        private Panel panel21;
        private Panel panel20;
        private Panel panel19;
        private Panel panel18;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel29;
        private Panel panel17;
        private Panel panel30;
        private FlatButton flatButton1;
        private Panel panel32;
        private Panel panel31;
        private FlatButton flatButton2;
        private SecurityControl_LIGHT securityControl_LIGHT1;
        private SecurityControl_DARK securityControl_DARK1;
        private SecurityControl_LIGHT securityControl_LIGHT12;
        private SecurityControl_DARK securityControl_DARK12;
        private SecurityControl_LIGHT securityControl_LIGHT11;
        private SecurityControl_DARK securityControl_DARK11;
        private SecurityControl_LIGHT securityControl_LIGHT10;
        private SecurityControl_DARK securityControl_DARK10;
        private SecurityControl_LIGHT securityControl_LIGHT9;
        private SecurityControl_DARK securityControl_DARK9;
        private SecurityControl_LIGHT securityControl_LIGHT8;
        private SecurityControl_DARK securityControl_DARK8;
        private SecurityControl_LIGHT securityControl_LIGHT7;
        private SecurityControl_DARK securityControl_DARK7;
        private SecurityControl_LIGHT securityControl_LIGHT6;
        private SecurityControl_DARK securityControl_DARK6;
        private SecurityControl_LIGHT securityControl_LIGHT5;
        private SecurityControl_DARK securityControl_DARK5;
        private SecurityControl_LIGHT securityControl_LIGHT4;
        private SecurityControl_DARK securityControl_DARK4;
        private SecurityControl_LIGHT securityControl_LIGHT3;
        private SecurityControl_DARK securityControl_DARK3;
        private SecurityControl_LIGHT securityControl_LIGHT2;
        private SecurityControl_DARK securityControl_DARK2;
        private FlatButton flatButton5;
        private FlatButton flatButton4;
        private FlatButton flatButton3;
        public Button netsharebtn;
        public ProgressBar netshareprogress;
        public Button llmnrbtn;
        public ProgressBar llmnrprogress;
        public ToolStripMenuItem openOptionalOptionsToolStripMenuItem;
        private Label label4;
        public Button unsignedbtn;
        public ProgressBar unsignedprogress;
        private ToolStripMenuItem resetPoliciesToolStripMenuItem;
        public ProgressBar insecureserviceprogress;
        public Button insecureservicesbtn;
        private Label label3;
        public Button smbbtn;
        public ProgressBar smbprogress;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private Label label5;
        private Label label6;
    }
}