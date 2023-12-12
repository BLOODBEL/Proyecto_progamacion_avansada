using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Entities
{
    public class FactEnt
    {
        public long IdMaestro { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal TotalCompra { get; set; }


        public string descripcion { get; set; }
        public decimal PrecioPagado { get; set; }
        public int CantidadPagado { get; set; }
        public decimal ImpuestoPagado { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Impuesto { get; set; }

        public decimal Total { get; set; }
    }
}