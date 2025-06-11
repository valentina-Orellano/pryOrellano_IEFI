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
    public partial class frmAgregarTarea : Form
    {
        public frmAgregarTarea()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                string nombreTarea = txtCompletar.Text.Trim();
                BBDD.AgregarTareaTipo(nombreTarea);
                MessageBox.Show("Tarea agregada correctamente.");
                txtCompletar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }
        }

        private void frmAgregarTarea_Load(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        public void ValidarDatos()
        {
            if (txtCompletar.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
    }
}
