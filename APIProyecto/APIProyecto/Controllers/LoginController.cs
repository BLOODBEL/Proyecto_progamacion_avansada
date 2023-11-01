using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APIProyecto.Controllers
{
    public class LoginController
    {

        [HttpPost]
        [Route("RegistrarCuenta")]
        public string RegistrarCuenta(UsuarioEnt entidad)
        {
            try
            {
                using (var context = new ProyectoPAEntities2())
                {
                    Usuario user = new Usuario();
                    user.Identificación = entidad.Identificación;
                    user.Nombre = entidad.Nombre;
                    user.Apellidos1 = entidad.Apellidos1;
                    user.Apellidos2 = entidad.Apellidos2;
                    user.CorreoElectronico = entidad.CorreoElectronico;
                    user.Contraseña = entidad.Contraseña;
                    user.Teléfono = entidad.Teléfono;
                    user.IdRol = (int?)entidad.IdRol;
                    user.Estado = entidad.Estado;
                  

                    context.Usuario.Add(user);
                    context.SaveChanges();

                    //context.InsertUsuario(entidad.Nombre, entidad.Apellidos1, entidad.Apellidos2, entidad.CorreoElectronico, entidad.Contraseña, entidad.Teléfono, entidad.IdRol, entidad.Identificación);
                    return "OK";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
            {
            }
        }
    }
}