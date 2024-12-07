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
    public partial class ActualizarCamion : Form
    {

        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";
        private string matriculaOriginal;

        public ActualizarCamion(string marca, string modelo, string matricula, bool baja)
        {
            InitializeComponent();
            textBoxCamionUpdateMarca.Text = marca;
            textBoxCamionUpdateModelo.Text = modelo;
            textBoxCamionUpdateMatricula.Text = matricula;
            checkBoxCamionUpdateBaja.Checked = baja;
            matriculaOriginal = matricula;
        }

        private void buttonCamionUpdateSubmit_Click(object sender, EventArgs e)
        {
            string marca = textBoxCamionUpdateMarca.Text.Trim().ToUpper();
            string modelo = textBoxCamionUpdateModelo.Text.Trim().ToUpper();
            string matricula = textBoxCamionUpdateMatricula.Text.Trim().ToUpper();
            bool baja = checkBoxCamionUpdateBaja.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si la nueva matrícula ya existe y es diferente de la matrícula original
                string checkQuery = "SELECT COUNT(*) FROM camion WHERE matricula = @matricula AND matricula != @matriculaOriginal";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@matricula", matricula);
                    checkCommand.Parameters.AddWithValue("@matriculaOriginal", matriculaOriginal);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("La matrícula ya existe. Por favor, ingresa una matrícula diferente.");
                        return;
                    }
                }

                // Actualizar los datos si la matrícula no está duplicada
                string query = "UPDATE camion SET marca = @marca, modelo = @modelo, matricula = @matricula, baja = @baja WHERE matricula = @matriculaOriginal";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@baja", baja ? 1 : 0);
                    command.Parameters.AddWithValue("@matriculaOriginal", matriculaOriginal);

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

