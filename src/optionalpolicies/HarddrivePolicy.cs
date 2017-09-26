/*
    A security toolkit for windows    

    Copyright(C) 2016-2017 Guido Lucassen

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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.Properties;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class HarddrivePolicy : OptionalPolicy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.HARD_DRIVE_POLICY;
        }

        public override string getDescription()
        {
            return "fixes a issue inside windows 10 where SSD and sata harddrives are being treated as \"safe removal device\"";
        }

        public override void apply()
        {
           DialogResult dialog = MessageBox.Show("this option is only compatible for windows 10 hosts.\nthis will patch an issue related were harddrives are being treated as safe pluggable removal devices\n\npress OK to continue and cancel to abort this patch", "This option is only compatible for windows 10 users!", MessageBoxButtons.OKCancel);
            if(dialog == DialogResult.Cancel)
            {
                return;
            }

            DriveWindow window = new DriveWindow();
            window.Show();

        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }

        public override Button getButton()
        {
            return gui.harddrivebtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.harddriveprogress;
        }
    }

    public class DriveWindow : Form
    {
        public DriveWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Width = 400;
            this.Height = 180;
            this.Text = "Please write how many drives your pc has:";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            this.p1 = new Panel();
            this.label = new Label();
            this.label.Text = "set the amount of drives: ";
            this.number = new NumericUpDown();

            p1.Controls.Add(label);
            p1.Controls.Add(number);

            this.Controls.Add(p1);

            this.SuspendLayout();
            this.ResumeLayout();
        }

        private Panel p1;
        public Label label;
        public NumericUpDown number;
    }

}
