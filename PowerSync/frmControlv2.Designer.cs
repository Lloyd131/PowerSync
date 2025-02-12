namespace PowerSync
{
    partial class frmControlv2
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
            panel1 = new Panel();
            panel2 = new Panel();
            bldgC = new Button();
            bldgB = new Button();
            bldgA = new Button();
            ttbdo = new Button();
            panel3 = new Panel();
            label1 = new Label();
            ctrlpnlFormLoaderv2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 30, 54);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 838);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(bldgC);
            panel2.Controls.Add(bldgB);
            panel2.Controls.Add(bldgA);
            panel2.Controls.Add(ttbdo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 695);
            panel2.TabIndex = 3;
            // 
            // bldgC
            // 
            bldgC.BackColor = Color.FromArgb(46, 51, 73);
            bldgC.FlatAppearance.BorderSize = 0;
            bldgC.FlatStyle = FlatStyle.Flat;
            bldgC.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bldgC.ForeColor = Color.White;
            bldgC.Location = new Point(5, 339);
            bldgC.Name = "bldgC";
            bldgC.Size = new Size(166, 60);
            bldgC.TabIndex = 6;
            bldgC.Text = "Bldg C";
            bldgC.UseVisualStyleBackColor = false;
            bldgC.Click += bldgC_Click;
            bldgC.Leave += bldgC_Leave;
            // 
            // bldgB
            // 
            bldgB.BackColor = Color.FromArgb(46, 51, 73);
            bldgB.FlatAppearance.BorderSize = 0;
            bldgB.FlatStyle = FlatStyle.Flat;
            bldgB.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bldgB.ForeColor = Color.White;
            bldgB.Location = new Point(5, 227);
            bldgB.Name = "bldgB";
            bldgB.Size = new Size(166, 60);
            bldgB.TabIndex = 5;
            bldgB.Text = "Bldg B";
            bldgB.UseVisualStyleBackColor = false;
            bldgB.Click += bldgB_Click;
            bldgB.Leave += bldgB_Leave;
            // 
            // bldgA
            // 
            bldgA.BackColor = Color.FromArgb(46, 51, 73);
            bldgA.FlatAppearance.BorderSize = 0;
            bldgA.FlatStyle = FlatStyle.Flat;
            bldgA.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bldgA.ForeColor = Color.White;
            bldgA.Location = new Point(9, 119);
            bldgA.Name = "bldgA";
            bldgA.Size = new Size(166, 60);
            bldgA.TabIndex = 4;
            bldgA.Text = "Bldg A";
            bldgA.UseVisualStyleBackColor = false;
            bldgA.Click += bldgA_Click;
            bldgA.Leave += bldgA_Leave;
            // 
            // ttbdo
            // 
            ttbdo.BackColor = Color.FromArgb(46, 51, 73);
            ttbdo.FlatAppearance.BorderSize = 0;
            ttbdo.FlatStyle = FlatStyle.Flat;
            ttbdo.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttbdo.ForeColor = Color.White;
            ttbdo.Location = new Point(9, 13);
            ttbdo.Name = "ttbdo";
            ttbdo.Size = new Size(166, 60);
            ttbdo.TabIndex = 1;
            ttbdo.Text = "TTBDO";
            ttbdo.UseVisualStyleBackColor = false;
            ttbdo.Click += ttbdo_Click;
            ttbdo.Leave += ttbdo_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 76);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "BUILDINGS:";
            // 
            // ctrlpnlFormLoaderv2
            // 
            ctrlpnlFormLoaderv2.BackColor = Color.FromArgb(46, 51, 73);
            ctrlpnlFormLoaderv2.Location = new Point(181, 0);
            ctrlpnlFormLoaderv2.Name = "ctrlpnlFormLoaderv2";
            ctrlpnlFormLoaderv2.Size = new Size(1284, 838);
            ctrlpnlFormLoaderv2.TabIndex = 2;
            // 
            // frmControlv2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 838);
            Controls.Add(ctrlpnlFormLoaderv2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmControlv2";
            Text = "frmControlv2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Button ttbdo;
        private Panel ctrlpnlFormLoaderv2;
        private Button bldgA;
        private Button bldgC;
        private Button bldgB;
    }
}