namespace TechFusion_Vendas
{
    partial class FrmUserSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserSignUp));
            SideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            HomePainel = new Panel();
            panel7 = new Panel();
            button5 = new Button();
            panel6 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            painelflow = new FlowLayoutPanel();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            HomeTimer = new System.Windows.Forms.Timer(components);
            ListaVisiblepass = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            CBidade = new ComboBox();
            textname = new TextBox();
            CBperfil = new ComboBox();
            textuser = new TextBox();
            PBvisiblePassword = new PictureBox();
            textpassword = new TextBox();
            clRouderpb1 = new DB_CSharp_Origin.clRouderPB();
            panel9 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button1 = new Button();
            label2 = new Label();
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            HomePainel.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clRouderpb1).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(189, 217, 223);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(HomePainel);
            SideBar.Controls.Add(panel4);
            SideBar.Controls.Add(painelflow);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(270, 828);
            SideBar.MinimumSize = new Size(57, 828);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(270, 828);
            SideBar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 104);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 43);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wired_lineal_1326_command_window_line__1_;
            pictureBox1.Location = new Point(3, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // HomePainel
            // 
            HomePainel.Controls.Add(panel7);
            HomePainel.Controls.Add(panel6);
            HomePainel.Controls.Add(panel3);
            HomePainel.Location = new Point(3, 113);
            HomePainel.MaximumSize = new Size(266, 177);
            HomePainel.MinimumSize = new Size(266, 75);
            HomePainel.Name = "HomePainel";
            HomePainel.Size = new Size(266, 75);
            HomePainel.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(154, 208, 204);
            panel7.Controls.Add(button5);
            panel7.Location = new Point(0, 127);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 51);
            panel7.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.wired_lineal_187_suitcase;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, -56);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(266, 163);
            button5.TabIndex = 2;
            button5.Text = "        How it works";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(154, 208, 204);
            panel6.Controls.Add(button4);
            panel6.Location = new Point(0, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 51);
            panel6.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.wired_lineal_112_book1;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, -56);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(266, 163);
            button4.TabIndex = 2;
            button4.Text = "        About Us";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(189, 217, 223);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 75);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.wired_lineal_63_home__1_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -41);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(266, 163);
            button2.TabIndex = 2;
            button2.Text = "        Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(189, 217, 223);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 194);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 75);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.wired_lineal_21_avatar;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, -41);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(266, 163);
            button3.TabIndex = 2;
            button3.Text = "        User";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // painelflow
            // 
            painelflow.BackgroundImage = Properties.Resources.Design_sem_nome__2_1;
            painelflow.Dock = DockStyle.Left;
            painelflow.Location = new Point(3, 275);
            painelflow.Name = "painelflow";
            painelflow.Size = new Size(531, 0);
            painelflow.TabIndex = 6;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 2;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // HomeTimer
            // 
            HomeTimer.Interval = 2;
            HomeTimer.Tick += HomeTimer_Tick;
            // 
            // ListaVisiblepass
            // 
            ListaVisiblepass.ColorDepth = ColorDepth.Depth32Bit;
            ListaVisiblepass.ImageStream = (ImageListStreamer)resources.GetObject("ListaVisiblepass.ImageStream");
            ListaVisiblepass.TransparentColor = Color.Transparent;
            ListaVisiblepass.Images.SetKeyName(0, "olho 320.png");
            ListaVisiblepass.Images.SetKeyName(1, "visivel 320.png");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.Design_sem_nome__2_1;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(270, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(357, 828);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(627, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 828);
            panel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.dasfghjkl_removebg_preview__1_;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(linkLabel1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(CBidade);
            panel5.Controls.Add(textname);
            panel5.Controls.Add(CBperfil);
            panel5.Controls.Add(textuser);
            panel5.Controls.Add(PBvisiblePassword);
            panel5.Controls.Add(textpassword);
            panel5.Controls.Add(clRouderpb1);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(6, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(637, 530);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(382, 218);
            label8.Name = "label8";
            label8.Size = new Size(94, 29);
            label8.TabIndex = 19;
            label8.Text = "Cargo";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(35, 442);
            label7.Name = "label7";
            label7.Size = new Size(145, 29);
            label7.TabIndex = 18;
            label7.Text = "PassWord";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(35, 352);
            label6.Name = "label6";
            label6.Size = new Size(145, 29);
            label6.TabIndex = 17;
            label6.Text = "UserName";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 259);
            label3.Name = "label3";
            label3.Size = new Size(264, 29);
            label3.TabIndex = 16;
            label3.Text = "Ano de Nascimento";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 168);
            label4.Name = "label4";
            label4.Size = new Size(215, 29);
            label4.TabIndex = 8;
            label4.Text = "Nome Completo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(495, 492);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 23);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clique Aqui";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(382, 492);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 14;
            label5.Text = "Já tem Conta";
            // 
            // CBidade
            // 
            CBidade.BackColor = Color.FromArgb(216, 216, 216);
            CBidade.FlatStyle = FlatStyle.Flat;
            CBidade.FormattingEnabled = true;
            CBidade.Location = new Point(35, 299);
            CBidade.Name = "CBidade";
            CBidade.Size = new Size(332, 28);
            CBidade.TabIndex = 13;
            // 
            // textname
            // 
            textname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textname.BackColor = Color.FromArgb(216, 216, 216);
            textname.BorderStyle = BorderStyle.None;
            textname.Location = new Point(35, 218);
            textname.Name = "textname";
            textname.Size = new Size(332, 20);
            textname.TabIndex = 12;
            // 
            // CBperfil
            // 
            CBperfil.BackColor = Color.FromArgb(216, 216, 216);
            CBperfil.FlatStyle = FlatStyle.Flat;
            CBperfil.FormattingEnabled = true;
            CBperfil.Location = new Point(382, 259);
            CBperfil.Name = "CBperfil";
            CBperfil.Size = new Size(233, 28);
            CBperfil.TabIndex = 11;
            // 
            // textuser
            // 
            textuser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textuser.BackColor = Color.FromArgb(216, 216, 216);
            textuser.BorderStyle = BorderStyle.None;
            textuser.Location = new Point(35, 401);
            textuser.Name = "textuser";
            textuser.Size = new Size(332, 20);
            textuser.TabIndex = 5;
            // 
            // PBvisiblePassword
            // 
            PBvisiblePassword.BackColor = Color.Transparent;
            PBvisiblePassword.Image = Properties.Resources.visivel_320;
            PBvisiblePassword.Location = new Point(301, 469);
            PBvisiblePassword.Name = "PBvisiblePassword";
            PBvisiblePassword.Size = new Size(66, 46);
            PBvisiblePassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisiblePassword.TabIndex = 9;
            PBvisiblePassword.TabStop = false;
            PBvisiblePassword.Click += PBvisiblePassword_Click;
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textpassword.BackColor = Color.FromArgb(216, 216, 216);
            textpassword.BorderStyle = BorderStyle.None;
            textpassword.Location = new Point(35, 487);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '•';
            textpassword.Size = new Size(267, 20);
            textpassword.TabIndex = 10;
            // 
            // clRouderpb1
            // 
            clRouderpb1.BackColor = Color.Transparent;
            clRouderpb1.Location = new Point(373, 12);
            clRouderpb1.Name = "clRouderpb1";
            clRouderpb1.Size = new Size(203, 203);
            clRouderpb1.SizeMode = PictureBoxSizeMode.StretchImage;
            clRouderpb1.TabIndex = 6;
            clRouderpb1.TabStop = false;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(button6);
            panel9.Location = new Point(408, 334);
            panel9.Name = "panel9";
            panel9.Size = new Size(181, 55);
            panel9.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Stencil", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-47, -19);
            button6.Name = "button6";
            button6.Size = new Size(274, 95);
            button6.TabIndex = 2;
            button6.Text = "Escolher Imagem";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(button1);
            panel8.Location = new Point(408, 429);
            panel8.Name = "panel8";
            panel8.Size = new Size(181, 55);
            panel8.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-47, -18);
            button1.Name = "button1";
            button1.Size = new Size(274, 89);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 45F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 40);
            label2.Name = "label2";
            label2.Size = new Size(332, 89);
            label2.TabIndex = 1;
            label2.Text = "Sign Up";
            // 
            // FrmUserSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 828);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SideBar);
            Name = "FrmUserSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUserSignUp";
            FormClosed += FrmUserSignUp_FormClosed;
            Load += FrmUserSignUp_Load;
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            HomePainel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)clRouderpb1).EndInit();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SideBar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel HomePainel;
        private Panel panel7;
        private Button button5;
        private Panel panel6;
        private Button button4;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Timer HomeTimer;
        private ImageList ListaVisiblepass;
        private FlowLayoutPanel painelflow;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel5;
        private Label label2;
        private Panel panel9;
        private Button button6;
        private Panel panel8;
        private Button button1;
        private DB_CSharp_Origin.clRouderPB clRouderpb1;
        private PictureBox PBvisiblePassword;
        private TextBox textpassword;
        private TextBox textuser;
        private ComboBox CBperfil;
        private ComboBox CBidade;
        private TextBox textname;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
    }
}