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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int IntentosFallidos = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            txtContraseña.PasswordChar = '*';
            this.KeyPreview = true;
            btnEntrar.Enabled = false;
            btnRegistrarse.Enabled = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            clsLogin Inicio = new clsLogin();
            clsConexion conexión = new clsConexion();

            Inicio.Usuario = txtUsuario.Text;
            Inicio.Contraseña = txtContraseña.Text;
            bool InicioExitoso = conexión.Iniciar(Inicio);

            if (InicioExitoso)
            {
                frmInicio inicio = new frmInicio();
                inicio.Show();
                this.Hide();
            }
            else
            {

                IntentosFallidos++;

                MessageBox.Show($"Usuario o Contraseña incorrecto . Intento{IntentosFallidos} de 3");
            }
            if (IntentosFallidos >= 3)
            {
                MessageBox.Show("Demasiados intentos fallidos");
                Application.Exit();
            }
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexión = new clsConexion();
                clsLogin Inicio = new clsLogin();
                Inicio.Usuario = txtUsuario.Text;
                Inicio.Contraseña = txtContraseña.Text;
                conexión.AgregarUsuario(Inicio);
                MessageBox.Show("Usuario creado", "Proceso completo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se creo el usuario" + ex.Message);
            }
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        public void ValidarDatos()
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                btnEntrar.Enabled = true;
                btnRegistrarse.Enabled = true;
            }
            else
            {
                btnRegistrarse.Enabled = false;
                btnEntrar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
