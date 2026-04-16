namespace ProgressBar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            chkMostrar = new CheckBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            lblError = new Label();
            lblPorcentaje = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelLogin = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 46);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE ACCESO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(196, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(196, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(201, 306);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(160, 24);
            chkMostrar.TabIndex = 3;
            chkMostrar.Text = "Mostrar Contraseña";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10.2F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(149, 365);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(155, 48);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(357, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 48);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.IndianRed;
            progressBar1.Location = new Point(196, 442);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(280, 18);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(149, 487);
            lblError.Name = "lblError";
            lblError.Size = new Size(363, 41);
            lblError.TabIndex = 7;
            lblError.Text = "uu";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Click += lblError_Click;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Segoe UI", 10F);
            lblPorcentaje.ForeColor = Color.Gray;
            lblPorcentaje.Location = new Point(323, 463);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(33, 23);
            lblPorcentaje.TabIndex = 8;
            lblPorcentaje.Text = "0%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 100);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 9;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(168, 201);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 10;
            label3.Text = "CONTRASEÑA";
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(pictureBox3);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(lblError);
            panelLogin.Controls.Add(lblPorcentaje);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(progressBar1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(btnCancelar);
            panelLogin.Controls.Add(chkMostrar);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(687, 587);
            panelLogin.TabIndex = 11;
            panelLogin.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 70);
            panel1.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(168, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(168, 306);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(168, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(168, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(688, 586);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private CheckBox chkMostrar;
        private Button btnIngresar;
        private Button btnCancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Label lblError;
        private Label lblPorcentaje;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Panel panelLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
    }
}
