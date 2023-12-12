using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class InscritoEnt

    {
        public long IdInscritoEn { get; set; }
        public long IdClase { get; set; }
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}