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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrar.Rows.Count == 0)
                {
                    MessageBox.Show("Primero debes completar los datos al formulario.");
                    return;
                }

                DataGridViewRow fila = dgvMostrar.Rows[0];

                clsTarea tarea = new clsTarea();
                clsConexion conexion = new clsConexion();

                tarea.IdUsuario = Convert.ToInt32(fila.Cells[0].Value);
                tarea.Usuario = fila.Cells[1].Value.ToString();
                tarea.Fecha = DateTime.Parse(fila.Cells[2].Value.ToString());
                tarea.TareaId = Convert.ToInt32(cmbTarea.SelectedValue);
                tarea.LugarId = Convert.ToInt32(cmbLugar.SelectedValue);
                tarea.Insumo = cbInsumo.Checked;
                tarea.Estudio = cbEstudio.Checked;
                tarea.Vacaciones = cbVacaciones.Checked;
                tarea.Enfermedad = cbEnfermedad.Checked;
                tarea.Salario = cbSalario.Checked;
                tarea.Recibo = cbRecibo.Checked;
                tarea.Comentario = txtComentario.Text;

                conexion.GrabarTarea(tarea);
                MessageBox.Show("Tarea grabada correctamente.");

               
                dgvMostrar.Rows.Clear();
                nmCodigo.Value = 0;
                txtUsuario.Clear();
                cmbLugar.SelectedIndex = -1;
                cmbTarea.SelectedIndex = -1;
                cbInsumo.Checked = false;
                cbEstudio.Checked = false;
                cbVacaciones.Checked = false;
                cbEnfermedad.Checked = false;
                cbSalario.Checked = false;
                cbRecibo.Checked = false;
                txtComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al grabar la tarea: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = null;
            dgvMostrar.Rows.Clear();
            nmCodigo.Value = 0;
            txtUsuario.Clear();
            cmbLugar.SelectedIndex = -1;
            cmbTarea.SelectedIndex = -1;
            cbInsumo.Checked = false;
            cbEstudio.Checked = false;
            cbVacaciones.Checked = false;
            cbEnfermedad.Checked = false;
            cbSalario.Checked = false;
            cbRecibo.Checked = false;
            txtComentario.Clear();
        }

        private void lblAgregarLugar_Click(object sender, EventArgs e)
        {

        }

        private void lblAgregarTarea_Click(object sender, EventArgs e)
        {

        }
    }
}
