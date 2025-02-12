using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSync
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Set KeyPreview to true to handle form-level key events
            this.KeyPreview = true;

            // Configure controls to handle enter key
            username.KeyDown += TextBox_KeyDown;
            password.KeyDown += TextBox_KeyDown;

            // Set the accept button of the form
            this.AcceptButton = button1;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                // If username field is active and not empty, move to password
                if (sender == username && !string.IsNullOrWhiteSpace(username.Text))
                {
                    password.Focus();
                }
                // If password field is active, trigger login
                else if (sender == password)
                {
                    button1_Click(sender, e);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (username.Text == "admin" && password.Text == "admin123")
            {
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password incorrect");
                username.Clear();
                password.Clear();
                username.Focus(); // Return focus to username field after failed login
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Set initial focus to username textbox
            username.Focus();
        }
    }
}