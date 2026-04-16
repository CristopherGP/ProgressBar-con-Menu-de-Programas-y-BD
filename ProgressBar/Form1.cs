using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        private int progreso = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
            );

        public Form1()

        {
            InitializeComponent();
            lblError.Text = "";
            lblPorcentaje.Text = "0%";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Animación de aparición
            this.Opacity = 0;

            System.Windows.Forms.Timer fade =
                new System.Windows.Forms.Timer();
            fade.Interval = 30;

            fade.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fade.Stop();
            };

            fade.Start();

            // Efecto hover del botón
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;

            lblError.ForeColor = Color.Red;
            lblError.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            lblError.Visible = false;
            lblError.Visible = true;

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                lblError.Text = "Ingresa usuario y Contraseña";
                return;
            }

            if (user == "admin" && pass == "1234")
            {
                lblError.Text = "";
                progreso = 0;
                progressBar1.Value = 0;
                timer1.Start();
                btnIngresar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                intentos++;

                lblError.Text = "Usuario o Contraseña incorrectos";

                txtPassword.Clear();

                if (intentos >= 3)
                {
                    btnIngresar.Enabled = false;
                    lblError.Text = "Demasiados intentos. Espera 10 Segundos";

                    System.Windows.Forms.Timer bloqueo =
                        new System.Windows.Forms.Timer();
                    bloqueo.Interval = 10000;

                    bloqueo.Tick += (s, ev) =>
                    {
                        btnIngresar.Enabled = true;
                        intentos = 0;
                        lblError.Text = "";
                        bloqueo.Stop();
                    };

                    bloqueo.Start();

                }
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
                txtPassword.UseSystemPasswordChar
                    = false;
            else
                txtPassword.UseSystemPasswordChar
                    = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progreso += 2;
            progressBar1.Value = progreso;

            lblPorcentaje.Text = progreso + "%";

            if (progreso >= 100)
            {
                timer1.Stop();

                Form2 menu = new Form2();
                menu.Show();

                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Deseas salir?",
                "Confirmar",
                MessageBoxButtons.YesNo
                );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightGray, 2), panelLogin.ClientRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
