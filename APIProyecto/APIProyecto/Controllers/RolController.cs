using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class RolController : ApiController

    {

        [HttpPost]
        [Route("RegistrarRol")]
        public string RegistrarRol(RolEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {

                    context.RegistrarRol(entidad.Descripcion);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }



        [HttpGet]
        [Route("ConsultaRoles")]
        public List<Estadisticas> ConsultaRoles()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Estadisticas
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Estadisticas>();
            }
        }

        [HttpGet]
        [Route("ConsultaRol")]
        public Rol ConsultaRol(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Rol
                            where x.IdRol == q
                            select x).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        [HttpPut]
        [Route("ActualizarRol")]
        public string ActualizarRol(RolEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.ActualizarRol(entidad.Descripcion,entidad.IdUsuario);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
