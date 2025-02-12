namespace PowerSync
{
    partial class New_Bldgcs
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
            add = new Button();
            floor1 = new Button();
            floor2 = new Button();
            floor3 = new Button();
            floor4 = new Button();
            floorFrmLoader = new Panel();
            SuspendLayout();
            // 
            // add
            // 
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(12, 12);
            add.Name = "add";
            add.Size = new Size(112, 43);
            add.TabIndex = 0;
            add.Text = "Add floor";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            add.Leave += add_Leave;
            // 
            // floor1
            // 
            floor1.FlatAppearance.BorderSize = 0;
            floor1.FlatStyle = FlatStyle.Flat;
            floor1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor1.ForeColor = Color.White;
            floor1.Location = new Point(12, 61);
            floor1.Name = "floor1";
            floor1.Size = new Size(107, 40);
            floor1.TabIndex = 1;
            floor1.Text = "Floor 1";
            floor1.UseVisualStyleBackColor = true;
            floor1.Click += floor1_Click;
            // 
            // floor2
            // 
            floor2.FlatAppearance.BorderSize = 0;
            floor2.FlatStyle = FlatStyle.Flat;
            floor2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor2.ForeColor = Color.White;
            floor2.Location = new Point(136, 61);
            floor2.Name = "floor2";
            floor2.Size = new Size(107, 40);
            floor2.TabIndex = 2;
            floor2.Text = "Floor 2";
            floor2.UseVisualStyleBackColor = true;
            floor2.Visible = false;
            floor2.Click += floor2_Click;
            // 
            // floor3
            // 
            floor3.FlatAppearance.BorderSize = 0;
            floor3.FlatStyle = FlatStyle.Flat;
            floor3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor3.ForeColor = Color.White;
            floor3.Location = new Point(276, 61);
            floor3.Name = "floor3";
            floor3.Size = new Size(107, 40);
            floor3.TabIndex = 3;
            floor3.Text = "Floor 3";
            floor3.UseVisualStyleBackColor = true;
            floor3.Visible = false;
            floor3.Click += floor3_Click;
            // 
            // floor4
            // 
            floor4.FlatAppearance.BorderSize = 0;
            floor4.FlatStyle = FlatStyle.Flat;
            floor4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            floor4.ForeColor = Color.White;
            floor4.Location = new Point(417, 61);
            floor4.Name = "floor4";
            floor4.Size = new Size(107, 40);
            floor4.TabIndex = 4;
            floor4.Text = "Floor 4";
            floor4.UseVisualStyleBackColor = true;
            floor4.Visible = false;
            floor4.Click += floor4_Click;
            // 
            // floorFrmLoader
            // 
            floorFrmLoader.Location = new Point(12, 107);
            floorFrmLoader.Name = "floorFrmLoader";
            floorFrmLoader.Size = new Size(1260, 716);
            floorFrmLoader.TabIndex = 5;
            // 
            // New_Bldgcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(1284, 835);
            Controls.Add(floorFrmLoader);
            Controls.Add(floor4);
            Controls.Add(floor3);
            Controls.Add(floor2);
            Controls.Add(floor1);
            Controls.Add(add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New_Bldgcs";
            Text = "New_Bldgcs";
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private Button floor1;
        private Button floor2;
        private Button floor3;
        private Button floor4;
        private Panel floorFrmLoader;
    }
}