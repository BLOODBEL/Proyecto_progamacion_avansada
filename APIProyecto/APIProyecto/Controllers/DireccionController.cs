using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class DireccionController : ApiController
    {
        [HttpPost]
        [Route("RegistrarDireccion")]
        public string RegistrarDireccion(DireccionEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.RegistrarDireccion(entidad.Calle, entidad.CodPostal, entidad.OtraSena, entidad.IdUsuario);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpGet]
        [Route("VerDirecciones")]
        public List<Direccion> VerDirecciones()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Direccion
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Direccion>();
            }
        }

        [HttpGet]
        [Route("VerDireccion")]
        public Direccion VerDireccion(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Direccion
                            where x.IdUsuario == q
                            select x).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("ActualizarDireccion")]
        public string ActualizarDireccion(DireccionEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.ActualizarDireccion(entidad.Calle, entidad.CodPostal, entidad.OtraSena, entidad.IdUsuario, entidad.IdDireccion);
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
