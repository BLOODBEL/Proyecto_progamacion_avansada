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
                using (var context = new ProyectoPAEntities1())
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
                using (var context = new ProyectoPAEntities1())
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
                using (var context = new ProyectoPAEntities1())
                {
                    context.ActualizarCuenta(entidad.Identificacion, entidad.Nombre, entidad.Apellidos1, entidad.Apellidos2, entidad.CorreoElectronico, entidad.Telefono, entidad.IdUsuario);
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
            using (var context = new ProyectoPAEntities1())
            {
                context.ActualizarEstadoUsuario(entidad.IdUsuario);
                return "OK";
            }
        }

        /* ESTADISTICAS */

        [HttpPost]
        [Route("RegistrarEstadistica")]
        public string RegistrarEstadistica(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities1())
                {
                    context.RegistrarEstadistica(entidad.Altura, entidad.Peso, entidad.Fecha, entidad.IdUsuario);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpGet]
        [Route("VerEstadisticas")]
        public List<Estadisticas> VerEstadisticas()
        {
            try
            {
                using (var context = new ProyectoPAEntities1())
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
        [Route("VerEstadistica")]
        public Estadisticas VerEstadistica(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities1())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Estadisticas
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
        [Route("ActualizarEstadistica")]
        public string ActualizarEstadistica(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities1())
                {
                    context.ActualizarEstadistica(entidad.Altura, entidad.Peso, entidad.Fecha, entidad.IdUsuario, entidad.IdEstadisticas);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        /* CLASES */

[HttpPost]
[Route("RegistrarClase")]
public string RegistrarClase(ClaseEnt entidad)
{
    try
    {
        using (var context = new ProyectoPAEntities1())
        {
            context.RegistrarEstadistica(entidad.Nombre, entidad.Descripcion, entidad.IdUsuario);
            return "OK";
        }
    }
    catch (Exception)
    {
        return string.Empty;
    }
}

[HttpGet]
[Route("VerClases")]
public List<Clase> VerClases()
{
    try
    {
        using (var context = new ProyectoPAEntities1())
        {
            context.Configuration.LazyLoadingEnabled = false;
            return (from x in context.Clases
                    select x).ToList();
        }
    }
    catch (Exception)
    {
        return new List<Clase>();
    }
}

[HttpGet]
[Route("VerClases")]
public Clase VerClase(long q)
{
    try
    {
        using (var context = new ProyectoPAEntities1())
        {
            context.Configuration.LazyLoadingEnabled = false;
            return (from x in context.Clases
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
[Route("ActualizarClase")]
public string ActualizarClase(ClaseEnt entidad)
{
    try
    {
        using (var context = new ProyectoPAEntities1())
        {
            context.ActualizarEstadistica(entidad.Nombre, entidad.Descripcion, entidad.IdUsuario, entidad.IdClase);
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
