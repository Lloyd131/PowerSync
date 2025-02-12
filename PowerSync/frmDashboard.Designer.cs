namespace PowerSync
{
    partial class frmDashboard
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
            panel7 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(27, 285);
            panel7.Name = "panel7";
            panel7.Size = new Size(1412, 436);
            panel7.TabIndex = 7;
            panel7.Paint += panel7_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label8.ForeColor = Color.White;
            label8.Location = new Point(611, 180);
            label8.Name = "label8";
            label8.Size = new Size(195, 27);
            label8.TabIndex = 0;
            label8.Text = "Graph goes here";
            label8.Click += label8_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(799, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(637, 224);
            panel6.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(128, 255, 255);
            label9.Location = new Point(107, 53);
            label9.Name = "label9";
            label9.Size = new Size(509, 106);
            label9.TabIndex = 1;
            label9.Text = "2 PM - 4 PM";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(171, 31);
            label10.TabIndex = 0;
            label10.Text = "Peak Hours:\r\n";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(27, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(637, 224);
            panel5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 180);
            label7.Name = "label7";
            label7.Size = new Size(226, 23);
            label7.TabIndex = 2;
            label7.Text = "Last Week: 1, 890 kWh\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 255, 255);
            label6.Location = new Point(124, 53);
            label6.Name = "label6";
            label6.Size = new Size(446, 106);
            label6.TabIndex = 1;
            label6.Text = "1,650 kWh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 8);
            label5.Name = "label5";
            label5.Size = new Size(356, 31);
            label5.TabIndex = 0;
            label5.Text = "This Week's Consumption:";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1465, 838);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label8;
        private Panel panel6;
        private Label label9;
        private Label label10;
        private Panel panel5;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}