using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOrellano_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int IntentosFallidos = 0;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();
            txtContraseña.PasswordChar = '*';
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            clsUsuario Inicio = new clsUsuario();
            clsConexion conexión = new clsConexion();
            Inicio.Usuario = txtUsuario.Text;
            Inicio.Contraseña = txtContraseña.Text;
            int idUsuario = conexión.Iniciar(Inicio);

            if (idUsuario>0)
            {
                //frmPrincipal principal = new frmPrincipal(idUsuario, Inicio.Usuario);
                frmInicio principal = new frmInicio();
                principal.UsuarioN=Inicio.Usuario;
                principal.RolUsuario = Inicio.Rol;
                principal.Show();
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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexión = new clsConexion();
                clsUsuario Inicio = new clsUsuario();
                Inicio.Usuario = txtUsuario.Text;
                Inicio.Contraseña = txtContraseña.Text;
                conexión.AgregarUsuario(Inicio);
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
                btnIniciar.Enabled = true;
                btnRegistro.Enabled = true;
            }
            else
            {
                btnRegistro.Enabled = false;
                btnIniciar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
