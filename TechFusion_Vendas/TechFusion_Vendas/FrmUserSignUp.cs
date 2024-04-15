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
    public partial class FrmUserSignUp : Form
    {
        ClConnection conn = new ClConnection();
        bool passwordchard;
        bool sidebarbool;
        bool homebool;
        String Cam_FT = "";

        public FrmUserSignUp()
        {
            InitializeComponent();

        }

        private void FrmUserSignUp_Load(object sender, EventArgs e)
        {
            int ano_atual = DateTime.Now.Year;
            for (int i = ano_atual; i > ano_atual - 100; i--)
            {
                CBidade.Items.Add(i);
            }

            CBperfil.DataSource = conn.Obter_dados("select * from perfil");
            CBperfil.DisplayMember = "cargo";
            CBperfil.ValueMember = "Cod_perfil";
            CBperfil.Text = String.Empty;

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarbool)
            {
                flowLayoutPanel1.Width += 10;
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarbool = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width -= 10;
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarbool = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void FrmUserSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ft = new OpenFileDialog();
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    clRouderpb1.Image = Image.FromFile(ft.FileName);
                    Cam_FT = ft.FileName.Replace("\\", "\\\\");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PBvisiblePassword_Click(object sender, EventArgs e)
        {
            if (passwordchard)
            {
                passwordchard = false;
                textpassword.PasswordChar = '•';
                PBvisiblePassword.Image = ListaVisiblepass.Images[1];
            }
            else
            {
                passwordchard = true;
                textpassword.PasswordChar = '\0';
                PBvisiblePassword.Image = ListaVisiblepass.Images[0];

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserInicial user = new FrmUserInicial();
            this.Hide();
            user.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textpassword.Text != String.Empty && textuser.Text != String.Empty && textname.Text != String.Empty && CBidade.Text != String.Empty && CBperfil.Text != String.Empty && clRouderpb1.Image != null)
            {
                String Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(Cam_FT));
                File.Copy(Cam_FT, Cam_origin, true);
                conn.SignUp(textname, textuser, textpassword, Convert.ToInt32(CBidade.Text), CBperfil.SelectedIndex, Cam_origin);
                MessageBox.Show("Cadastro efetuado com Sucesso\nRedirecionando para LogIn");
                FrmUserInicial user = new FrmUserInicial();
                user.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faltou alguma informação\nColoque-as");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
