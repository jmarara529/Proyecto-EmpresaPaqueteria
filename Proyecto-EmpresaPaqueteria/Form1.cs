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
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosCamion();
            CargarDatosChofer();
            CargarDatosAsignarCamion();
            CargarComboboxCamion();
            CargarComboboxChofer();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                                                      //
        //                                              ventana camion                                                          //
        //                                                                                                                      //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void CargarDatosCamion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = checkBoxCamionesBaja.Checked ? "select * from camion" /*mostrar todos si está marcado checkbox*/ :
                    "select * from camion where baja = 0"/*mostrar solo los que estan en alta si no está marcado*/;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewCamion.DataSource = dt;
            }
        }

        private void buttonCamionFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarCamion filtrarCamion = new FiltrarCamion();
            filtrarCamion.FormClosed += new FormClosedEventHandler(FiltrarCamion_FormClosed);
            filtrarCamion.ShowDialog();
        }

        private void FiltrarCamion_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosCamion();
        }

        private void checkBoxCamionesBaja_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosCamion(); // Actualizar el DataGridView según el estado del CheckBox
        }

        private void buttonCamionSubmit_Click(object sender, EventArgs e)
        {
            String marca = textBoxMarca.Text.ToUpper();
            String modelo = textBoxModelo.Text.ToUpper();
            String matricula = textBoxMatricula.Text.ToUpper();

            if (String.IsNullOrEmpty(marca) || String.IsNullOrEmpty(modelo) || String.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM camion WHERE matricula = @matricula";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@matricula", matricula);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("La matrícula ya existe, revise los datos");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO camion (marca, modelo, matricula) values( @marca, @modelo, @matricula)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@matricula", matricula);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente");
                        CargarDatosCamion();

                        textBoxMarca.Clear();
                        textBoxModelo.Clear();
                        textBoxMatricula.Clear();

                        checkBoxCamionesBaja.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos");
                    }
                }
            }
        }

        private void buttonCamionDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCamion.SelectedRows.Count > 0)
            {
                string matricula = dataGridViewCamion.SelectedRows[0].Cells["matricula"].Value.ToString();

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
                            CargarDatosCamion(); // Actualizar el DataGridView
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



        private void dataGridViewCamion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCamion.Rows[e.RowIndex];
                string marca = row.Cells["marca"].Value.ToString();
                string modelo = row.Cells["modelo"].Value.ToString();
                string matricula = row.Cells["matricula"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["baja"].Value);

                ActualizarCamion actualizarCamion = new ActualizarCamion(marca, modelo, matricula, baja);
                actualizarCamion.ShowDialog();
                CargarDatosCamion(); // Actualizar el DataGridView después de cerrar el formulario
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                                                      //
        //                                              ventana chofer                                                          //
        //                                                                                                                      //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CargarDatosChofer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = checkBoxChoferMostrarBajas.Checked ? "select * from chofer" /*mostrar todos si está marcado checkbox*/ :
                    "select * from chofer where baja = 0"/*mostrar solo los que estan en alta si no está marcado*/;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewChofer.DataSource = dt;
            }
        }

        private void buttonChoferSubmit_Click(object sender, EventArgs e)
        {

            String nombre = textBoxChoferNombre.Text.ToUpper();
            String apllido1 = textBoxChoferApellido1.Text.ToUpper();
            String apellido2 = textBoxChoferApellido2.Text.ToUpper();
            String telefono = textBoxChoferTelefono.Text.ToUpper();
            String DNI = textBoxChoferDni.Text.ToUpper();



            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apllido1) || String.IsNullOrEmpty(apellido2) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(DNI))
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }
            else if (textBoxChoferTelefono.Text.Length != 9)
            {
                MessageBox.Show("El campo telefono deve tener 9 digitos");
                return;
            }
            else if (textBoxChoferDni.Text.Length != 9)
            {
                MessageBox.Show("El campo dni deve contener 9 caracteres");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM chofer WHERE dni = @dni";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@dni", DNI);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El DNI ya existe, revise los datos");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO chofer (nombre, apellido1, apellido2, telefono, dni) values( @nombre, @apellido1, @apellido2, @telefono, @dni)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apllido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@dni", DNI);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente");
                        CargarDatosChofer();

                        textBoxChoferNombre.Clear();
                        textBoxChoferApellido1.Clear();
                        textBoxChoferApellido2.Clear();
                        textBoxChoferTelefono.Clear();
                        textBoxChoferDni.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos");
                    }
                }
            }
        }

        private void buttonChoferFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarChofer filtrarChofer = new FiltrarChofer();
            filtrarChofer.FormClosed += new FormClosedEventHandler(FiltrarChofer_FormClosed);
            filtrarChofer.ShowDialog();
        }

        private void FiltrarChofer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosChofer();
        }

        private void checkBoxChoferMostrarBajas_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosChofer();
        }

        private void buttonChoferAltaBaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewChofer.SelectedRows.Count > 0)
            {
                string dni = dataGridViewChofer.SelectedRows[0].Cells["dni"].Value.ToString();

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
                            CargarDatosChofer(); // Actualizar el DataGridViewChofer
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

        private void dataGridViewChofer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewChofer.Rows[e.RowIndex];
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido1 = row.Cells["apellido1"].Value.ToString();
                string apellido2 = row.Cells["apellido2"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();
                string dni = row.Cells["dni"].Value.ToString();
                bool baja = Convert.ToBoolean(row.Cells["baja"].Value);

                ActualizarChofer actualizarChofer = new ActualizarChofer(nombre, apellido1, apellido2, telefono, dni, baja);
                actualizarChofer.ShowDialog();
                CargarDatosChofer(); // Actualizar el DataGridView después de cerrar el formulario
            }
        }

        private void textBoxChoferTelefono_TextChanged(object sender, EventArgs e)
        {
            if (textBoxChoferTelefono.Text.Length != 9)
            {
                textBoxChoferTelefono.BackColor = Color.Red;
            }
            else
            {
                textBoxChoferTelefono.BackColor = Color.White;
            }
        }

        private void textBoxChoferDni_TextChanged(object sender, EventArgs e)
        {
            if (textBoxChoferDni.Text.Length != 9)
            {
                textBoxChoferDni.BackColor = Color.Red;
            }
            else
            {
                textBoxChoferDni.BackColor = Color.White;
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                                                      //
        //                                                ventana chofer-camion                                                 //
        //                                                                                                                      //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CargarDatosAsignarCamion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = checkBoxAsignarCamion_MostrarLibres.Checked ?
                    "SELECT ca.marca, ca.modelo, ac.id_camion AS matricula, ch.nombre, ch.apellido1, ac.id_chofer AS dni, ac.f_inicio, ac.f_fin FROM chofer_camion ac JOIN camion ca ON ac.id_camion = ca.matricula JOIN chofer ch ON ac.id_chofer = ch.dni WHERE ac.f_fin IS NOT NULL" :
                    "SELECT ca.marca, ca.modelo, ac.id_camion AS matricula, ch.nombre, ch.apellido1, ac.id_chofer AS dni, ac.f_inicio, ac.f_fin FROM chofer_camion ac JOIN camion ca ON ac.id_camion = ca.matricula JOIN chofer ch ON ac.id_chofer = ch.dni WHERE ac.f_fin IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewAsignarCamion.DataSource = dt;
            }
        }

        private void CargarComboboxCamion()
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
                        comboBoxAsignarCamion_CamionId.Items.Add(reader["matricula"].ToString());
                    }
                }
            }
        }

        private void CargarComboboxChofer()
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
                        comboBoxAsignarCamion_ChoferId.Items.Add(reader["dni"].ToString());
                    }
                }
            }
        }

        private void buttonAsignarCamion_Submit_Click(object sender, EventArgs e)
        {
            string matricula = comboBoxAsignarCamion_CamionId.Text.ToUpper();
            string dni = comboBoxAsignarCamion_ChoferId.Text.ToUpper();

            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM chofer_camion WHERE id_camion = @id_camion AND f_fin IS NULL";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id_camion", matricula);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El camión ya está ocupado, revise los datos");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM chofer_camion WHERE id_chofer = @id_chofer AND f_fin IS NULL";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id_chofer", dni);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El chofer ya está ocupado, revise los datos");
                        return;
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO chofer_camion (id_chofer, id_camion, f_inicio) VALUES (@id_chofer, @id_camion, @f_inicio)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_chofer", dni);
                    command.Parameters.AddWithValue("@id_camion", matricula);
                    command.Parameters.AddWithValue("@f_inicio", DateTime.Now); // Asumiendo que f_inicio es la fecha actual

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente");
                        CargarDatosAsignarCamion();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos");
                    }
                }
            }
        }

        private void checkBoxAsignarCamion_MostrarLibres_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosAsignarCamion();
        }

    }
}


