using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIProyecto.Controllers
{
    public class SuscripcionController : Controller
    {



        [HttpPost]
        [Route("RegistrarSuscripcion")]
        public string RegistrarSuscripcion(SuscripcionEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {

                    context.RegistrarSuscripcion(entidad.Precio, entidad.FechaFin, entidad.FechaInicio, entidad.IdSuscripcion, entidad.IdUsuario);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpGet]
        [Route("ConsultaSuscripciones")]
        public List<SuscripcionEnt> ConsultaSuscripciones()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Suscripcion
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<SuscripcionEnt>();
            }
        }
    
        [HttpGet]
        [Route("ConsultaSuscripcion")]
        public Rol ConsultaSuscripcion(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Suscripcion
                            where x.IdSuscripcion == q
                            select x).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        [HttpPut]
        [Route("ActualisarSuscripcion")]
        public string ActualisarSuscripcion(SuscripcionEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.ActualizarSuscripcion(entidad.IdSuscripcion, entidad.Precio, entidad.FechaInicio, entidad.FechaFin, entidad.IdUsuario);
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