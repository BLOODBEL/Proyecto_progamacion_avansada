using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Entities
{
    public class DireccionEnt
    {
        public long IdDireccion { get; set; }
        public string Calle { get; set; }
        public string CodPostal { get; set; }
        public string OtraSena { get; set; }
        public long IdUsuario { get; set; }
    }
}