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
    public partial class frmAgregarLugar : Form
    {
        public frmAgregarLugar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion BBDD = new clsConexion();
                string nombreLugar = txtCompletar.Text.Trim();
                BBDD.AgregarTareaTipo(nombreLugar);
                MessageBox.Show("Lugar agregado correctamente");
                txtCompletar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lugar: " + ex.Message);
            }
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

        private void frmAgregarLugar_Load(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
