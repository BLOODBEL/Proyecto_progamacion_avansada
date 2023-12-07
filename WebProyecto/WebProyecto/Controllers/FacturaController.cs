using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class FacturaController : Controller
    {

        FacturaModel claseFactura = new FacturaModel();


     
        [HttpGet]
        public ActionResult RegistrarFactura()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarFactura(FacturaEnt entidad)
        {
            string respuesta = claseFactura.ConsultaFacturas(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }




        [HttpGet]
        public ActionResult ActualizarFactura(long q)
        {
            var datos = claseFactura.ConsultaFacturas(q);
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarFactura(FacturaEnt entidad)
        {
            string respuesta = claseFactura.ActualizarFacturas(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar la Factura";
                return View();
            }
        }


    }
}