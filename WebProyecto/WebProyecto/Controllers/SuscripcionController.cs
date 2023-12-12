using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class SuscripcionController : Controller
    {

        SuscripcionModel claseSuscripcion = new SuscripcionModel();
        FacturaModel claseFactura = new FacturaModel();

        [HttpGet]
        public ActionResult RegistrarSuscripcion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarSuscripcion(SuscripcionEnt entidad)
        {
            string IdSuscripcion = claseSuscripcion.RegistrarSuscripcion(entidad);

            if (IdSuscripcion == "OK")
            {
                return RedirectToAction("ConsultaFacturas","suscripcion");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }


        [HttpGet]
        public ActionResult ConsultaSuscripciones()
        {
            var datos = claseSuscripcion.ConsultaSuscripciones();
            return View(datos);
        }




        //[HttpGet]
        //public ActionResult ConsultaSuscripcion(long q)
        //{
        //    var datos = claseSuscripcion.ConsultaSuscripcion(q);
        //    return View(datos);
        //}

        //[HttpPost]
        //public ActionResult ConsultaSuscripcion(SuscripcionEnt entidad)
        //{
        //    string respuesta = claseSuscripcion.ConsultaSuscripcion(entidad);

        //    if (respuesta == "OK")
        //    {
        //        return RedirectToAction("ConsultaFacturas", "suscripcion");
        //    }
        //    else
        //    {
        //        ViewBag.MensajeUsuario = "No se ha podido actualizar la suscripcion";
        //        return View();
        //    }
        //}




    }
}