//------------------------------------------------------------------------------
// <auto-generated>
//
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIProyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estadisticas
    {
        public long IdEstadisticas { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public System.DateTime Fecha { get; set; }
        public long IdUsuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}