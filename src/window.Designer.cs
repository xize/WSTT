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
            this.label8 = new System.Windows.Forms.Label();
            this.uac_btn = new System.Windows.Forms.Button();
            this.uac_progress = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.progressBar11 = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // temp_policy_load
            // 
            this.temp_policy_load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_policy_load.Location = new System.Drawing.Point(12, 23);
            this.temp_policy_load.Name = "temp_policy_load";
            this.temp_policy_load.Size = new System.Drawing.Size(403, 23);
            this.temp_policy_load.TabIndex = 0;
            this.temp_policy_load.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // temp_policy_btn
            // 
            this.temp_policy_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temp_policy_btn.AutoSize = true;
            this.temp_policy_btn.Location = new System.Drawing.Point(421, 23);
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
            this.wscript_btn.Location = new System.Drawing.Point(421, 105);
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
            this.wscript_progress.Location = new System.Drawing.Point(12, 105);
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
            this.label1.Location = new System.Drawing.Point(12, 7);
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
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "disable netbios over ip to protect against network viruses:";
            // 
            // netbiosbtn
            // 
            this.netbiosbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.netbiosbtn.AutoSize = true;
            this.netbiosbtn.Location = new System.Drawing.Point(421, 64);
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
            this.netbiosprogress.Location = new System.Drawing.Point(12, 64);
            this.netbiosprogress.Name = "netbiosprogress";
            this.netbiosprogress.Size = new System.Drawing.Size(403, 23);
            this.netbiosprogress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "change the default extension of scripts to notepad to fight browser payloads:";
            // 
            // renamebtn
            // 
            this.renamebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renamebtn.AutoSize = true;
            this.renamebtn.Location = new System.Drawing.Point(421, 146);
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
            this.renameprogress.Location = new System.Drawing.Point(12, 146);
            this.renameprogress.Name = "renameprogress";
            this.renameprogress.Size = new System.Drawing.Size(403, 23);
            this.renameprogress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 214);
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
            this.uac_btn.Location = new System.Drawing.Point(418, 230);
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
            this.uac_progress.Location = new System.Drawing.Point(9, 230);
            this.uac_progress.Name = "uac_progress";
            this.uac_progress.Size = new System.Drawing.Size(406, 23);
            this.uac_progress.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "disable remote desktop protocol:";
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.AutoSize = true;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(418, 272);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 28;
            this.button10.Text = "Apply";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // progressBar10
            // 
            this.progressBar10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar10.Enabled = false;
            this.progressBar10.Location = new System.Drawing.Point(9, 272);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(406, 23);
            this.progressBar10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "disable remote registry:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.AutoSize = true;
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(418, 314);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 31;
            this.button11.Text = "Apply";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // progressBar11
            // 
            this.progressBar11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar11.Enabled = false;
            this.progressBar11.Location = new System.Drawing.Point(9, 314);
            this.progressBar11.Name = "progressBar11";
            this.progressBar11.Size = new System.Drawing.Size(406, 23);
            this.progressBar11.TabIndex = 30;
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 172);
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
            this.button1.Location = new System.Drawing.Point(420, 188);
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
            this.progressBar1.Location = new System.Drawing.Point(11, 188);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "disable remote registry:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(418, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Enabled = false;
            this.progressBar2.Location = new System.Drawing.Point(9, 356);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(406, 23);
            this.progressBar2.TabIndex = 67;
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 584);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.progressBar11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.progressBar10);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(526, 623);
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Tweaker Tool 1.0b (WTT) - nuke the planet with security";
            this.Load += new System.EventHandler(this.window_Load);
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
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ProgressBar progressBar11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private ToolTip tooltip;
        private Label label5;
        public Button button1;
        public ProgressBar progressBar1;
        private Label label6;
        private Button button2;
        private ProgressBar progressBar2;
    }
}

