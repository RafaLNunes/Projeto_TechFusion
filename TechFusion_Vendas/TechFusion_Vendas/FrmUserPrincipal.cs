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
    public partial class FrmUserPrincipal : Form
    {
        public FrmUserPrincipal()
        {
            InitializeComponent();
        }

        private void FrmUserPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
