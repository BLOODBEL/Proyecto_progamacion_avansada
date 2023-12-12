using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class FacturaEnt
    {


        public long IdFactura { get; set; }
        public long IdUsuario { get; set; }
        public long IdSuscripcion { get; set; }
        public DateTime FechaFactura { get; set; }
        public string descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }


    }
}