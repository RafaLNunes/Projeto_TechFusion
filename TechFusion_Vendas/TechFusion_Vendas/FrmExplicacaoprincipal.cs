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
    public partial class FrmExplicacaoprincipal : Form
    {
        bool sidebarbool;
        bool homebool;
        bool salebool;

        public FrmExplicacaoprincipal()
        {
            InitializeComponent();
        }

        private void FrmExplicacaoprincipal_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            SaleTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHomePrincipal prin = new FrmHomePrincipal();
            this.Hide();
            prin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmExplicacaoprincipal exp = new FrmExplicacaoprincipal();
            this.Hide();
            exp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            FrmSoftware soft = new FrmSoftware();
            this.Hide();
            soft.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRedes rede = new FrmRedes();
            this.Hide();
            rede.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHardware hardware = new FrmHardware();
            this.Hide();
            hardware.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmCloud cloud = new FrmCloud();
            this.Hide();
            cloud.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUserPrincipal user = new FrmUserPrincipal();
            this.Hide();
            user.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmSetting setting = new FrmSetting();
            this.Hide();
            setting.ShowDialog();
        }

        private void FrmExplicacaoprincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
