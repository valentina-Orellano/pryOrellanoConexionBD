using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOrellanoConexionBD
{
    internal class clsConexion
    {
        public string cadenaConexion;

        public clsConexion()
        {
            cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        }

        public void MostrarDatos(DataGridView dgv)
        {
            try
            {
                string query = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId FROM Productos";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        public void CargarProductos(DataGridView dgv)
        {
            try
            {
                string query = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId FROM Productos";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        public void Agregar(clsProducto Producto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                   "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Producto.Descripcion);
                    comando.Parameters.AddWithValue("@Precio", Producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", Producto.Stock);
                    comando.Parameters.AddWithValue("@CategoriaId", Producto.CategoriaId);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        public void Modificar(clsProducto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, " +
                                   "Stock=@Stock, CategoriaId=@CategoriaId WHERE Codigo=@Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo modificar el producto: {error.Message}");
            }
        }

    }
}
