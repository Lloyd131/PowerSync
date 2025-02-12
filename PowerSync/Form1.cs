using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PowerSync 
{
    public partial class Form1 : Form
    {
        [DllImport("Gd32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "DASHBOARD";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            btnControl.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "CONTROL";
            this.PnlFormLoader.Controls.Clear();
            frmControlv2 FrmControl_Vrb = new frmControlv2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmControl_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmControl_Vrb);
            FrmControl_Vrb.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            btnStats.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "STATISTICS";
            this.PnlFormLoader.Controls.Clear();
            frmStat FrmStat_Vrb = new frmStat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmStat_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmStat_Vrb);
            FrmStat_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnControl_Leave(object sender, EventArgs e)
        {
            btnControl.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStats_Leave(object sender, EventArgs e)
        {
            btnStats.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
