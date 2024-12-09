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
    public partial class FiltrarLote : Form
    {

        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";


        public FiltrarLote()
        {
            InitializeComponent();
            CargarComboboxProvincia();
        }

        private void CargarComboboxProvincia()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nombre FROM provincias";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxFiltro.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        private void checkBoxMostrarEnviados_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }


        private void aplicarFiltro()
        {
            if (comboBoxFiltro.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una provincia para filtrar.");
                return;
            }

            string provinciaNombre = comboBoxFiltro.SelectedItem.ToString();
            bool mostrarEnviados = checkBoxMostrarEnviados.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el código postal de la provincia seleccionada
                string getCodigoPostalQuery = "SELECT codigo_postal FROM provincias WHERE nombre = @nombre";
                string codigoPostal = "";
                using (SqlCommand getCodigoPostalCommand = new SqlCommand(getCodigoPostalQuery, connection))
                {
                    getCodigoPostalCommand.Parameters.AddWithValue("@nombre", provinciaNombre);
                    codigoPostal = getCodigoPostalCommand.ExecuteScalar().ToString();
                }

                // Filtrar los lotes según el código postal y el estado de enviado
                string filterQuery = @"
            SELECT id, provinciaDestino, capacidadMaxima, enviado 
            FROM lote 
            WHERE provinciaDestino = @codigoPostal AND enviado = @enviado";

                using (SqlCommand command = new SqlCommand(filterQuery, connection))
                {
                    command.Parameters.AddWithValue("@codigoPostal", codigoPostal);
                    command.Parameters.AddWithValue("@enviado", mostrarEnviados);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFiltrar.DataSource = dt;
                }
            }
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    List<int> lotesAEnviar = new List<int>();

                    if (dataGridViewFiltrar.SelectedRows.Count > 0)
                    {
                        // Obtener los lotes seleccionados
                        foreach (DataGridViewRow row in dataGridViewFiltrar.SelectedRows)
                        {
                            int loteId = (int)row.Cells["id"].Value;
                            bool enviado = (bool)row.Cells["enviado"].Value;
                            if (!enviado)
                            {
                                lotesAEnviar.Add(loteId);
                            }
                        }

                        if (lotesAEnviar.Count == 0)
                        {
                            MessageBox.Show("Los paquetes ya están enviados.");
                            return;
                        }
                    }
                    else
                    {
                        // Obtener todos los lotes mostrados en el DataGridView que no estén enviados
                        foreach (DataGridViewRow row in dataGridViewFiltrar.Rows)
                        {
                            int loteId = (int)row.Cells["id"].Value;
                            bool enviado = (bool)row.Cells["enviado"].Value;
                            if (!enviado)
                            {
                                lotesAEnviar.Add(loteId);
                            }
                        }

                        if (lotesAEnviar.Count == 0)
                        {
                            MessageBox.Show("Los paquetes ya están enviados.");
                            return;
                        }
                    }

                    string getCamionesDisponiblesQuery = "SELECT id_camion, id_chofer FROM chofer_camion WHERE f_fin IS NULL";
                    List<(string id_camion, string id_chofer)> camionesDisponibles = new List<(string, string)>();
                    using (SqlCommand getCamionesDisponiblesCommand = new SqlCommand(getCamionesDisponiblesQuery, connection, transaction))
                    {
                        SqlDataReader reader = getCamionesDisponiblesCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            camionesDisponibles.Add((reader["id_camion"].ToString(), reader["id_chofer"].ToString()));
                        }
                        reader.Close();
                    }

                    if (camionesDisponibles.Count == 0)
                    {
                        MessageBox.Show("No se ha podido realizar el envío por falta de camiones asignados.");
                        return;
                    }

                    DateTime fechaEnvio = DateTime.Now;
                    int camionesUsados = 0;

                    foreach (int loteId in lotesAEnviar)
                    {
                        if (camionesUsados >= camionesDisponibles.Count)
                        {
                            MessageBox.Show("No se ha podido realizar el envío por falta de camiones asignados.");
                            break;
                        }

                        var (id_camion, id_chofer) = camionesDisponibles[camionesUsados];

                        // Añadir registro en la tabla envio
                        string insertEnvioQuery = "INSERT INTO envio (id, id_camion, id_lote, id_chofer) VALUES (@id, @id_camion, @id_lote, @id_chofer)";
                        using (SqlCommand insertEnvioCommand = new SqlCommand(insertEnvioQuery, connection, transaction))
                        {
                            int nuevoEnvioId = ObtenerSiguienteIdEnvio(connection, transaction); // Método para obtener el siguiente ID disponible para envío
                            insertEnvioCommand.Parameters.AddWithValue("@id", nuevoEnvioId);
                            insertEnvioCommand.Parameters.AddWithValue("@id_camion", id_camion);
                            insertEnvioCommand.Parameters.AddWithValue("@id_lote", loteId);
                            insertEnvioCommand.Parameters.AddWithValue("@id_chofer", id_chofer);
                            insertEnvioCommand.ExecuteNonQuery();
                        }

                        // Marcar lote como enviado
                        string updateLoteQuery = "UPDATE lote SET enviado = 1 WHERE id = @id";
                        using (SqlCommand updateLoteCommand = new SqlCommand(updateLoteQuery, connection, transaction))
                        {
                            updateLoteCommand.Parameters.AddWithValue("@id", loteId);
                            updateLoteCommand.ExecuteNonQuery();
                        }

                        // Actualizar la fecha de fin del chofer_camion
                        string updateChoferCamionQuery = "UPDATE chofer_camion SET f_fin = @f_fin WHERE id_camion = @id_camion AND id_chofer = @id_chofer AND f_fin IS NULL";
                        using (SqlCommand updateChoferCamionCommand = new SqlCommand(updateChoferCamionQuery, connection, transaction))
                        {
                            updateChoferCamionCommand.Parameters.AddWithValue("@f_fin", fechaEnvio);
                            updateChoferCamionCommand.Parameters.AddWithValue("@id_camion", id_camion);
                            updateChoferCamionCommand.Parameters.AddWithValue("@id_chofer", id_chofer);
                            updateChoferCamionCommand.ExecuteNonQuery();
                        }

                        camionesUsados++;
                    }

                    transaction.Commit();

                    if (camionesUsados < lotesAEnviar.Count)
                    {
                        MessageBox.Show("No se ha podido realizar el envío por falta de camiones asignados.");
                    }
                    else
                    {
                        MessageBox.Show("Se han enviado los elementos que no lo estaban.");
                    }

                    aplicarFiltro(); // Actualizar el DataGridView después del envío
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al enviar los lotes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ObtenerSiguienteIdEnvio(SqlConnection connection, SqlTransaction transaction)
        {
            string maxEnvioIdQuery = "SELECT ISNULL(MAX(id), 0) FROM envio";
            using (SqlCommand maxEnvioIdCommand = new SqlCommand(maxEnvioIdQuery, connection, transaction))
            {
                int maxEnvioId = (int)maxEnvioIdCommand.ExecuteScalar();
                return maxEnvioId + 1;
            }
        }




    }

}

    
