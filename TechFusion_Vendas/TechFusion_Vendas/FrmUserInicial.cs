using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFusion_Vendas
{
    public partial class FrmUserInicial : Form
    {
        bool sidebarbool;
        bool homebool;
        public FrmUserInicial()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHomeInicial hm = new FrmHomeInicial();
            this.Hide();
            hm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmexplicacao exp = new Frmexplicacao();
            this.Hide();
            exp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUserInicial user = new FrmUserInicial();
            this.Hide();
            user.ShowDialog();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarbool)
            {
                painelflow.Width += 10;
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarbool = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {

                painelflow.Width -= 10;
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarbool = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void FrmUserInicial_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }


        private void HomeTimer_Tick_1(object sender, EventArgs e)
        {
            if (homebool)
            {
                HomePainel.Height += 10;
                if (HomePainel.Height == HomePainel.MaximumSize.Height)
                {
                    homebool = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomePainel.Height -= 10;
                if (HomePainel.Height == HomePainel.MinimumSize.Height)
                {
                    homebool = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void FrmUserInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelLogIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
