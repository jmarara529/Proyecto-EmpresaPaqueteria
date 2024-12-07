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
    public partial class FiltrarAsignarChofer : Form
    {
        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";

        public FiltrarAsignarChofer()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarAsignación();
        }

        private void checkBoxMostrarSoloOcupados_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarAsignación();
        }

        private void FiltrarAsignación()
        {
            String filtro = comboBoxFiltro.Text.Trim();
            string campo = "";

            if (radioButtonFiltroDni.Checked)
            {
                campo = "id_chofer";
            }
            else if (radioButtonFiltroMatricula.Checked)
            {
                campo = "id_camion";
            }

            if (String.IsNullOrEmpty(filtro) || string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Debe seleccionar los filtros.");
                return; // Detener la ejecución si no se seleccionan los filtros
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si el filtro existe en la base de datos
                string checkQuery = $"SELECT COUNT(*) FROM chofer_camion WHERE {campo} LIKE @filtro";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("No se encontraron registros que coincidan con el filtro.");
                        return;
                    }
                }

                // Realizar la consulta para filtrar los datos
                string query = $"SELECT ca.marca, ca.modelo, ac.id_camion AS matricula, ch.nombre, ch.apellido1, ac.id_chofer AS dni, ac.f_inicio, ac.f_fin FROM chofer_camion ac JOIN camion ca ON ac.id_camion = ca.matricula JOIN chofer ch ON ac.id_chofer = ch.dni WHERE {campo} LIKE @filtro";
                if (checkBoxMostrarSoloOcupados.Checked)
                {
                    query += " AND f_fin IS NULL";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewAsignarChofer.DataSource = dt; // Mostrar resultados en el DataGridView del formulario FiltrarCamion
                }
            }
        }


        private void CargarMatriculas(object sender, EventArgs e)
        {
            comboBoxFiltro.Items.Clear();

            if (radioButtonFiltroMatricula.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT matricula FROM camion";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["matricula"].ToString());
                        }
                    }
                }
            }
        }

        private void CargarDni(object sender, EventArgs e)
        {
            comboBoxFiltro.Items.Clear();

            if (radioButtonFiltroDni.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT dni FROM chofer";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["dni"].ToString());
                        }
                    }
                }
            }
        }

        private void buttonLiberar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsignarChofer.SelectedRows.Count > 0)
            {
                string matricula = dataGridViewAsignarChofer.SelectedRows[0].Cells["matricula"].Value.ToString();
                string dni = dataGridViewAsignarChofer.SelectedRows[0].Cells["dni"].Value.ToString();
                DateTime fInicio = (DateTime)dataGridViewAsignarChofer.SelectedRows[0].Cells["f_inicio"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si f_fin ya tiene un valor
                    string checkQuery = "SELECT f_fin FROM chofer_camion WHERE id_camion = @id_camion AND id_chofer = @id_chofer AND f_inicio = @f_inicio";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id_camion", matricula);
                        checkCommand.Parameters.AddWithValue("@id_chofer", dni);
                        checkCommand.Parameters.AddWithValue("@f_inicio", fInicio);

                        object fFinValue = checkCommand.ExecuteScalar();
                        if (fFinValue != DBNull.Value)
                        {
                            MessageBox.Show("Ya está liberado.");
                            return;
                        }
                    }

                    // Actualizar el valor de f_fin con la fecha actual
                    string updateQuery = "UPDATE chofer_camion SET f_fin = @f_fin WHERE id_camion = @id_camion AND id_chofer = @id_chofer AND f_inicio = @f_inicio";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@f_fin", DateTime.Now);
                        updateCommand.Parameters.AddWithValue("@id_camion", matricula);
                        updateCommand.Parameters.AddWithValue("@id_chofer", dni);
                        updateCommand.Parameters.AddWithValue("@f_inicio", fInicio);

                        int result = updateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Asignación liberada correctamente.");
                            FiltrarAsignación(); // Actualizar el DataGridViewAsignarCamion
                        }
                        else
                        {
                            MessageBox.Show("Error al liberar la asignación.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una asignación.");
            }
        }
    }

}
