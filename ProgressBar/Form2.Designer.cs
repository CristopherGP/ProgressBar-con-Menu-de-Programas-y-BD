namespace ProgressBar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblBienvenida = new Label();
            menuStrip1 = new MenuStrip();
            programasToolStripMenuItem = new ToolStripMenuItem();
            programa1ToolStripMenuItem = new ToolStripMenuItem();
            programa2ToolStripMenuItem = new ToolStripMenuItem();
            programa3ToolStripMenuItem = new ToolStripMenuItem();
            programa4ToolStripMenuItem = new ToolStripMenuItem();
            programa5ToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            btnPrograma1 = new Button();
            btnPrograma2 = new Button();
            btnPrograma3 = new Button();
            btnPrograma4 = new Button();
            btnPrograma5 = new Button();
            lblEstado = new Label();
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            menuStrip1.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.Location = new Point(268, 47);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(400, 20);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido al sistema";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { programasToolStripMenuItem, consultasToolStripMenuItem, ayudaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(777, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programa1ToolStripMenuItem, programa2ToolStripMenuItem, programa3ToolStripMenuItem, programa4ToolStripMenuItem, programa5ToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(94, 24);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // programa1ToolStripMenuItem
            // 
            programa1ToolStripMenuItem.Name = "programa1ToolStripMenuItem";
            programa1ToolStripMenuItem.Size = new Size(169, 26);
            programa1ToolStripMenuItem.Text = "Programa 1";
            programa1ToolStripMenuItem.Click += programa1ToolStripMenuItem_Click;
            // 
            // programa2ToolStripMenuItem
            // 
            programa2ToolStripMenuItem.Name = "programa2ToolStripMenuItem";
            programa2ToolStripMenuItem.Size = new Size(169, 26);
            programa2ToolStripMenuItem.Text = "Programa 2";
            programa2ToolStripMenuItem.Click += programa2ToolStripMenuItem_Click;
            // 
            // programa3ToolStripMenuItem
            // 
            programa3ToolStripMenuItem.Name = "programa3ToolStripMenuItem";
            programa3ToolStripMenuItem.Size = new Size(169, 26);
            programa3ToolStripMenuItem.Text = "Programa 3";
            programa3ToolStripMenuItem.Click += programa3ToolStripMenuItem_Click;
            // 
            // programa4ToolStripMenuItem
            // 
            programa4ToolStripMenuItem.Name = "programa4ToolStripMenuItem";
            programa4ToolStripMenuItem.Size = new Size(169, 26);
            programa4ToolStripMenuItem.Text = "Programa 4";
            programa4ToolStripMenuItem.Click += programa4ToolStripMenuItem_Click;
            // 
            // programa5ToolStripMenuItem
            // 
            programa5ToolStripMenuItem.Name = "programa5ToolStripMenuItem";
            programa5ToolStripMenuItem.Size = new Size(169, 26);
            programa5ToolStripMenuItem.Text = "Programa 5";
            programa5ToolStripMenuItem.Click += programa5ToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(86, 24);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += ayudaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // btnPrograma1
            // 
            btnPrograma1.BackColor = Color.MediumBlue;
            btnPrograma1.FlatStyle = FlatStyle.Flat;
            btnPrograma1.ForeColor = Color.White;
            btnPrograma1.Location = new Point(12, 122);
            btnPrograma1.Name = "btnPrograma1";
            btnPrograma1.Size = new Size(150, 40);
            btnPrograma1.TabIndex = 2;
            btnPrograma1.Text = "Programa 1";
            btnPrograma1.UseVisualStyleBackColor = false;
            btnPrograma1.Click += btnPrograma1_Click;
            // 
            // btnPrograma2
            // 
            btnPrograma2.BackColor = Color.MediumBlue;
            btnPrograma2.FlatStyle = FlatStyle.Flat;
            btnPrograma2.ForeColor = Color.White;
            btnPrograma2.Location = new Point(12, 181);
            btnPrograma2.Name = "btnPrograma2";
            btnPrograma2.Size = new Size(150, 40);
            btnPrograma2.TabIndex = 3;
            btnPrograma2.Text = "Programa 2";
            btnPrograma2.UseVisualStyleBackColor = false;
            btnPrograma2.Click += btnPrograma2_Click;
            // 
            // btnPrograma3
            // 
            btnPrograma3.BackColor = Color.MediumBlue;
            btnPrograma3.FlatStyle = FlatStyle.Flat;
            btnPrograma3.ForeColor = Color.White;
            btnPrograma3.Location = new Point(12, 243);
            btnPrograma3.Name = "btnPrograma3";
            btnPrograma3.Size = new Size(150, 40);
            btnPrograma3.TabIndex = 4;
            btnPrograma3.Text = "Programa 3";
            btnPrograma3.UseVisualStyleBackColor = false;
            btnPrograma3.Click += btnPrograma3_Click;
            // 
            // btnPrograma4
            // 
            btnPrograma4.BackColor = Color.MediumBlue;
            btnPrograma4.FlatStyle = FlatStyle.Flat;
            btnPrograma4.ForeColor = Color.White;
            btnPrograma4.Location = new Point(12, 307);
            btnPrograma4.Name = "btnPrograma4";
            btnPrograma4.Size = new Size(150, 40);
            btnPrograma4.TabIndex = 5;
            btnPrograma4.Text = "Programa 4";
            btnPrograma4.UseVisualStyleBackColor = false;
            btnPrograma4.Click += btnPrograma4_Click;
            // 
            // btnPrograma5
            // 
            btnPrograma5.BackColor = Color.MediumBlue;
            btnPrograma5.FlatStyle = FlatStyle.Flat;
            btnPrograma5.ForeColor = Color.White;
            btnPrograma5.Location = new Point(12, 366);
            btnPrograma5.Name = "btnPrograma5";
            btnPrograma5.Size = new Size(150, 40);
            btnPrograma5.TabIndex = 6;
            btnPrograma5.Text = "Programa 5";
            btnPrograma5.UseVisualStyleBackColor = false;
            btnPrograma5.Click += btnPrograma5_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = SystemColors.GradientInactiveCaption;
            lblEstado.Dock = DockStyle.Bottom;
            lblEstado.Location = new Point(0, 451);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(21, 20);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "la";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Click += lblEstado_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.AliceBlue;
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(btnCerrarSesion);
            panelContenedor.Controls.Add(lblBienvenida);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(777, 471);
            panelContenedor.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.AliceBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnPrograma1);
            panel1.Controls.Add(btnPrograma5);
            panel1.Controls.Add(btnPrograma2);
            panel1.Controls.Add(btnPrograma3);
            panel1.Controls.Add(btnPrograma4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 471);
            panel1.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(646, 439);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(128, 29);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 471);
            Controls.Add(lblEstado);
            Controls.Add(menuStrip1);
            Controls.Add(panelContenedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú de Programas";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem programa1ToolStripMenuItem;
        private ToolStripMenuItem programa2ToolStripMenuItem;
        private ToolStripMenuItem programa3ToolStripMenuItem;
        private ToolStripMenuItem programa4ToolStripMenuItem;
        private ToolStripMenuItem programa5ToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnPrograma1;
        private Button btnPrograma2;
        private Button btnPrograma3;
        private Button btnPrograma4;
        private Button btnPrograma5;
        private Label lblEstado;
        private Panel panelContenedor;
        private Button btnCerrarSesion;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}