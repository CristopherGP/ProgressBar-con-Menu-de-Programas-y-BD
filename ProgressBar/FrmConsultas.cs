using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProgressBar
{
    public partial class FrmConsultas : Form
    {
        string conexion = "server=localhost;database=FiestaDe15;uid=root;pwd=Samara182;";
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            cmbProgramas.Items.Add("invitados");   // Programa 1
            cmbProgramas.Items.Add("factura");    // Programa 2
            cmbProgramas.Items.Add("rentas");    // Programa 3
            cmbProgramas.Items.Add("ventas");   // Programa 4
            cmbProgramas.Items.Add("alquileres");      // Programa 5
        }

        private void cmbProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si entra al boton");
            try
            {
                if (cmbProgramas.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una tabla");
                    return;
                }

                string tabla = cmbProgramas.Text;
                string bd = "";

                if (tabla == "invitados")
                    bd = "FiestaDe15";
                else if (tabla == "factura")
                    bd = "Facturacion";
                else if (tabla == "ventas")
                    bd = "Facturacion";
                else if (tabla == "rentas")
                    bd = "Facturacion";
                else if (tabla == "alquileres")
                    bd = "Hotel";

                string query = "SELECT * FROM " + bd + "." + tabla;

                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
