using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Entities
{
    public class SalarioEnt
    {
        public long IdSalario { get; set; }
        public string Salario { get; set; }
        public string Descripcion { get; set; }
        public long IdUsuario { get; set; }
    }
}