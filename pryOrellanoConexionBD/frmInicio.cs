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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        
        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void verProuctosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos v = new frmProductos();
            v.ShowDialog();
        }


        private void modificarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificar v = new frmModificar();
            v.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEliminar v = new frmEliminar();
            v.ShowDialog();
        }

        private void agregarProductoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmAgregar v = new frmAgregar();
            v.ShowDialog();
        }
    }
}
