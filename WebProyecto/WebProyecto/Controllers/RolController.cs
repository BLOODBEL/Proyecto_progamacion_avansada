using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class RolController : Controller
    {
        RolModel claseRol = new RolModel();

        [HttpGet]
        public ActionResult RegistrarRol()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarRol(RolEnt entidad)
        {
            string respuesta = claseRol.RegistrarRol(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaRoles", "Rol");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }


        [HttpGet]
        public ActionResult ConsultaRoles()
        {
            var datos = claseRol.ConsultaRoles();
            return View(datos);
        }

        [HttpGet]
        public ActionResult ActualizarRol(long q)
        {
            var datos = claseRol.ConsultaRol(q);

            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarRol(RolEnt entidad)
        {
            string respuesta = claseRol.ActualizarRol(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaRoles", "Rol");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";

                return View();
            }
        }
    }
}