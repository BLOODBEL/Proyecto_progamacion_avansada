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
    
    public partial class Direccion
    {
        public long IdDireccion { get; set; }
        public string Calle { get; set; }
        public string CodPostal { get; set; }
        public string OtraSena { get; set; }
        public long IdUsuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
