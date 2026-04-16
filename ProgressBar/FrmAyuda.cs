using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            rtbManual.Clear();

            rtbManual.SelectionFont = new
                Font("Segoe UI", 12, FontStyle.Bold);
            rtbManual.AppendText("MANUAL DE USUARIO\n\n");

            rtbManual.SelectionFont = new
                Font("Segoe UI", 10, FontStyle.Regular);
            rtbManual.AppendText(
                "1. Iniciar Sesion con el usuario y contraseña correcto (USUARIO; admin--CONTRASEÑA: 1234)\n" +
                "2. Seleccionar uno de los programas disponible, ya sea en la bara de menu PROGRAMAS o en los botones de acceso rapido\n" +
                "3. Ejecutar el programa deseado y hacer lo que quiera ver\n" +
                "4. Consultar los registros deseados en la seccion CONSULTAS\n" +
                "5. Salir desde el menu SALIR o en el boton de CERRAR SESION\n" +
            "6. Un manual mas detallado se encuentra en nuestra pagina de GitHub, en el README, donde se detalla de mejor manera cada programa, menu y usos del mismo\n");
                

            btnRegresar.BackColor =
                   Color.FromArgb(52, 152, 219);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.FlatStyle = FlatStyle.Flat;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbManual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
