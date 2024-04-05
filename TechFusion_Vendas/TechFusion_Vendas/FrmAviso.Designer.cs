namespace TechFusion_Vendas
{
    partial class FrmAviso
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textAviso = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 125);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(3, 133, 84);
            button2.Location = new Point(305, 6);
            button2.Name = "button2";
            button2.Size = new Size(292, 116);
            button2.TabIndex = 1;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(3, 133, 84);
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(296, 116);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(textAviso);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 379);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // textAviso
            // 
            textAviso.AutoSize = true;
            textAviso.BackColor = Color.Transparent;
            textAviso.Location = new Point(3, 0);
            textAviso.Name = "textAviso";
            textAviso.Size = new Size(50, 20);
            textAviso.TabIndex = 0;
            textAviso.Text = "label1";
            textAviso.Click += label1_Click;
            // 
            // FrmAviso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 504);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            MaximumSize = new Size(618, 551);
            MinimumSize = new Size(618, 551);
            Name = "FrmAviso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAviso";
            Load += FrmAviso_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label textAviso;
    }
}