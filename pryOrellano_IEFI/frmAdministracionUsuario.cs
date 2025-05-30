﻿using System;
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
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal=TimeSpan.Parse(mskTiempoTotal.Text);
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
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal = TimeSpan.Parse(mskTiempoTotal.Text);
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
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal = TimeSpan.Parse(mskTiempoTotal.Text);
                    BBDD.Eliminar(Usuario);
                    BBDD.CargarUsuarios(dgvMostrar);
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
