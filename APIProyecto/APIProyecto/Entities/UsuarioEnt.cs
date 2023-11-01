using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProyecto.Entities
{
    public class UsuarioEnt
    {

        public long IdUsuario { get; set; }
        public string Identificación { get; set; }
        public string Nombre { get; set; }
        public string Apellidos1 { get; set; }
        public string Apellidos2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public string Teléfono { get; set; }
        public bool Estado { get; set; }
        public long IdRol  { get; set; }

    }
}