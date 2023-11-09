using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class UsuarioController : ApiController
    {

        [HttpGet]
        [Route("ConsultaUsuarios")]
        public List<Usuario> ConsultaUsuarios()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Usuario
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        [HttpGet]
        [Route("ConsultaUsuario")]
        public Usuario ConsultaUsuario(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Usuario
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
        [Route("ActualizarCuenta")]
        public string ActualizarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.ActualizarCuenta(entidad.Identificacion, entidad.Nombre, entidad.Apellidos1, entidad.Apellidos2, entidad.CorreoElectronico, entidad.Contrasenna, entidad.Telefono, entidad.IdUsuario);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpPut]
        [Route("ActualizarEstadoUsuario")]
        public string ActualizarEstadoUsuario(UsuarioEnt entidad)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.ActualizarEstadoUsuario(entidad.IdUsuario);
                return "OK";
            }
        }
    }
}