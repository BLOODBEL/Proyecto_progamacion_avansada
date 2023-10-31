using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea_1.Models;

namespace Tarea_1.Controllers
{
    public class HomeController : Controller
    {
        Usuario claseUsuario = new Usuario();

        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrarse()
        {
            return View();
        }



        public ActionResult contraseña()
        {
            return View();
        }



    }
}