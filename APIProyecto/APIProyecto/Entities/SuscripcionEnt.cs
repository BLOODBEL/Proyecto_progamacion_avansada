using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class SuscripcionEnt
    {

        public long IdSuscripcion { get; set; }
        public string descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
     

      
    }
}