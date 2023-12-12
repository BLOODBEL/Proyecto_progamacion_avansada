using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace APIProyecto.Controllers
{
    public class SuscripcionController : Controller
    {



        [HttpPost]
        [Route("RegistrarSuscripcion")]
        public String RegistrarSuscripcion(SuscripcionEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
            {
                context.RegistrarSuscripcion(entidad.descripcion, entidad.Cantidad, entidad.Precio, entidad.IdSuscripcion);
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
        public List<Suscripcion> ConsultaSuscripciones()
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
                return new List<Suscripcion>();
            }
        }

        [HttpGet]
        [Route("ConsultaSuscripcion")]
        public Suscripcion ConsultaSuscripcion(long q)
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
                
                context.ActualizarSuscripcion(entidad.IdSuscripcion, entidad.descripcion, entidad.Cantidad, entidad.Precio);
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