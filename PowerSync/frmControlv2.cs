using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSync
{
    public partial class frmControlv2 : Form
    {
        public frmControlv2()
        {
            InitializeComponent();
        }

        private void ttbdo_Click(object sender, EventArgs e)
        {
            ttbdo.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoaderv2.Controls.Clear();
            BldgLayout BldgLayout_Vrb = new BldgLayout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            BldgLayout_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoaderv2.Controls.Add(BldgLayout_Vrb);
            BldgLayout_Vrb.Show();
        }



        private void ttbdo_Leave(object sender, EventArgs e)
        {
            ttbdo.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void bldgA_Click(object sender, EventArgs e)
        {
            bldgA.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoaderv2.Controls.Clear();
            New_Bldgcs New_Vrb = new New_Bldgcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            New_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoaderv2.Controls.Add(New_Vrb);
            New_Vrb.Show();
        }

        private void bldgB_Click(object sender, EventArgs e)
        {
            bldgB.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoaderv2.Controls.Clear();
            New_Bldgcs New_Vrb = new New_Bldgcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            New_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoaderv2.Controls.Add(New_Vrb);
            New_Vrb.Show();
        }

        private void bldgC_Click(object sender, EventArgs e)
        {
            bldgC.BackColor = Color.FromArgb(46, 51, 73);

            this.ctrlpnlFormLoaderv2.Controls.Clear();
            New_Bldgcs New_Vrb = new New_Bldgcs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            New_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.ctrlpnlFormLoaderv2.Controls.Add(New_Vrb);
            New_Vrb.Show();
        }

        private void bldgA_Leave(object sender, EventArgs e)
        {
            bldgA.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void bldgB_Leave(object sender, EventArgs e)
        {
            bldgB.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void bldgC_Leave(object sender, EventArgs e)
        {
            bldgC.BackColor = Color.FromArgb(37, 42, 64);
        }
    }
}
