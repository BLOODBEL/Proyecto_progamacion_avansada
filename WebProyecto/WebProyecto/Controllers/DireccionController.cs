using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class DireccionController : Controller
    {

        DireccionModel claseDireccion = new DireccionModel();

        [HttpGet]
        public ActionResult RegistrarDireccion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarDireccion(DireccionEnt entidad)
        {
            string respuesta = claseDireccion.RegistrarDireccion(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("VerDirecciones", "Direccion");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        [HttpGet]
        public ActionResult VerDirecciones()
        {
            var datos = claseDireccion.VerDirecciones();
            return View(datos);
        }

        [HttpGet]
        public ActionResult VerDireccion()
        {
            long q = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseDireccion.VerDireccion(q);
            Session["IdUsuario"] = datos.IdUsuario;

            return View(datos);
        }

        [HttpPost]
        public ActionResult VerDireccion(DireccionEnt entidad)
        {
            string respuesta = claseDireccion.ActualizarDireccion(entidad);

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
        public ActionResult ActualizarDireccion(long q)
        {
            var datos = claseDireccion.VerDireccion(q);
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarDireccion(DireccionEnt entidad)
        {
            string respuesta = claseDireccion.ActualizarDireccion(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("VerDirecciones", "Direccion");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar la estadística";
                return View();
            }
        }
    }
}