using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class SalarioEnt

    {
        public long IdSalario { get; set; }
        public decimal Salario { get; set; }
        public string Descripcion { get; set; }
        public long IdUsuario { get; set; }

    }
}