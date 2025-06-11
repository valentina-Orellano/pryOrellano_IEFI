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
    public partial class frmInicio : Form
    {

        public string RolUsuario { get; set; }
        public string UsuarioN { get; set; }

        private int IdUsuario;
        public frmInicio(int idUsuario, string usuario, string rol)
        {
            InitializeComponent();
            this.FormClosing += frmInicio_FormClosing;
            IdUsuario = idUsuario;
            UsuarioN = usuario;
            RolUsuario = rol;
        }

      

        int tiempo = 0;
        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexion BBDD = new clsConexion();
            clsUsuario Iniciar = new clsUsuario();
            if (RolUsuario == "Administrador")
            {
                msAdministracion.Visible = true;
            }
            else
            {
                msAdministracion.Visible=false;
            }
            lblUsuario.Text = $"Usuario conectado: {UsuarioN}";
            tmContador.Start();
            tmFecha.Start();
        }

        private void tmContador_Tick(object sender, EventArgs e)
        {
            tiempo++;
            int minutos = tiempo / 60;
            int segundos = tiempo % 60;
            lblContador.Text = $"Tiempo conectado: {minutos:D2}:{segundos:D2}";
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmContador.Stop();
            TimeSpan tiempoSesion = TimeSpan.FromSeconds(tiempo);
            clsConexion conexion = new clsConexion();
            conexion.GuardarUltimaConexion(UsuarioN, tiempoSesion);
            conexion.ActualizarEstado(UsuarioN, "Inactivo");
        }

        private void tmFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void msAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        private void msUsuario_Click(object sender, EventArgs e)
        {
            frmAdministracionUsuario v = new frmAdministracionUsuario();
            v.ShowDialog();
        }

        private void registrarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarea v = new frmTarea(RolUsuario, UsuarioN);
            v.ShowDialog();
        }

        private void historialTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial v = new frmHistorial(IdUsuario);
            v.ShowDialog();
        }
    }
}
