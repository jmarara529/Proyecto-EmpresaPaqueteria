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
    public partial class ActualizarChofer : Form
    {
        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";
        private string dniOriginal;
        public ActualizarChofer(String nombre, String apellido1, String apellido2, String telefono, String dni, bool baja)
        {
            InitializeComponent();
            textBoxNombre.Text = nombre;
            textBoxApellido1.Text = apellido1;
            textBoxApellido2.Text = apellido2;
            textBoxTelefono.Text = telefono;
            textBoxDni.Text = dni;
            checkBoxBaja.Checked = baja;
            dniOriginal = dni;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            string nombre = textBoxNombre.Text.Trim().ToUpper();
            string apellido1 = textBoxApellido1.Text.Trim().ToUpper();
            string apellido2 = textBoxApellido2.Text.Trim().ToUpper();
            string telefono = textBoxTelefono.Text.Trim().ToUpper();
            string dni = textBoxDni.Text.Trim().ToUpper();
            bool baja = checkBoxBaja.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si el dni ya existe y es diferente del original
                string checkQuery = "SELECT COUNT(*) FROM chofer WHERE dni = @dni AND dni != @dniOriginal";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@dni", dni);
                    checkCommand.Parameters.AddWithValue("@dniOriginal", dniOriginal);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("El DNI ya existe. Por favor, ingresa un DNI diferente.");
                        return;
                    }
                }

                // Actualizar los datos si el DNI no está duplicado
                string query = "UPDATE chofer SET nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2, telefono = @telefono, dni = @dni, baja = @baja WHERE dni = @dniOriginal";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@baja", baja ? 1 : 0);
                    command.Parameters.AddWithValue("@dniOriginal", dniOriginal);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos.");
                    }
                }
            }
        }
    }
}
