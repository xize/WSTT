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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.netbiosbtn = new System.Windows.Forms.Button();
            this.netbiosprogress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.renamebtn = new System.Windows.Forms.Button();
            this.renameprogress = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.uac_btn = new System.Windows.Forms.Button();
            this.uac_progress = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.progressBar11 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.progressBar12 = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.progressBar14 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.progressBar15 = new System.Windows.Forms.ProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.progressBar16 = new System.Windows.Forms.ProgressBar();
            this.label17 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.progressBar17 = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.progressBar18 = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.progressBar19 = new System.Windows.Forms.ProgressBar();
            this.label20 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.progressBar20 = new System.Windows.Forms.ProgressBar();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.progressBar21 = new System.Windows.Forms.ProgressBar();
            this.progressBar13 = new System.Windows.Forms.ProgressBar();
            this.button13 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.label23 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.progressBar23 = new System.Windows.Forms.ProgressBar();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // temp_policy_load
            // 
            this.temp_policy_load.Location = new System.Drawing.Point(12, 23);
            this.temp_policy_load.Name = "temp_policy_load";
            this.temp_policy_load.Size = new System.Drawing.Size(438, 23);
            this.temp_policy_load.TabIndex = 0;
            this.temp_policy_load.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // temp_policy_btn
            // 
            this.temp_policy_btn.Location = new System.Drawing.Point(456, 23);
            this.temp_policy_btn.Name = "temp_policy_btn";
            this.temp_policy_btn.Size = new System.Drawing.Size(75, 23);
            this.temp_policy_btn.TabIndex = 1;
            this.temp_policy_btn.Text = "Apply";
            this.temp_policy_btn.UseVisualStyleBackColor = true;
            this.temp_policy_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // wscript_btn
            // 
            this.wscript_btn.Location = new System.Drawing.Point(456, 105);
            this.wscript_btn.Name = "wscript_btn";
            this.wscript_btn.Size = new System.Drawing.Size(75, 23);
            this.wscript_btn.TabIndex = 7;
            this.wscript_btn.Text = "Apply";
            this.wscript_btn.UseVisualStyleBackColor = true;
            this.wscript_btn.Click += new System.EventHandler(this.wscript_btn_Click);
            // 
            // wscript_progress
            // 
            this.wscript_progress.Location = new System.Drawing.Point(12, 105);
            this.wscript_progress.Name = "wscript_progress";
            this.wscript_progress.Size = new System.Drawing.Size(438, 23);
            this.wscript_progress.TabIndex = 6;
            this.wscript_progress.Click += new System.EventHandler(this.wscript_progress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "protect known malware directories (policies, needs windows ultimate) (macro):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "disable netbios over ip to protect against network viruses:";
            // 
            // netbiosbtn
            // 
            this.netbiosbtn.Location = new System.Drawing.Point(456, 64);
            this.netbiosbtn.Name = "netbiosbtn";
            this.netbiosbtn.Size = new System.Drawing.Size(75, 23);
            this.netbiosbtn.TabIndex = 4;
            this.netbiosbtn.Text = "Apply";
            this.netbiosbtn.UseVisualStyleBackColor = true;
            this.netbiosbtn.Click += new System.EventHandler(this.netbiosbtn_Click);
            // 
            // netbiosprogress
            // 
            this.netbiosprogress.Location = new System.Drawing.Point(12, 64);
            this.netbiosprogress.Name = "netbiosprogress";
            this.netbiosprogress.Size = new System.Drawing.Size(438, 23);
            this.netbiosprogress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "disable wscript so that vbs scripts cannot run:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "change the default extension of scripts to notepad to fight browser payloads:";
            // 
            // renamebtn
            // 
            this.renamebtn.Location = new System.Drawing.Point(456, 146);
            this.renamebtn.Name = "renamebtn";
            this.renamebtn.Size = new System.Drawing.Size(75, 23);
            this.renamebtn.TabIndex = 10;
            this.renamebtn.Text = "Apply";
            this.renamebtn.UseVisualStyleBackColor = true;
            this.renamebtn.Click += new System.EventHandler(this.renamebtn_Click);
            // 
            // renameprogress
            // 
            this.renameprogress.Location = new System.Drawing.Point(12, 146);
            this.renameprogress.Name = "renameprogress";
            this.renameprogress.Size = new System.Drawing.Size(438, 23);
            this.renameprogress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "restrict access to powershell for both syswow64 and system32:";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(453, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Apply";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // progressBar5
            // 
            this.progressBar5.Enabled = false;
            this.progressBar5.Location = new System.Drawing.Point(9, 187);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(441, 23);
            this.progressBar5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "disable windows driver update framework:";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(453, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // progressBar6
            // 
            this.progressBar6.Enabled = false;
            this.progressBar6.Location = new System.Drawing.Point(9, 228);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(441, 23);
            this.progressBar6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "remove default extension from pif files so they can\'t hide extensions:";
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(453, 269);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Apply";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // progressBar7
            // 
            this.progressBar7.Enabled = false;
            this.progressBar7.Location = new System.Drawing.Point(9, 269);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(441, 23);
            this.progressBar7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "higher security from \"User account control\" (macro):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // uac_btn
            // 
            this.uac_btn.Location = new System.Drawing.Point(453, 311);
            this.uac_btn.Name = "uac_btn";
            this.uac_btn.Size = new System.Drawing.Size(75, 23);
            this.uac_btn.TabIndex = 22;
            this.uac_btn.Text = "Apply";
            this.uac_btn.UseVisualStyleBackColor = true;
            this.uac_btn.Click += new System.EventHandler(this.uac_btn_Click);
            // 
            // uac_progress
            // 
            this.uac_progress.Location = new System.Drawing.Point(9, 311);
            this.uac_progress.Name = "uac_progress";
            this.uac_progress.Size = new System.Drawing.Size(441, 23);
            this.uac_progress.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "disable remote desktop protocol:";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(453, 352);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 28;
            this.button10.Text = "Apply";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // progressBar10
            // 
            this.progressBar10.Enabled = false;
            this.progressBar10.Location = new System.Drawing.Point(9, 352);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(441, 23);
            this.progressBar10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "disable remote registry:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(453, 394);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 31;
            this.button11.Text = "Apply";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // progressBar11
            // 
            this.progressBar11.Enabled = false;
            this.progressBar11.Location = new System.Drawing.Point(9, 394);
            this.progressBar11.Name = "progressBar11";
            this.progressBar11.Size = new System.Drawing.Size(441, 23);
            this.progressBar11.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "disable unintended upgrades from windows update:";
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(453, 436);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 34;
            this.button12.Text = "Apply";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // progressBar12
            // 
            this.progressBar12.Enabled = false;
            this.progressBar12.Location = new System.Drawing.Point(9, 436);
            this.progressBar12.Name = "progressBar12";
            this.progressBar12.Size = new System.Drawing.Size(441, 23);
            this.progressBar12.TabIndex = 33;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button14.Location = new System.Drawing.Point(9, 553);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 39;
            this.button14.Text = "Apply all";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.Location = new System.Drawing.Point(90, 553);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 40;
            this.button15.Text = "Undo all";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(537, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "install Malwarebytes Anti Exploit:";
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Enabled = false;
            this.button16.Location = new System.Drawing.Point(853, 25);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 42;
            this.button16.Text = "Apply";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // progressBar14
            // 
            this.progressBar14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar14.Enabled = false;
            this.progressBar14.Location = new System.Drawing.Point(537, 25);
            this.progressBar14.Name = "progressBar14";
            this.progressBar14.Size = new System.Drawing.Size(313, 23);
            this.progressBar14.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(537, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(314, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "install herdprotect (manual scan with over 64 virus scan engines):";
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(853, 107);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 45;
            this.button17.Text = "Apply";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // progressBar15
            // 
            this.progressBar15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar15.Enabled = false;
            this.progressBar15.Location = new System.Drawing.Point(537, 107);
            this.progressBar15.Name = "progressBar15";
            this.progressBar15.Size = new System.Drawing.Size(313, 23);
            this.progressBar15.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(537, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(237, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "install Malwarebytes Anti Malware (manual scan):";
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Enabled = false;
            this.button18.Location = new System.Drawing.Point(853, 66);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 48;
            this.button18.Text = "Apply";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // progressBar16
            // 
            this.progressBar16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar16.Enabled = false;
            this.progressBar16.Location = new System.Drawing.Point(537, 66);
            this.progressBar16.Name = "progressBar16";
            this.progressBar16.Size = new System.Drawing.Size(313, 23);
            this.progressBar16.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(537, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(238, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "install adw cleaner as junkware removal scanner:";
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Enabled = false;
            this.button19.Location = new System.Drawing.Point(853, 146);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 51;
            this.button19.Text = "Apply";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // progressBar17
            // 
            this.progressBar17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar17.Enabled = false;
            this.progressBar17.Location = new System.Drawing.Point(537, 146);
            this.progressBar17.Name = "progressBar17";
            this.progressBar17.Size = new System.Drawing.Size(313, 23);
            this.progressBar17.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(537, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(377, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Install Avira (Anti virus) (Note: do not install this on machines with amd driver" +
    "s!):";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Enabled = false;
            this.button20.Location = new System.Drawing.Point(853, 188);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 54;
            this.button20.Text = "Apply";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // progressBar18
            // 
            this.progressBar18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar18.Enabled = false;
            this.progressBar18.Location = new System.Drawing.Point(537, 188);
            this.progressBar18.Name = "progressBar18";
            this.progressBar18.Size = new System.Drawing.Size(313, 23);
            this.progressBar18.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(534, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "install firefox with security addons:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(850, 229);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 57;
            this.button21.Text = "Apply";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // progressBar19
            // 
            this.progressBar19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar19.Enabled = false;
            this.progressBar19.Location = new System.Drawing.Point(534, 229);
            this.progressBar19.Name = "progressBar19";
            this.progressBar19.Size = new System.Drawing.Size(313, 23);
            this.progressBar19.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(534, 299);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "install glasswire firewall:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Enabled = false;
            this.button22.Location = new System.Drawing.Point(850, 315);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 60;
            this.button22.Text = "Apply";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // progressBar20
            // 
            this.progressBar20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar20.Enabled = false;
            this.progressBar20.Location = new System.Drawing.Point(534, 315);
            this.progressBar20.Name = "progressBar20";
            this.progressBar20.Size = new System.Drawing.Size(313, 23);
            this.progressBar20.TabIndex = 59;
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.Location = new System.Drawing.Point(414, 553);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(252, 23);
            this.button23.TabIndex = 62;
            this.button23.Text = "do tweaks without installing third party programs";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(672, 553);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(256, 23);
            this.button24.TabIndex = 63;
            this.button24.Text = "undo tweaks without removing third party programs";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Location = new System.Drawing.Point(534, 340);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "install peerblock to block bad people:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.Enabled = false;
            this.button25.Location = new System.Drawing.Point(850, 356);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 65;
            this.button25.Text = "Apply";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // progressBar21
            // 
            this.progressBar21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar21.Enabled = false;
            this.progressBar21.Location = new System.Drawing.Point(534, 356);
            this.progressBar21.Name = "progressBar21";
            this.progressBar21.Size = new System.Drawing.Size(313, 23);
            this.progressBar21.TabIndex = 64;
            // 
            // progressBar13
            // 
            this.progressBar13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar13.Enabled = false;
            this.progressBar13.Location = new System.Drawing.Point(9, 477);
            this.progressBar13.Name = "progressBar13";
            this.progressBar13.Size = new System.Drawing.Size(441, 23);
            this.progressBar13.TabIndex = 36;
            this.progressBar13.Click += new System.EventHandler(this.progressBar13_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(453, 478);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 37;
            this.button13.Text = "Apply";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "check for bogus root certificates by using sigcheck:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(534, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "install google chrome with security addons:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(850, 270);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 71;
            this.button9.Text = "Apply";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // progressBar9
            // 
            this.progressBar9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar9.Enabled = false;
            this.progressBar9.Location = new System.Drawing.Point(534, 270);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(313, 23);
            this.progressBar9.TabIndex = 70;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(534, 383);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(163, 13);
            this.label23.TabIndex = 75;
            this.label23.Text = "install Keepass (as Administrator):";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button27
            // 
            this.button27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button27.Enabled = false;
            this.button27.Location = new System.Drawing.Point(850, 399);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 74;
            this.button27.Text = "Apply";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // progressBar23
            // 
            this.progressBar23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar23.Enabled = false;
            this.progressBar23.Location = new System.Drawing.Point(534, 399);
            this.progressBar23.Name = "progressBar23";
            this.progressBar23.Size = new System.Drawing.Size(313, 23);
            this.progressBar23.TabIndex = 73;
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(938, 584);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.progressBar23);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.progressBar9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.progressBar21);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.progressBar20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.progressBar19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.progressBar18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.progressBar17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.progressBar16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.progressBar15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.progressBar14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.progressBar13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.progressBar12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.progressBar11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.progressBar10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uac_btn);
            this.Controls.Add(this.uac_progress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progressBar5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Tweaker Tool 1.0b (WTT) - nuke the planet with security";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button uac_btn;
        public System.Windows.Forms.ProgressBar uac_progress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ProgressBar progressBar11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ProgressBar progressBar12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ProgressBar progressBar14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ProgressBar progressBar15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ProgressBar progressBar16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ProgressBar progressBar17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ProgressBar progressBar18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ProgressBar progressBar19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ProgressBar progressBar20;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.ProgressBar progressBar21;
        private System.Windows.Forms.ProgressBar progressBar13;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.ProgressBar progressBar23;
        private ToolTip tooltip;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}

