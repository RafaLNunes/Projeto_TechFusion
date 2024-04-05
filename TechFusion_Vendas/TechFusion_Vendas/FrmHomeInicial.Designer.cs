namespace TechFusion_Vendas
{
    partial class FrmHomeInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            SideBarTimer = new System.Windows.Forms.Timer(components);
            HomeTimer = new System.Windows.Forms.Timer(components);
            SideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            HomePainel.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.FromArgb(189, 217, 223);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(HomePainel);
            SideBar.Controls.Add(panel4);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(270, 828);
            SideBar.MinimumSize = new Size(57, 828);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(270, 828);
            SideBar.TabIndex = 0;
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
            // FrmHomeInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 828);
            Controls.Add(SideBar);
            Name = "FrmHomeInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += FrmHomeInicial_Load;
            SideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            HomePainel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SideBar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel HomePainel;
        private Panel panel6;
        private Button button4;
        private Panel panel7;
        private Button button5;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Timer HomeTimer;
    }
}
