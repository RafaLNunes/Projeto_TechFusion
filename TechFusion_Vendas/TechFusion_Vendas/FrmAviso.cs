﻿using System;
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
    public partial class FrmAviso : Form
    {
        public FrmAviso()
        {
            InitializeComponent();
        }

        private void FrmAviso_Load(object sender, EventArgs e)
        {
            textAviso.Text = "";
            string cont = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int contador;
            String contadores;
            int controle = cont.Length;
            //MessageBox.Show(controle.ToString());
            for (int i = 0; i < 26; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "Avisos de Funcionamento";
            for (int i = 0; i < 24; i++)
            {
                textAviso.Text += '═';
            }
            textAviso.Text += "\n";
            textAviso.Text += "       Tenha Certeza que antes de Rodar o Código você ativou as seguintes funções:     \n";


            contadores = "Ligar o Xampp";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Ligar o Xampp";
            textAviso.Text += "\n";


            contadores = "Reinstalar o NuGet";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Reinstalar o NuGet";
            textAviso.Text += "\n";

            contadores = "Executou o DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou o DataBase";
            textAviso.Text += "\n";

            contadores = "Executou os Dados da DataBase";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Executou os Dados da DataBase";
            textAviso.Text += "\n";

            contadores = "Clonou toda as pastas";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Clonou toda as pastas";
            textAviso.Text += "\n";

            contadores = "Otimizou o Computador";
            contador = controle - contadores.Length;
            for (int i = 0; i < contador; i++)
            {
                textAviso.Text += " ";
            }
            textAviso.Text += "Otimizou o Computador";
            textAviso.Text += "\n";
            textAviso.Text += "esse projeto é apenas educativo sem fins lucrativos, ou seja não terá " +
                              "dinheiro real envolvido, e nem reais fornecedores ou produtos, todos os " +
                              "itens mostrados durante \nesse projeto serão todos de cunho educativo e com " +
                              "foco no aprendizado.\n\n" +
                              "A ideia desse projeto é demonstrar nossos conhecimentos obtidos sobre C# ao longo do ano" +
                              " e assim receber nota e passar de ano\n\nEntão.....\nDai-nos nota prof!!!!!!!\n\nOutra infromaçã" +
                              "o de extrema importanci é que no momento da criação deste código não há nenhuma empresa ou grupo" +
                              " com nome techFusion portanto perdoe-nos se estivermos usando os direitos autorais de terceiros." +
                              "\nDito isso A TechFusion apresenta...\nO seu aplicativo Desktop" +
                              "\n\n\n\nCaso concorde com tudo dito Click em OK para seguir adiante.\n\nMas caso não concorde ou deixou de ativar alguma função, então clique CANCELAR para fechar o aplicativo \n\n\n\n\nAgradeço a Atenção\n\n\n";

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClConnection conn = new ClConnection();
            if (conn.GetConnection() != null)
            {
                MessageBox.Show("Conexão Estabelecida");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Foi computado que a conexão com a DataBase não funcionou\nPor isso a Aplicação será Fechada");
                Application.Exit();
            }
        }
    }
}
