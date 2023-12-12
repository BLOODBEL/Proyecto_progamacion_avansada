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
        public long RegistrarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Suscripcion.Add(suscripcion);
                context.SaveChanges();
                return suscripcion.IdSuscripcion;
            }
        }


        [HttpGet]
        [Route("ConsultaSuscripciones")]
        public List<Suscripcion> ConsultaSuscripciones()
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Suscripcion.ToList();
            }
        }

        [HttpGet]
        [Route("ConsultaSuscripcion")]
        public Suscripcion ConsultaSuscripcion(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return (from x in context.Suscripcion
                        where x.IdSuscripcion == q
                        select x).FirstOrDefault();
            }
        }

      
        [HttpPut]
        [Route("ActualisarSuscripcion")]
        public string ActualisarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new ProyectoPAEntities())
            {
                var datos = context.Suscripcion.Where(x => x.IdSuscripcion == suscripcion.IdSuscripcion).FirstOrDefault();
                datos.descripcion = suscripcion.descripcion ;
                datos.FechaInicio = suscripcion.FechaInicio;
                datos.FechaFin = suscripcion.FechaFin;
                datos.Precio = suscripcion.Precio;
                context.SaveChanges();
                return "OK";
            }
        }
      
    }
}