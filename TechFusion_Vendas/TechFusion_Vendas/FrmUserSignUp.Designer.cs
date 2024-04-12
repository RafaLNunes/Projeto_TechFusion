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
            panel5.Controls.Add(clRouderpb1);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(6, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(637, 530);
            panel5.TabIndex = 0;
            // 
            // clRouderpb1
            // 
            clRouderpb1.BackColor = Color.Transparent;
            clRouderpb1.Location = new Point(373, 12);
            clRouderpb1.Name = "clRouderpb1";
            clRouderpb1.Size = new Size(228, 228);
            clRouderpb1.SizeMode = PictureBoxSizeMode.Zoom;
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
    }
}