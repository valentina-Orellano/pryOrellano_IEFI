using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryOrellano_IEFI
{
    public class clsUsuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public string  Dirección { get; set; }
        public string DNI { get; set; }
        public long Teléfono { get; set; }
        public string Gmail { get; set; }


        public DateTime FechaCreacion { get; set; }
        public DateTime UltimaConexion { get; set; }
        public TimeSpan TiempoUltimaConexion { get; set; }
        public TimeSpan TiempoTotal { get; set; }
        public string Estado { get; set; }
    }
}
