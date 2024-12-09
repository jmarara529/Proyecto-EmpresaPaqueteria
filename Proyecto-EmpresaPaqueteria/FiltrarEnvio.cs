using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EmpresaPaqueteria
{
    public partial class FiltrarEnvio : Form
    {

        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";

        public FiltrarEnvio()
        {
            InitializeComponent();
        }

        private void radioButtonIdLote_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdLote.Checked)
            {
                comboBoxFiltro.Items.Clear(); // Limpiar el ComboBox
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT id_lote FROM envio";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["id_lote"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
        }


        private void radioButtonMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMarca.Checked)
            {
                comboBoxFiltro.Items.Clear(); // Limpiar el ComboBox
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT DISTINCT ca.marca 
                FROM envio e
                JOIN camion ca ON e.id_camion = ca.matricula";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["marca"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
        }


        private void radioButtonMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMatricula.Checked)
            {
                comboBoxFiltro.Items.Clear(); // Limpiar el ComboBox
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT id_camion FROM envio";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["id_camion"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
        }


        private void radioButtonDni_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDni.Checked)
            {
                comboBoxFiltro.Items.Clear(); // Limpiar el ComboBox
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT id_chofer FROM envio";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["id_chofer"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            string filtro = comboBoxFiltro.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Por favor, seleccione un filtro.");
                return;
            }

            string query = @"
        SELECT e.id AS id_envio,
               e.id_lote,
               ca.marca AS marca_camion, 
               ca.modelo AS modelo_camion, 
               e.id_camion AS Matricula, 
               ch.nombre AS nombre_chofer, 
               ch.telefono AS telefono, 
               e.id_chofer AS DNI_Chofer
        FROM envio e
        JOIN chofer ch ON e.id_chofer = ch.dni
        JOIN camion ca ON e.id_camion = ca.matricula
        WHERE ";

            if (radioButtonIdLote.Checked)
            {
                query += "e.id_lote = @filtro";
            }
            else if (radioButtonMarca.Checked)
            {
                query += "ca.marca = @filtro";
            }
            else if (radioButtonMatricula.Checked)
            {
                query += "e.id_camion = @filtro";
            }
            else if (radioButtonDni.Checked)
            {
                query += "e.id_chofer = @filtro";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de filtro.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filtro", filtro);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFiltro.DataSource = dt;
                }
            }
        }

    }
}
