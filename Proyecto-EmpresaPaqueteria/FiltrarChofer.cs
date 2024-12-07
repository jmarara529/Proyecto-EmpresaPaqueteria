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
    public partial class FiltrarChofer : Form
    {

        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";


        public FiltrarChofer()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarChofers();
        }

        private void checkBoxBajas_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarChofers();
        }

        private void FiltrarChofers()
        {
            string filtro = textBoxFiltro.Text.Trim();
            string campo = "";


            if (radioButtonNombre.Checked)
            {
                campo = "nombre";
            }else if (radioButtonDni.Checked)
            {
                campo = "dni";
            }else if (radioButtonApellido.Checked)
            {
                campo = "apellido";
            }

            if (String.IsNullOrEmpty(filtro) || string.IsNullOrEmpty(campo) ){
                MessageBox.Show("Por favor introduce un texto y marca una opción");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = radioButtonApellido.Checked ?
                    $"SELECT * from chofer WHERE (apellido1 LIKE @filtro or Apellido2 LIKE @filtro)" : 
                    $"SELECT * FROM chofer WHERE {campo} LIKE @filtro";
                if (!checkBoxBajas.Checked)
                {
                    query += " AND baja = 0";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewChoferFiltrar.DataSource = dt; // Mostrar resultados en el DataGridView del formulario filtrarChofer
                }
            }
        }

        private void buttonAltaBaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewChoferFiltrar.SelectedRows.Count > 0)
            {
                string dni = dataGridViewChoferFiltrar.SelectedRows[0].Cells["dni"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el valor actual de baja
                    string getBajaQuery = "SELECT baja FROM chofer WHERE dni = @dni";
                    bool bajaActual;
                    using (SqlCommand getBajaCommand = new SqlCommand(getBajaQuery, connection))
                    {
                        getBajaCommand.Parameters.AddWithValue("@dni", dni);
                        bajaActual = (bool)getBajaCommand.ExecuteScalar();
                    }

                    // Cambiar el valor de baja
                    bool nuevoEstadoBaja = !bajaActual;
                    string updateQuery = "UPDATE chofer SET baja = @nuevoEstadoBaja WHERE dni = @dni";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nuevoEstadoBaja", nuevoEstadoBaja);
                        updateCommand.Parameters.AddWithValue("@dni", dni);

                        int result = updateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Estado actualizado correctamente.");
                            FiltrarChofers(); // Actualizar el DataGridView
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
                MessageBox.Show("Por favor, selecciona un chofer.");
            }
        }

        private void dataGridViewChoferFiltrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChoferFiltrar.Rows[e.RowIndex];
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido1 = row.Cells["apellido1"].Value.ToString();
                string apellido2 = row.Cells["apellido2"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();
                string dni = row.Cells["dni"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["baja"].Value);

                ActualizarChofer actualizarChofer = new ActualizarChofer(nombre, apellido1, apellido2, telefono, dni, baja);
                actualizarChofer.ShowDialog();
                FiltrarChofers();
            }
        }
    }
}
