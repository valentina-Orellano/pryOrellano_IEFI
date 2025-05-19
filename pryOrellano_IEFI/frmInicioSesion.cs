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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin v = new frmLogin();
            v.Show();
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmPrincipal v = new frmPrincipal();
            v.Show();
            this.Close();
        }
    }
}
