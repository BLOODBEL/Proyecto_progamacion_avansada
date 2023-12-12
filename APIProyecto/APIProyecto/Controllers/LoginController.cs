using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class LoginController : ApiController
    {

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
                    //return (from x in context.TUsuario 
                    //             where x.Correo == entidad.Correo
                    //             && x.Contrasenna == entidad.Contrasenna
                    //             && x.Estado == true
                    //             select x).FirstOrDefault();

                    return context.IniciarSesion(entidad.CorreoElectronico, entidad.Contrasenna).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("RecuperarCuenta")]
        public string RecuperarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {

                    var datos = context.RecuperarCuenta(entidad.Identificacion).FirstOrDefault();


                    if (datos != null)
                    {

                        string contenido = "Estimado(a)" + datos.nombre + ".Contraseña " + datos.Contrasenna;



                        util.EnviarCorreo(datos.CorreoElectronico, "Contraseña de acceso ", contenido);

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