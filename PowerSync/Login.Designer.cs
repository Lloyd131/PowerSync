namespace PowerSync
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(95, 39);
            label1.Name = "label1";
            label1.Size = new Size(295, 60);
            label1.TabIndex = 1;
            label1.Text = "POWERSYNC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 172);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 2;
            label2.Text = "Username: \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 253);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(175, 176);
            username.Name = "username";
            username.Size = new Size(261, 27);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(172, 257);
            password.Name = "password";
            password.Size = new Size(261, 27);
            password.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button1.Location = new Point(172, 321);
            button1.Name = "button1";
            button1.Size = new Size(128, 38);
            button1.TabIndex = 4;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // close
            // 
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("SansSerif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 2);
            close.ForeColor = Color.White;
            close.Location = new Point(441, 0);
            close.Name = "close";
            close.Size = new Size(49, 37);
            close.TabIndex = 5;
            close.Text = "X\r\n";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(491, 550);
            Controls.Add(close);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button button1;
        private Button close;
    }
}