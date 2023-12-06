using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class SalarioController : ApiController
    {
        [HttpGet]
        [Route("ConsultaSalarios")]
        public List<Salario> ConsultaSalarios()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Salario
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Salario>();
            }
        }
        [HttpGet]
        [Route("ConsultaSalario")]
        public Salario ConsultaSalario(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Salario
                            where x.idSalario == q
                            select x).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("RegistrarSalario")]
        public string RegistrarSalario(SalarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.RegistrarSalario(entidad.IdUsuario, entidad.Salario, entidad.Descripcion);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpPut]
        [Route("ActualizarSalario")]
        public string ActualizarSalario(SalarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.ActualizarSalario(entidad.IdSalario ,entidad.Salario, entidad.Descripcion);
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