using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel claseUsuario = new UsuarioModel();

        [HttpGet]
        public ActionResult ConsultaUsuarios()
        {
            var datos = claseUsuario.ConsultaUsuarios();
            return View(datos);
        }


        [HttpGet]
        public ActionResult ActualizarEstadoUsuario(long q)
        {
            var entidad = new UsuarioEnt();
            entidad.IdUsuario = q;

            string respuesta = claseUsuario.ActualizarEstadoUsuario(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaUsuarios", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido cambiar el estado del usuario";
                return View();
            }
        }


        [HttpGet]
        public ActionResult PerfilUsuario()
        {
            long q = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseUsuario.ConsultaUsuario(q);
            Session["Nombre"] = datos.Nombre;
            
            return View(datos);
        }

        [HttpPost]
        public ActionResult PerfilUsuario(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";
                
                return View();
            }
        }

        [HttpGet]
        public ActionResult ActualizarUsuario(long q)
        {
            var datos = claseUsuario.ConsultaUsuario(q);
           
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarUsuario(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaUsuarios", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";
                
                return View();
            }
        }

        /* ESTADISTICAS */

        [HttpGet]
        public ActionResult RegistrarEstadistica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarEstadistica(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.RegistrarEstadistica(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("VerEstadisticas", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        [HttpGet]
        public ActionResult VerEstadisticas()
        {
            var datos = claseUsuario.VerEstadisticas();
            return View(datos);
        }

        [HttpGet]
        public ActionResult VerEstadistica()
        {
            long q = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseUsuario.VerEstadistica(q);
            Session["IdUsuario"] = datos.IdUsuario;
            
            return View(datos);
        }

        [HttpPost]
        public ActionResult VerEstadistica(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarEstadistica(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar la estadística";
                return View();
            }
        }

        [HttpGet]
        public ActionResult ActualizarEstadistica(long q)
        {
            var datos = claseUsuario.VerEstadistica(q);
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarEstadistica(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarEstadistica(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("VerEstadisticas", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar la estadística";
                return View();
            }
        }



        /* CLASES */

[HttpGet]
public ActionResult RegistrarClase()
{
    return View();
}

[HttpPost]
public ActionResult RegistrarClase(ClaseEnt entidad)
{
    string respuesta = claseUsuario.RegistrarClase(entidad);

    if (respuesta == "OK")
    {
        return RedirectToAction("VerClases", "Usuario");
    }
    else
    {
        ViewBag.MensajeUsuario = "No se ha podido registrar la información";
        return View();
    }
}

[HttpGet]
public ActionResult VerClases()
{
    var datos = claseUsuario.VerClases();
    return View(datos);
}

[HttpGet]
public ActionResult ActualizarClase(long q)
{
    var datos = claseUsuario.VerClase(q);
    return View(datos);
}

[HttpPost]
public ActionResult ActualizarClase(ClaseEnt entidad)
{
    string respuesta = claseUsuario.ActualizarClase(entidad);

    if (respuesta == "OK")
    {
        return RedirectToAction("VerClases", "Usuario");
    }
    else
    {
        ViewBag.MensajeUsuario = "No se ha podido actualizar la clase";
        return View();
    }
}
    }
}
