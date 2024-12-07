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
            CargarDatosPaquete();
            CargarComboboxCamion();
            CargarComboboxChofer();
            CargarComboboxProvincia();
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
                string query = checkBoxCamionesBaja.Checked ? "select * from camion where baja = 1" /*mostrar todos si está marcado checkbox*/ :
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
                string query = checkBoxChoferMostrarBajas.Checked ? "select * from chofer where baja = 1" /*mostrar todos si está marcado checkbox*/ :
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

                // Verificar si el camión existe
                string checkCamionQuery = "SELECT COUNT(*) FROM camion WHERE matricula = @matricula";
                using (SqlCommand checkCamionCommand = new SqlCommand(checkCamionQuery, connection))
                {
                    checkCamionCommand.Parameters.AddWithValue("@matricula", matricula);
                    int camionCount = (int)checkCamionCommand.ExecuteScalar();

                    if (camionCount == 0)
                    {
                        MessageBox.Show("El camión no existe. Por favor, revise los datos.");
                        return;
                    }
                }

                // Verificar si el chofer existe
                string checkChoferQuery = "SELECT COUNT(*) FROM chofer WHERE dni = @dni";
                using (SqlCommand checkChoferCommand = new SqlCommand(checkChoferQuery, connection))
                {
                    checkChoferCommand.Parameters.AddWithValue("@dni", dni);
                    int choferCount = (int)checkChoferCommand.ExecuteScalar();

                    if (choferCount == 0)
                    {
                        MessageBox.Show("El chofer no existe. Por favor, revise los datos.");
                        return;
                    }
                }

                // Verificar si el camión ya está ocupado
                string checkCamionOcupadoQuery = "SELECT COUNT(*) FROM chofer_camion WHERE id_camion = @id_camion AND f_fin IS NULL";
                using (SqlCommand checkCamionOcupadoCommand = new SqlCommand(checkCamionOcupadoQuery, connection))
                {
                    checkCamionOcupadoCommand.Parameters.AddWithValue("@id_camion", matricula);
                    int camionOcupadoCount = (int)checkCamionOcupadoCommand.ExecuteScalar();

                    if (camionOcupadoCount > 0)
                    {
                        MessageBox.Show("El camión ya está ocupado, revise los datos.");
                        return;
                    }
                }

                // Verificar si el chofer ya está ocupado
                string checkChoferOcupadoQuery = "SELECT COUNT(*) FROM chofer_camion WHERE id_chofer = @id_chofer AND f_fin IS NULL";
                using (SqlCommand checkChoferOcupadoCommand = new SqlCommand(checkChoferOcupadoQuery, connection))
                {
                    checkChoferOcupadoCommand.Parameters.AddWithValue("@id_chofer", dni);
                    int choferOcupadoCount = (int)checkChoferOcupadoCommand.ExecuteScalar();

                    if (choferOcupadoCount > 0)
                    {
                        MessageBox.Show("El chofer ya está ocupado, revise los datos.");
                        return;
                    }
                }

                // Insertar la nueva asignación
                string insertQuery = "INSERT INTO chofer_camion (id_chofer, id_camion, f_inicio) VALUES (@id_chofer, @id_camion, @f_inicio)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@id_chofer", dni);
                    insertCommand.Parameters.AddWithValue("@id_camion", matricula);
                    insertCommand.Parameters.AddWithValue("@f_inicio", DateTime.Now); // Asumiendo que f_inicio es la fecha actual

                    int result = insertCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos insertados correctamente.");
                        CargarDatosAsignarCamion();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos.");
                    }
                }
            }
        }


        private void checkBoxAsignarCamion_MostrarLibres_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosAsignarCamion();
        }

        private void buttonAsignarCamion_Liberar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsignarCamion.SelectedRows.Count > 0)
            {
                string matricula = dataGridViewAsignarCamion.SelectedRows[0].Cells["matricula"].Value.ToString();
                string dni = dataGridViewAsignarCamion.SelectedRows[0].Cells["dni"].Value.ToString();
                DateTime fInicio = (DateTime)dataGridViewAsignarCamion.SelectedRows[0].Cells["f_inicio"].Value;

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
                            CargarDatosAsignarCamion(); // Actualizar el DataGridViewAsignarCamion
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

        private void buttonAsignarCamion_Filtrar_Click(object sender, EventArgs e)
        {
            FiltrarAsignarChofer filtrarAsignarChofer = new FiltrarAsignarChofer();
            filtrarAsignarChofer.FormClosed += new FormClosedEventHandler(FiltrarAsignarChofer_FormClosed);
            filtrarAsignarChofer.ShowDialog();
        }

        private void FiltrarAsignarChofer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosAsignarCamion();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                                                      //
        //                                                   ventana paquete                                                    //
        //                                                                                                                      //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void CargarDatosPaquete()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = !checkBoxPaqueteAsignados.Checked ?
                    "Select id, producto, provincia, idLote from paquete where idLote is null":
                    "Select id, producto, provincia, idLote from paquete where idLote is not null";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

               dataGridViewPaquete.DataSource = dt;
            }
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
                        comboBoxPaqueteProvincia.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
            }
        }


        private void buttonPaqueteApañadir_Click(object sender, EventArgs e)
        {
            string producto = textBoxPaqueteProducto.Text.Trim().ToUpper();
            string nombreProvincia = comboBoxPaqueteProvincia.Text.Trim();

            if (string.IsNullOrEmpty(producto) || string.IsNullOrEmpty(nombreProvincia))
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el código postal de la provincia seleccionada
                string codigoPostal = "";
                string getCodigoPostalQuery = "SELECT codigo_postal FROM provincias WHERE nombre = @nombre";
                using (SqlCommand getCodigoPostalCommand = new SqlCommand(getCodigoPostalQuery, connection))
                {
                    getCodigoPostalCommand.Parameters.AddWithValue("@nombre", nombreProvincia);
                    SqlDataReader reader = getCodigoPostalCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        codigoPostal = reader["codigo_postal"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("La provincia seleccionada no existe. Por favor, revise los datos.");
                        return;
                    }
                    reader.Close();
                }

                // Obtener el valor máximo de 'id' en la tabla 'paquete'
                int nuevoId = 1;
                string maxIdQuery = "SELECT ISNULL(MAX(id), 0) FROM paquete";
                using (SqlCommand maxIdCommand = new SqlCommand(maxIdQuery, connection))
                {
                    int maxId = (int)maxIdCommand.ExecuteScalar();
                    nuevoId = maxId + 1;
                }

                // Insertar el nuevo paquete con el nuevo 'id'
                string insertQuery = "INSERT INTO paquete (id, producto, provincia) VALUES (@id, @producto, @provincia)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@id", nuevoId);
                    insertCommand.Parameters.AddWithValue("@producto", producto);
                    insertCommand.Parameters.AddWithValue("@provincia", codigoPostal);

                    int result = insertCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Paquete insertado correctamente.");
                        CargarDatosPaquete();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el paquete.");
                    }
                }
            }
        }

        private void checkBoxPaqueteNoAsignados_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosPaquete();
        }

        private void buttonPaqueteAsignar_Click(object sender, EventArgs e)
        {
            List<(int paqueteId, string provincia)> paquetes = new List<(int, string)>();

            if (dataGridViewPaquete.SelectedRows.Count > 0)
            {
                // Obtener el paquete seleccionado
                foreach (DataGridViewRow row in dataGridViewPaquete.SelectedRows)
                {
                    int paqueteId = (int)row.Cells["id"].Value;
                    string provincia = row.Cells["provincia"].Value.ToString();
                    paquetes.Add((paqueteId, provincia));
                }
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener todos los paquetes sin asignar
                    string getPaquetesQuery = "SELECT id, provincia FROM paquete WHERE idLote IS NULL";
                    using (SqlCommand getPaquetesCommand = new SqlCommand(getPaquetesQuery, connection))
                    {
                        SqlDataReader reader = getPaquetesCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            int paqueteId = (int)reader["id"];
                            string provincia = reader["provincia"].ToString();
                            paquetes.Add((paqueteId, provincia));
                        }
                        reader.Close(); // Cerrar el DataReader
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (var (paqueteId, provincia) in paquetes)
                {
                    // Verificar si existe un lote no enviado y con capacidad disponible para la provincia
                    int loteId = -1;
                    string getLoteQuery = "SELECT TOP 1 id FROM lote WHERE provinciaDestino = @provincia AND enviado = 0 AND capacidadMaxima < 20";
                    using (SqlCommand getLoteCommand = new SqlCommand(getLoteQuery, connection))
                    {
                        getLoteCommand.Parameters.AddWithValue("@provincia", provincia);
                        object result = getLoteCommand.ExecuteScalar();
                        if (result != null)
                        {
                            loteId = (int)result;
                        }
                    }

                    // Si no existe un lote, crear uno nuevo
                    if (loteId == -1)
                    {
                        // Obtener el valor máximo de 'id' en la tabla 'lote'
                        int nuevoLoteId = 1;
                        string maxLoteIdQuery = "SELECT ISNULL(MAX(id), 0) FROM lote";
                        using (SqlCommand maxLoteIdCommand = new SqlCommand(maxLoteIdQuery, connection))
                        {
                            int maxLoteId = (int)maxLoteIdCommand.ExecuteScalar();
                            nuevoLoteId = maxLoteId + 1;
                        }

                        string insertLoteQuery = "INSERT INTO lote (id, provinciaDestino, enviado, capacidadMaxima) VALUES (@id, @provincia, 0, 0)";
                        using (SqlCommand insertLoteCommand = new SqlCommand(insertLoteQuery, connection))
                        {
                            insertLoteCommand.Parameters.AddWithValue("@id", nuevoLoteId);
                            insertLoteCommand.Parameters.AddWithValue("@provincia", provincia);
                            insertLoteCommand.ExecuteNonQuery();
                            loteId = nuevoLoteId;
                        }
                    }

                    // Asignar el paquete al lote
                    string updatePaqueteQuery = "UPDATE paquete SET idLote = @loteId WHERE id = @paqueteId";
                    using (SqlCommand updatePaqueteCommand = new SqlCommand(updatePaqueteQuery, connection))
                    {
                        updatePaqueteCommand.Parameters.AddWithValue("@loteId", loteId);
                        updatePaqueteCommand.Parameters.AddWithValue("@paqueteId", paqueteId);
                        updatePaqueteCommand.ExecuteNonQuery();
                    }

                    // Incrementar la capacidad del lote
                    string updateLoteQuery = "UPDATE lote SET capacidadMaxima = capacidadMaxima + 1 WHERE id = @loteId";
                    using (SqlCommand updateLoteCommand = new SqlCommand(updateLoteQuery, connection))
                    {
                        updateLoteCommand.Parameters.AddWithValue("@loteId", loteId);
                        updateLoteCommand.ExecuteNonQuery();
                    }

                    // Verificar si el lote ha alcanzado su capacidad máxima
                    string checkLoteQuery = "SELECT capacidadMaxima FROM lote WHERE id = @loteId";
                    using (SqlCommand checkLoteCommand = new SqlCommand(checkLoteQuery, connection))
                    {
                        checkLoteCommand.Parameters.AddWithValue("@loteId", loteId);
                        int capacidadMaxima = (int)checkLoteCommand.ExecuteScalar();
                        if (capacidadMaxima >= 20)
                        {
                            string markLoteEnviadoQuery = "UPDATE lote SET enviado = 1 WHERE id = @loteId";
                            using (SqlCommand markLoteEnviadoCommand = new SqlCommand(markLoteEnviadoQuery, connection))
                            {
                                markLoteEnviadoCommand.Parameters.AddWithValue("@loteId", loteId);
                                markLoteEnviadoCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Actualizar los datos en el DataGridView
            CargarDatosPaquete();
        }


        private void buttonPaqueteFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarPaquetes filtrarPaquetes = new FiltrarPaquetes();
            filtrarPaquetes.FormClosed += new FormClosedEventHandler(FiltrarPaquetes_FormClosed);
            filtrarPaquetes.ShowDialog();
        }

        private void FiltrarPaquetes_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosPaquete();
        }
    }

}





