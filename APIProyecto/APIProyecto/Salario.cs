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
    
    public partial class Salario
    {
        public long idSalario { get; set; }
        public Nullable<decimal> salario1 { get; set; }
        public string descripcion { get; set; }
        public Nullable<long> idUsuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
