namespace PowerSync
{
    partial class Floors
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 309);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 0;
            label1.Text = "Under Development";
            // 
            // Floors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(1260, 716);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Floors";
            Text = "Floors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}