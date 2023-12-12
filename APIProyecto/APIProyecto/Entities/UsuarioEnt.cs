using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class UsuarioEnt
    {

        public long IdUsuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasenna { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string DescripcionRol { get; set; }

        /* ENT ESTADISTICAS */

        public long IdEstadisticas { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public DateTime Fecha { get; set; }


    }
}
