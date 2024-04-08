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
    public partial class FrmSetting : Form
    {
        bool sidebarbool;
        bool homebool;
        bool salebool;

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarbool)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarbool = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarbool = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaleTimer.Start();
        }

        private void SaleTimer_Tick(object sender, EventArgs e)
        {
            if (salebool)
            {
                salepainel.Height += 10;
                if (salepainel.Height == salepainel.MaximumSize.Height)
                {
                    salebool = false;
                    SaleTimer.Stop();
                }
            }
            else
            {
                salepainel.Height -= 10;
                if (salepainel.Height == salepainel.MinimumSize.Height)
                {
                    salebool = true;
                    SaleTimer.Stop();
                }
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
