//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIProyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle
    {
        public long IdDetalle { get; set; }
        public long IdMaestro { get; set; }
        public long IdSuscripcion { get; set; }
        public decimal PrecioPagado { get; set; }
        public int CantidadPagado { get; set; }
        public decimal ImpuestoPagado { get; set; }
    
        public virtual Maestro Maestro { get; set; }
        public virtual Suscripcion Suscripcion { get; set; }
    }
}
