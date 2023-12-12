using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web.Http;
using System.Net.Mail;

namespace APIProyecto.Controllers
{

    public class LoginController : ApiController
    {

        Utilitarios util = new Utilitarios();


        [HttpPost]
        [Route("Registrarse")]
        public string Registrarse(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {

                    context.RegistrarCuenta(entidad.Identificacion, entidad.Nombre, entidad.CorreoElectronico, entidad.Contrasenna, entidad.Telefono);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public IniciarSesion_Result IniciarSesion(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
             
                    return context.IniciarSesion(entidad.CorreoElectronico, entidad.Contrasenna).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        [HttpGet]
        [Route("RecuperarCuenta")]
        public string RecuperarCuenta(string Identificacion)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    var datos = context.RecuperarCuenta(Identificacion).FirstOrDefault();

                    if (datos != null)
                    {
                        string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "Templates\\Contrasenna.html";
                        string html = File.ReadAllText(rutaArchivo);

                        html = html.Replace("@@Nombre", datos.nombre);
                        html = html.Replace("@@Contrasenna", datos.Contrasenna);

                        util.EnviarCorreo(datos.CorreoElectronico, "Contraseña de Acceso", html);
                        return "OK";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


    }
}
    