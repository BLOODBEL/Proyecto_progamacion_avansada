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
    
    public partial class Factura
    {
        public long IdFactura { get; set; }
        public long IdUsuario { get; set; }
        public long IdSuscripcion { get; set; }
        public System.DateTime FechaFactura { get; set; }
    
        public virtual Suscripcion Suscripcion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
