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

namespace pryOrellano_IEFI
{
    public partial class frmTarea : Form
    {

        public string RolUsuario { get; set; }
        public string UsuarioN { get; set; }

        public frmTarea(string rol, string usuario)
        {
            InitializeComponent();
            RolUsuario = rol;
            UsuarioN = usuario;
        }
  
        private void frmTarea_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled= false;
            clsConexion BBDD = new clsConexion();
            BBDD.CargarTarea(dgvMostrar);
            using (SqlConnection conexion = new SqlConnection(BBDD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM TareasTipo", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbTarea.DataSource = dt;
                cmbTarea.DisplayMember = "Nombre";
                cmbTarea.ValueMember = "Id";
            }
            using (SqlConnection conexion = new SqlConnection(BBDD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre FROM Lugar", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbLugar.DataSource = dt;
                cmbLugar.DisplayMember = "Nombre";
                cmbLugar.ValueMember = "Id";
            }
            clsUsuario Iniciar = new clsUsuario();
            if (RolUsuario == "Administrador")
            {
                lblAgregarTarea.Visible = true;
                lblAgregarLugar.Visible = true;
            }
            else
            {
                lblAgregarTarea.Visible = false;
                lblAgregarLugar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvMostrar.DataSource != null)
                {
                    dgvMostrar.DataSource = null;
                }
                else
                {
                    dgvMostrar.Rows.Clear();
                }

                dgvMostrar.Rows.Add(
                    Convert.ToInt32(nmCodigo.Value),
                    txtUsuario.Text,
                    dtFecha.Value.ToShortDateString(),
                    cmbTarea.Text,  
                    cmbLugar.Text   
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se agregó la tarea: {ex.Message}");
            }
        }
    }
}
