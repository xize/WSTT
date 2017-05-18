namespace windows_security_tweak_tool.src.controls
{
    partial class SecurityControl_DARK
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
            this.label1 = new System.Windows.Forms.Label();
            this.flatButton1 = new windows_security_tweak_tool.src.controls.FlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "some text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.LightBlue;
            this.flatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(219, 0);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(53, 32);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "run!";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // SecurityControl_DARK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flatButton1);
            this.Name = "SecurityControl_DARK";
            this.Size = new System.Drawing.Size(272, 32);
            this.Load += new System.EventHandler(this.SecurityControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlatButton flatButton1;
        private System.Windows.Forms.Label label1;
    }
}
