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

namespace pryOrellanoConexionBD
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            clsConexion BBDD = new clsConexion();
            BBDD.CargarProductos(dgvMostrar);
            using (SqlConnection conexion = new SqlConnection(BBDD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Categorias", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbCat.DataSource = dt;
                cmbCat.DisplayMember = "Nombre";
                cmbCat.ValueMember = "Id";


            }
            btnModificar.Enabled = false;
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != ""  && txtNombre.Text != "" && txtDescr.Text != "" && numPrecio.Value > 0 && numStock.Value > 0)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                clsProducto producto = new clsProducto();
                {
                    producto.Codigo = txtCodigo.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.Descripcion = txtDescr.Text;
                    producto.Precio = Convert.ToInt32(numPrecio.Value);
                    producto.Stock = Convert.ToInt32(numStock.Value);
                    producto.CategoriaId = Convert.ToInt32(cmbCat.SelectedValue);
                    BBDD.Modificar(producto);
                    BBDD.CargarProductos(dgvMostrar);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se modifico el producto");
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescr.Text = "";
            numPrecio.Value = 0;
            numStock.Value = 0;
            cmbCat.SelectedIndex = -1;



        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.SelectedIndex != -1)
            {
                btnModificar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
            }
        }
    }
}
