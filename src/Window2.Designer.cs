namespace windows_security_tweak_tool.src
{
    partial class Window2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window2));
            this.filesmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openOptionalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardResetWindowsGroupPoliciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.banner = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.helpbtn = new System.Windows.Forms.Panel();
            this.settingbtn = new System.Windows.Forms.Panel();
            this.filebtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Label();
            this.minimizebtn = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bannertext = new windows_security_tweak_tool.src.controls.TransparantRichTextBox();
            this.filesmenustrip.SuspendLayout();
            this.settingsmenustrip.SuspendLayout();
            this.helpmenustrip.SuspendLayout();
            this.banner.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesmenustrip
            // 
            this.filesmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.filesmenustrip.Name = "contextMenuStrip1";
            this.filesmenustrip.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsmenustrip
            // 
            this.settingsmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOptionalOptionsToolStripMenuItem,
            this.setAsServerToolStripMenuItem,
            this.setAsClientToolStripMenuItem,
            this.hardResetWindowsGroupPoliciesToolStripMenuItem});
            this.settingsmenustrip.Name = "settingsmenustrip";
            this.settingsmenustrip.Size = new System.Drawing.Size(257, 92);
            // 
            // openOptionalOptionsToolStripMenuItem
            // 
            this.openOptionalOptionsToolStripMenuItem.Name = "openOptionalOptionsToolStripMenuItem";
            this.openOptionalOptionsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.openOptionalOptionsToolStripMenuItem.Text = "Open Optional Options";
            // 
            // setAsServerToolStripMenuItem
            // 
            this.setAsServerToolStripMenuItem.Enabled = false;
            this.setAsServerToolStripMenuItem.Name = "setAsServerToolStripMenuItem";
            this.setAsServerToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.setAsServerToolStripMenuItem.Text = "Set as server";
            // 
            // setAsClientToolStripMenuItem
            // 
            this.setAsClientToolStripMenuItem.Enabled = false;
            this.setAsClientToolStripMenuItem.Name = "setAsClientToolStripMenuItem";
            this.setAsClientToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.setAsClientToolStripMenuItem.Text = "Set as client";
            // 
            // hardResetWindowsGroupPoliciesToolStripMenuItem
            // 
            this.hardResetWindowsGroupPoliciesToolStripMenuItem.Name = "hardResetWindowsGroupPoliciesToolStripMenuItem";
            this.hardResetWindowsGroupPoliciesToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.hardResetWindowsGroupPoliciesToolStripMenuItem.Text = "Hard reset windows group policies";
            // 
            // helpmenustrip
            // 
            this.helpmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.helpmenustrip.Name = "helpmenustrip";
            this.helpmenustrip.Size = new System.Drawing.Size(157, 48);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Enabled = false;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.documentationToolStripMenuItem.Text = "documentation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.contentbar;
            this.panel4.Location = new System.Drawing.Point(10, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 23);
            this.panel4.TabIndex = 4;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.header;
            this.banner.Controls.Add(this.bannertext);
            this.banner.Location = new System.Drawing.Point(0, 57);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(526, 87);
            this.banner.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.wstt_context_bg;
            this.panel3.Controls.Add(this.helpbtn);
            this.panel3.Controls.Add(this.settingbtn);
            this.panel3.Controls.Add(this.filebtn);
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 22);
            this.panel3.TabIndex = 1;
            // 
            // helpbtn
            // 
            this.helpbtn.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.helpbtn;
            this.helpbtn.Location = new System.Drawing.Point(190, 0);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(42, 22);
            this.helpbtn.TabIndex = 4;
            // 
            // settingbtn
            // 
            this.settingbtn.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.settingsbtn;
            this.settingbtn.Location = new System.Drawing.Point(114, 0);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(70, 22);
            this.settingbtn.TabIndex = 3;
            this.settingbtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // filebtn
            // 
            this.filebtn.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.filebtn;
            this.filebtn.Location = new System.Drawing.Point(67, 0);
            this.filebtn.Name = "filebtn";
            this.filebtn.Size = new System.Drawing.Size(42, 22);
            this.filebtn.TabIndex = 2;
            this.filebtn.Paint += new System.Windows.Forms.PaintEventHandler(this.filebtn_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.wstt_title_saved;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Controls.Add(this.minimizebtn);
            this.panel2.Location = new System.Drawing.Point(477, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 35);
            this.panel2.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.AutoSize = true;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.closebtn.Location = new System.Drawing.Point(31, 9);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(15, 13);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "X";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebtn.AutoSize = true;
            this.minimizebtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.minimizebtn.Location = new System.Drawing.Point(10, 9);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(15, 13);
            this.minimizebtn.TabIndex = 0;
            this.minimizebtn.Text = "_";
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel5.Location = new System.Drawing.Point(10, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 638);
            this.panel5.TabIndex = 5;
            // 
            // bannertext
            // 
            this.bannertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannertext.Cursor = System.Windows.Forms.Cursors.Default;
            this.bannertext.Font = new System.Drawing.Font("Verdana", 10F);
            this.bannertext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bannertext.Location = new System.Drawing.Point(114, 3);
            this.bannertext.Name = "bannertext";
            this.bannertext.ReadOnly = true;
            this.bannertext.Size = new System.Drawing.Size(288, 81);
            this.bannertext.TabIndex = 0;
            this.bannertext.Text = "test";
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 838);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(526, 838);
            this.MinimumSize = new System.Drawing.Size(526, 838);
            this.Name = "Window2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window2";
            this.Load += new System.EventHandler(this.Window2_Load);
            this.filesmenustrip.ResumeLayout(false);
            this.settingsmenustrip.ResumeLayout(false);
            this.helpmenustrip.ResumeLayout(false);
            this.banner.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label minimizebtn;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel filebtn;
        private System.Windows.Forms.ContextMenuStrip filesmenustrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel settingbtn;
        private System.Windows.Forms.ContextMenuStrip settingsmenustrip;
        private System.Windows.Forms.ToolStripMenuItem openOptionalOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardResetWindowsGroupPoliciesToolStripMenuItem;
        private System.Windows.Forms.Panel helpbtn;
        private System.Windows.Forms.ContextMenuStrip helpmenustrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.Panel banner;
        private controls.TransparantRichTextBox bannertext;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}