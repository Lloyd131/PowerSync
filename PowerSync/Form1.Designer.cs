namespace PowerSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnStats = new Button();
            btnControl = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            Title = new Label();
            PnlFormLoader = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 30, 54);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1650, 70);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1412, 6);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 5;
            label2.Text = "Username";
            label2.Click += label2_Click_1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SansSerif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1598, 3);
            button1.Name = "button1";
            button1.Size = new Size(49, 37);
            button1.TabIndex = 4;
            button1.Text = "X\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1440, 37);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 3;
            label3.Text = "Admin/Security";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1326, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 0;
            label1.Text = "POWERSYNC";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 30, 54);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 932);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnStats);
            panel4.Controls.Add(btnControl);
            panel4.Controls.Add(btnDashboard);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 314);
            panel4.TabIndex = 1;
            // 
            // btnStats
            // 
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnStats.ForeColor = Color.White;
            btnStats.Location = new Point(9, 181);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(164, 45);
            btnStats.TabIndex = 0;
            btnStats.Text = "STATISTICS";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            btnStats.Leave += btnStats_Leave;
            // 
            // btnControl
            // 
            btnControl.FlatAppearance.BorderSize = 0;
            btnControl.FlatStyle = FlatStyle.Flat;
            btnControl.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnControl.ForeColor = Color.White;
            btnControl.Location = new Point(12, 105);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(161, 45);
            btnControl.TabIndex = 0;
            btnControl.Text = "CONTROL";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            btnControl.Leave += btnControl_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(3, 31);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(176, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 94);
            panel3.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(6, 3);
            Title.Name = "Title";
            Title.Size = new Size(232, 46);
            Title.TabIndex = 2;
            Title.Text = "DASHBOARD";
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Dock = DockStyle.Bottom;
            PnlFormLoader.Location = new Point(185, 164);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(1465, 838);
            PnlFormLoader.TabIndex = 3;
            PnlFormLoader.Paint += PnlFormLoader_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(23, 30, 54);
            panel5.Controls.Add(Title);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(185, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(1465, 66);
            panel5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1650, 1002);
            Controls.Add(panel5);
            Controls.Add(PnlFormLoader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Button btnDashboard;
        private Button btnStats;
        private Button btnControl;
        private Panel panel4;
        private Panel panel3;
        private Label Title;
        private Panel PnlFormLoader;
        private Button button1;
        private Label label2;
        private Panel panel5;
    }
}
