using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace Tarea_1.Controllers
{
    public class HomeController : Controller
    {
        UsuarioModel claseUsuario = new UsuarioModel();

        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrarse(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.RegistrarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("IniciarSesion", "Home");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        public ActionResult contraseña()
        {
            return View();
        }

        public ActionResult PerfilUsuario()
        {
            return View();
        }

    }
}