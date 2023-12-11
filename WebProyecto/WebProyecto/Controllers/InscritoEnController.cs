using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class InscritoEnController : Controller
    {
        InscritoEnModel claseInscrito = new InscritoEnModel();

        [HttpGet]
        public ActionResult RegistrarCarrito(long IdClase)
        {
            var entidad = new InscritoEnt();
            entidad.IdUsuario = long.Parse(Session["IdUsuario"].ToString());
            entidad.IdClase = IdClase;

            claseInscrito.Inscribir(entidad);

            var datos = claseInscrito.Inscripciones(long.Parse(Session["IdUsuario"].ToString()));
             
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Inscripciones()
        {
            var datos = claseInscrito.Inscripciones(long.Parse(Session["IdUsuario"].ToString()));
            return View(datos);
        }
    }
}