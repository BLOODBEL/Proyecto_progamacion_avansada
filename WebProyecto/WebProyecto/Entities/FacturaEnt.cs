using System;

namespace WebProyecto.Entities
{
    public class FacturaEnt
    {


        public long IdFactura { get; set; }
        public long IdSuscripcion { get; set; }
        public decimal Total { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }




    }
}
