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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        clsConexion conexion = new clsConexion();
        private void frmProductos_Load(object sender, EventArgs e)
        {
            conexion.MostrarDatos(dgvMostrara);
        }
    }
}
