using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class SuscripcionEnt
    {

        public long IdSuscripcion { get; set; }
        public string Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public long IdUsuario { get; set; }



    }
}