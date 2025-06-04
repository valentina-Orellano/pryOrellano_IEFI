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
    public partial class frmAdministracionUsuario : Form
    {
        public frmAdministracionUsuario()
        {
            InitializeComponent();
        }

       
        private void frmAdministracionUsuario_Load(object sender, EventArgs e)
        {
            clsConexion BBDD = new clsConexion();
            BBDD.CargarUsuarios(dgvMostrar);
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = cmbRol.Text;
                    Usuario.Estado = cmbEstado.Text;
                    Usuario.Dirección = txtDireccion.Text;
                    Usuario.DNI = txtDni.Text;
                    Usuario.Teléfono = int.Parse(txtTelf.Text);
                    Usuario.Gmail = txtGmail.Text;
                    BBDD.Agregar(Usuario);
                    BBDD.CargarUsuarios(dgvMostrar);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = cmbRol.Text;
                    Usuario.Estado = cmbEstado.Text;
                    Usuario.Dirección = txtDireccion.Text;
                    Usuario.DNI = txtDni.Text;
                    Usuario.Teléfono = int.Parse(txtTelf.Text);
                    Usuario.Gmail = txtGmail.Text;
                    BBDD.Modificar(Usuario);
                    BBDD.CargarUsuarios(dgvMostrar);
                    
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = cmbRol.Text;
                    Usuario.Estado = cmbEstado.Text;
                    Usuario.Dirección = txtDireccion.Text;
                    Usuario.DNI = txtDni.Text;
                    Usuario.Teléfono = int.Parse(txtTelf.Text);
                    Usuario.Gmail = txtGmail.Text;
                    BBDD.Eliminar(Usuario);
                    BBDD.CargarUsuarios(dgvMostrar);
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void validarDatos()
        {
            if(txtUsuario.Text != "" && txtContraseña.Text != "" && txtDireccion.Text != "" && txtDni.Text != "" && txtTelf.Text != "" && txtGmail.Text != "")
            {
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtTelf_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMostrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMostrar.Rows[e.RowIndex];
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                cmbRol.SelectedValue = Convert.ToInt32(fila.Cells["Rol"].Value);
                cmbEstado.SelectedValue = Convert.ToInt32(fila.Cells["Estado"].Value);
                txtDireccion.Text = fila.Cells["Dirección"].Value.ToString();
                txtDni.Text = fila.Cells["DNI"].Value.ToString();
                txtTelf.Text = fila.Cells["Teléfono"].Value.ToString();
                txtGmail.Text = fila.Cells["Gmail"].Value.ToString();
            }
        }
    }
}
