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
    public partial class FiltrarPaquetes : Form
    {

        private string connectionString = "Server=localhost;Database=EmpresaPaqueteria;Integrated Security=True;";


        public FiltrarPaquetes()
        {
            InitializeComponent();
        }

        private void radioButtonProducto_CheckedChanged(object sender, EventArgs e)
        {
            CargarComboboxData();
        }
        private void radioButtonProvincia_CheckedChanged(object sender, EventArgs e)
        {
            CargarComboboxData();
        }
        private void CargarComboboxData()
        {
            comboBoxFiltro.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (radioButtonProducto.Checked)
                {
                    // Obtener todos los productos únicos de la tabla paquete
                    string getProductosQuery = "SELECT DISTINCT producto FROM paquete";
                    using (SqlCommand getProductosCommand = new SqlCommand(getProductosQuery, connection))
                    {
                        SqlDataReader reader = getProductosCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["producto"].ToString());
                        }
                        reader.Close(); // Cerrar el DataReader
                    }
                }
                else if (radioButtonProvincia.Checked)
                {
                    // Obtener el nombre de las provincias de los productos únicos
                    string getProvinciasQuery = @"SELECT DISTINCT p.nombre FROM provincias p INNER JOIN paquete pa ON p.codigo_postal = pa.provincia";
                    using (SqlCommand getProvinciasCommand = new SqlCommand(getProvinciasQuery, connection))
                    {
                        SqlDataReader reader = getProvinciasCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxFiltro.Items.Add(reader["nombre"].ToString());
                        }
                        reader.Close(); // Cerrar el DataReader
                    }
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void checkBoxMostrarAsignados_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            String filtro = (String)comboBoxFiltro.Text;
            String campo = "";

            if (radioButtonProducto.Checked)
            {
                campo = "producto";
            }else if (radioButtonProvincia.Checked)
            {
                campo = "provincia";
            }

            if (String.IsNullOrEmpty(filtro) || string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Por favor, seleccione los datos a filtrar");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (radioButtonProvincia.Checked)
                {
                    string codigoProvinciaQuery = "Select codigo_postal from provincias where nombre = @nombre";
                    using(SqlCommand command = new SqlCommand(codigoProvinciaQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombre",filtro);
                        object result = command.ExecuteScalar();
                        if(result != null)
                        {
                            filtro = result.ToString();
                        }else
                        {
                            MessageBox.Show("Provincia no encontrada");
                            return;
                        }
                            
                    }
                }
                else if (radioButtonProducto.Checked)
                {
                    // Verificar que el producto existe
                    string checkProductoQuery = "SELECT COUNT(*) FROM paquete WHERE producto = @producto";
                    using (SqlCommand checkProductoCommand = new SqlCommand(checkProductoQuery, connection))
                    {
                        checkProductoCommand.Parameters.AddWithValue("@producto", filtro);
                        int productoCount = (int)checkProductoCommand.ExecuteScalar();
                        if (productoCount == 0)
                        {
                            MessageBox.Show("Producto no encontrado/no existente");
                            return;
                        }
                    }

                }

                string query = checkBoxMostrarAsignados.Checked ?
                    $"select * from paquete where {campo} LIKE @filtro and idLote is not null" :
                    $"select * from paquete where {campo} LIKE @filtro and idLote is null";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@filtro","%"+filtro+"%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFiltrarProducto.DataSource = dt;
                }
                connection.Close();
            }

        }

        
    }
}
