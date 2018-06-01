namespace windows_security_tweak_tool.src.controls
{
    partial class DescriptionProgressBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 18);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Dock = System.Windows.Forms.DockStyle.Right;
            this.b.Font = new System.Drawing.Font("Verdana", 8F);
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.b.Location = new System.Drawing.Point(413, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(15, 38);
            this.b.TabIndex = 2;
            this.b.UseVisualStyleBackColor = false;
            this.b.Visible = false;
            // 
            // DescriptionProgressBar
            // 
            this.BackgroundImage = global::windows_security_tweak_tool.Properties.Resources.progressbar_bg;
            this.Controls.Add(this.b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.MaximumSize = new System.Drawing.Size(428, 56);
            this.Name = "DescriptionProgressBar";
            this.Size = new System.Drawing.Size(428, 56);
            this.Load += new System.EventHandler(this.DescriptionProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox b;
    }
}
