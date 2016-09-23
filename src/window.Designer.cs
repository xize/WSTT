using System;
using System.Reflection;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.netbiosbtn = new System.Windows.Forms.Button();
            this.netbiosprogress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.renamebtn = new System.Windows.Forms.Button();
            this.renameprogress = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.uac_btn = new System.Windows.Forms.Button();
            this.uac_progress = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.rdpbtn = new System.Windows.Forms.Button();
            this.rdpprogress = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.remoteregbtn = new System.Windows.Forms.Button();
            this.remoteregprogress = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
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
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
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
            this.temp_policy_load.Click += new System.EventHandler(this.progressBar1_Click);
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
            this.temp_policy_btn.Click += new System.EventHandler(this.button1_Click);
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
            this.wscript_btn.Click += new System.EventHandler(this.wscript_btn_Click);
            // 
            // wscript_progress
            // 
            this.wscript_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wscript_progress.Location = new System.Drawing.Point(12, 126);
            this.wscript_progress.Name = "wscript_progress";
            this.wscript_progress.Size = new System.Drawing.Size(403, 23);
            this.wscript_progress.TabIndex = 6;
            this.wscript_progress.Click += new System.EventHandler(this.wscript_progress_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "protect known malware directories (policies, needs windows ultimate) (macro):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "disable netbios over ip to protect against network viruses:";
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
            this.netbiosbtn.Click += new System.EventHandler(this.netbiosbtn_Click);
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "disable wscript so that vbs scripts cannot run:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "change the default extension of scripts to notepad to fight browser payloads:";
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
            this.renamebtn.Click += new System.EventHandler(this.renamebtn_Click);
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "higher security from \"User account control\" (macro):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.uac_btn.Click += new System.EventHandler(this.uac_btn_Click);
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "disable remote desktop protocol:";
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
            this.rdpbtn.Click += new System.EventHandler(this.rdpbtn_Click);
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
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "disable remote registry:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            this.remoteregbtn.Click += new System.EventHandler(this.remoteregbtn_Click);
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
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button14.Location = new System.Drawing.Point(9, 720);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 39;
            this.button14.Text = "Apply all";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.Location = new System.Drawing.Point(90, 720);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 40;
            this.button15.Text = "Undo all";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "disable NTLM inbound and outbound policies (macro):";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(420, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(11, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox17);
            this.panel1.Controls.Add(this.checkBox16);
            this.panel1.Controls.Add(this.checkBox15);
            this.panel1.Controls.Add(this.checkBox14);
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(9, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 117);
            this.panel1.TabIndex = 68;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1, -1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(306, 13);
            this.linkLabel1.TabIndex = 79;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ninite installer (for more programs visit https://www.ninite.com/):";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(222, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Select all";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(303, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Install programs with Ninite!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Enabled = false;
            this.checkBox17.Location = new System.Drawing.Point(95, 91);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(50, 17);
            this.checkBox17.TabIndex = 18;
            this.checkBox17.Text = "Putty";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Enabled = false;
            this.checkBox16.Location = new System.Drawing.Point(2, 91);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(66, 17);
            this.checkBox16.TabIndex = 17;
            this.checkBox16.Text = "WinSCP";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Enabled = false;
            this.checkBox15.Location = new System.Drawing.Point(389, 68);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(79, 17);
            this.checkBox15.TabIndex = 16;
            this.checkBox15.Text = "Notepad++";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Enabled = false;
            this.checkBox14.Location = new System.Drawing.Point(303, 68);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(61, 17);
            this.checkBox14.TabIndex = 15;
            this.checkBox14.Text = "FileZilla";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Enabled = false;
            this.checkBox13.Location = new System.Drawing.Point(214, 68);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(68, 17);
            this.checkBox13.TabIndex = 14;
            this.checkBox13.Text = "WinRAR";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Location = new System.Drawing.Point(95, 68);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(48, 17);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "7-zip";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Enabled = false;
            this.checkBox12.Location = new System.Drawing.Point(3, 68);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(84, 17);
            this.checkBox12.TabIndex = 12;
            this.checkBox12.Text = "Classic Start";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Location = new System.Drawing.Point(389, 45);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(65, 17);
            this.checkBox11.TabIndex = 11;
            this.checkBox11.Text = "ImgBurn";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Location = new System.Drawing.Point(303, 45);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(88, 17);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Google Drive";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(214, 45);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(66, 17);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "Dropbox";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(95, 45);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(91, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Malwarebytes";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(3, 45);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Essentials";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(389, 22);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Spotify";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(305, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "VLC Player";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(214, 22);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Itunes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(95, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Thunderbird";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(3, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Skype";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "optional options:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Install Keepass as Administrator:";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(418, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 71;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(9, 555);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(406, 23);
            this.progressBar2.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(369, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Google Chrome 64 bit (Work/Bussiness Edition) with extra hardened security:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSize = true;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(418, 597);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 74;
            this.button5.Text = "Apply";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Enabled = false;
            this.progressBar3.Location = new System.Drawing.Point(9, 597);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(406, 23);
            this.progressBar3.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 623);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Install safety addons into chrome:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSize = true;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(418, 639);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 77;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar4.Enabled = false;
            this.progressBar4.Location = new System.Drawing.Point(9, 639);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(406, 23);
            this.progressBar4.TabIndex = 76;
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
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "disable insecure network services:";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.AutoSize = true;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(418, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 81;
            this.button7.Text = "Apply";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // progressBar5
            // 
            this.progressBar5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar5.Enabled = false;
            this.progressBar5.Location = new System.Drawing.Point(9, 377);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(406, 23);
            this.progressBar5.TabIndex = 80;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 685);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 83;
            this.textBox1.Text = "youremail@example.com";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(337, 682);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 84;
            this.button8.Text = "check";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(418, 682);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 85;
            this.button9.Text = "remove me";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 665);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(355, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "I\'m I compromised on leakedsource.com password list?: (status: unknown)";
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(256, 682);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 87;
            this.button11.Text = "view";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 757);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.remoteregbtn);
            this.Controls.Add(this.remoteregprogress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rdpbtn);
            this.Controls.Add(this.rdpprogress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uac_btn);
            this.Controls.Add(this.uac_progress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.renamebtn);
            this.Controls.Add(this.renameprogress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wscript_btn);
            this.Controls.Add(this.wscript_progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.netbiosbtn);
            this.Controls.Add(this.netbiosprogress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp_policy_btn);
            this.Controls.Add(this.temp_policy_load);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(526, 684);
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = string.Format("Windows Security Tweaker Tool {0}b (WSTT) ", Application.ProductVersion);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button netbiosbtn;
        public System.Windows.Forms.ProgressBar netbiosprogress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button renamebtn;
        public System.Windows.Forms.ProgressBar renameprogress;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button uac_btn;
        public System.Windows.Forms.ProgressBar uac_progress;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button rdpbtn;
        public System.Windows.Forms.ProgressBar rdpprogress;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button remoteregbtn;
        public System.Windows.Forms.ProgressBar remoteregprogress;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private ToolTip tooltip;
        private Label label5;
        public Button button1;
        public ProgressBar progressBar1;
        private Panel panel1;
        private CheckBox checkBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox9;
        private CheckBox checkBox13;
        private CheckBox checkBox10;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private Button button3;
        private Button button2;
        private Label label6;
        private Label label9;
        private Button button4;
        private ProgressBar progressBar2;
        private Label label12;
        private Button button5;
        private ProgressBar progressBar3;
        private Label label13;
        private Button button6;
        private ProgressBar progressBar4;
        private LinkLabel linkLabel1;
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
        private Label label7;
        private Button button7;
        private ProgressBar progressBar5;
        private TextBox textBox1;
        private Button button8;
        private Button button9;
        private Label label14;
        private Button button11;
        private ToolTip toolTip2;
    }
}

