using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOrellanoConexionBD
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            clsConexion BBDD = new clsConexion();
            BBDD.CargarProductos(dgvMostrar);
            btnEliminar.Enabled = false;
        }

        private void ValidarDatos()
        {
            if (numCodigo.Value > 0)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (int)numCodigo.Value;

                clsConexion BBDD = new clsConexion();
                BBDD.Eliminar(codigo);
                BBDD.CargarProductos(dgvMostrar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se elimino el producto");
            }
            numCodigo.Value = 0;



        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
