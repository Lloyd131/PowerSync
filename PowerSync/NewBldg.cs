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
    public partial class New_Bldgcs : Form
    {
        public New_Bldgcs()
        {
            InitializeComponent();
        }

        private int currentFloor = 0;

        private void add_Click(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(37, 42, 64);

            switch (currentFloor)
            {
                case 0:
                    floor2.Visible = true;
                    currentFloor++;
                    break;
                case 1:
                    floor3.Visible = true;
                    currentFloor++;
                    break;
                case 2:
                    floor4.Visible = true;
                    currentFloor++;
                    break;
                case 3:
                    MessageBox.Show("Maximum floors reached");
                    break;
            }
        }


        private void add_Leave(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(23, 30, 54);

        }

        private void floor1_Click(object sender, EventArgs e)
        {
            this.floorFrmLoader.Controls.Clear();
            Floors Floor_Vrb = new Floors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.floorFrmLoader.Controls.Add(Floor_Vrb);
            Floor_Vrb.Show();
        }

        private void floor2_Click(object sender, EventArgs e)
        {
            this.floorFrmLoader.Controls.Clear();
            Floors Floor_Vrb = new Floors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.floorFrmLoader.Controls.Add(Floor_Vrb);
            Floor_Vrb.Show();
        }

        private void floor3_Click(object sender, EventArgs e)
        {
            this.floorFrmLoader.Controls.Clear();
            Floors Floor_Vrb = new Floors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.floorFrmLoader.Controls.Add(Floor_Vrb);
            Floor_Vrb.Show();
        }

        private void floor4_Click(object sender, EventArgs e)
        {
            this.floorFrmLoader.Controls.Clear();
            Floors Floor_Vrb = new Floors() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.floorFrmLoader.Controls.Add(Floor_Vrb);
            Floor_Vrb.Show();
        }
    }
}
