﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProyecto.Entities
{
    public class RolEnt
    {
        public long IdRol { get; set; }
        public string Descripcion { get; set; }
        public long IdUsuario { get; set; }
    }
}