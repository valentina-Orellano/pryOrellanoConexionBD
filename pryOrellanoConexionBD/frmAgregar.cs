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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }
        

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
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
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescr.Text != ""&& numPrecio.Value > 0 && numStock.Value > 0)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProducto producto = new clsProducto();
                clsConexion BBDD = new clsConexion();

                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescr.Text;
                producto.Precio = Convert.ToInt32(numPrecio.Value);
                producto.Stock = Convert.ToInt32(numStock.Value);
                producto.CategoriaId = Convert.ToInt32(cmbCat.SelectedValue);

                BBDD.Agregar(producto);
                BBDD.CargarProductos(dgvMostrar);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se agrego el producto" + ex.Message);
            }
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescr.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            cmbCat.SelectedIndex = -1;
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
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

       
    }
}
