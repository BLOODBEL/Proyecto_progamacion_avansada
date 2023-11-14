using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class ClaseEnt

    {
        public long IdClase { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public long IdUsuario { get; set; }
    }
}