using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido -" +
                DateTime.Now.ToString();
            lblEstado.Text = "Conectado";
            lblEstado.ForeColor = Color.Green;
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnPrograma1_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\FiestaDe15.exe";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                MessageBox.Show(
                    "El Programa 1 no está disponible",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Sesión finalizada correctamente",
        "Sistema",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    );

            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "¿Deseas salir del sistema?",
        "Salir",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPrograma2_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\pjFacturas.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 2 no esta disponible");
            }
        }

        private void btnPrograma3_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\pjRenta.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 3 no esta disponible");
            }
        }

        private void programa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\FiestaDe15.exe";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("El Programa 1 no está disponible");
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultas frm = new FrmConsultas();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda();
            frm.TopLevel = false;
            frm.FormBorderStyle =
                FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnPrograma5_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\Hotel.exe";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                MessageBox.Show(
                    "El Programa 5 no está disponible",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void programa5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\Hotel.exe";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                MessageBox.Show(
                    "El Programa 5 no está disponible",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void programa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\pjFacturas.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 2 no esta disponible");
            }
        }

        private void programa3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\pjRenta.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 3 no esta disponible");
            }
        }

        private void btnPrograma4_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\jpVenta.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 4 no esta disponible");
            }
        }

        private void programa4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = @"Programas\jpVenta.jar";

            if (System.IO.File.Exists(ruta))
            {
                System.Diagnostics.ProcessStartInfo
                psi = new
                System.Diagnostics.ProcessStartInfo();
                psi.FileName = "javaw";
                psi.Arguments = "-jar \"" + ruta + "\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("El Programa 4 no esta disponible");
            }
        }
    }
}
