using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class InscritoEnController : ApiController
    {
        [HttpPost]
        [Route("Inscribir")]
        public string Inscribir(InscritoEn InscritoEn)
        {
            using (var context = new ProyectoPAEntities())
            {
                var datos = (from x in context.InscritoEn
                             where x.IdUsuario == InscritoEn.IdUsuario
                                && x.IdClase == InscritoEn.IdClase
                             select x).FirstOrDefault();

                if (datos == null)
                {
                    context.InscritoEn.Add(InscritoEn);
                    context.SaveChanges();
                    return "OK";
                }
                else
                {       
                    return "NO";
                }
            }
        }

        [HttpPost]
        [Route("Inscripciones")]
        public object Inscripciones(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return (from x in context.InscritoEn
                        join y in context.Clase on x.IdClase equals y.IdClase
                        where x.IdUsuario == q
                        select new
                        {
                            x.IdInscritoEn,
                            x.IdUsuario,
                            x.IdClase,
                            y.Nombre,
                            y.Descripcion,
                        }).ToList();

            }
        }
    }
}
