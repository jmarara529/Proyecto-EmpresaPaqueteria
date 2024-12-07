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
    public partial class FiltrarCamion : Form
    {
        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";

        public FiltrarCamion()
        {
            InitializeComponent();
        }

        private void buttonCamionFiltrarSubmit_Click(object sender, EventArgs e)
        {
            FiltrarCamiones();
        }

        private void checkBoxCamionFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarCamiones();
        }

        private void FiltrarCamiones()
        {
            string filtro = textBoxCamionFiltrar.Text.Trim();
            string campo = "";

            if (radioButtonCamionFiltrarMarca.Checked)
            {
                campo = "marca";
            }
            else if (radioButtonCamionFiltrarModelo.Checked)
            {
                campo = "modelo";
            }
            else if (radioButtonCamionFiltrarMatricula.Checked)
            {
                campo = "matricula";
            }

            if (string.IsNullOrWhiteSpace(filtro) || string.IsNullOrWhiteSpace(campo))
            {
                MessageBox.Show("Por favor, introduce un texto para filtrar y selecciona un campo.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM camion WHERE {campo} LIKE @filtro";
                if (!checkBoxCamionFiltrar.Checked)
                {
                    query += " AND baja = 0";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewCamionFiltrar.DataSource = dt; // Mostrar resultados en el DataGridView del formulario FiltrarCamion
                }
            }
        }

        private void dataGridViewCamionFiltrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCamionFiltrar.Rows[e.RowIndex];
                string marca = row.Cells["marca"].Value.ToString();
                string modelo = row.Cells["modelo"].Value.ToString();
                string matricula = row.Cells["matricula"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["baja"].Value);

                ActualizarCamion actualizarCamion = new ActualizarCamion(marca, modelo, matricula, baja);
                actualizarCamion.ShowDialog();
                FiltrarCamiones();
            }
        }

        private void buttonAltaBaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewCamionFiltrar.SelectedRows.Count > 0)
            {
                string matricula = dataGridViewCamionFiltrar.SelectedRows[0].Cells["matricula"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el valor actual de baja
                    string getBajaQuery = "SELECT baja FROM camion WHERE matricula = @matricula";
                    bool bajaActual;
                    using (SqlCommand getBajaCommand = new SqlCommand(getBajaQuery, connection))
                    {
                        getBajaCommand.Parameters.AddWithValue("@matricula", matricula);
                        bajaActual = (bool)getBajaCommand.ExecuteScalar();
                    }

                    // Cambiar el valor de baja
                    bool nuevoEstadoBaja = !bajaActual;
                    string updateQuery = "UPDATE camion SET baja = @nuevoEstadoBaja WHERE matricula = @matricula";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nuevoEstadoBaja", nuevoEstadoBaja);
                        updateCommand.Parameters.AddWithValue("@matricula", matricula);

                        int result = updateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Estado actualizado correctamente.");
                            FiltrarCamiones(); // Actualizar el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el estado.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un camión.");
            }
        }

    }
}

