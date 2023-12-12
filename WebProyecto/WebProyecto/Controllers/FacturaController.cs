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
        public ActionResult RegistrarFactura(long IdSuscripcion)
        {
            var entidad = new FacturaEnt();
            entidad.IdUsuario = long.Parse(Session["IdUsuario"].ToString());
            entidad.IdSuscripcion = IdSuscripcion;

            claseFactura.RegistrarFactura(entidad);
            entidad.FechaFactura = DateTime.Now;

            claseFactura.RegistrarFactura(entidad);

            var datos = claseFactura.ConsultarFact(long.Parse(Session["IdUsuario"].ToString()));
            Session["SunT"] = datos.AsEnumerable().Sum(x => x.SubTotal);
            
                return Json("OK", JsonRequestBehavior.AllowGet);
           
        }


        [HttpGet]
        public ActionResult ConsultarFact()
        {
            var datos = claseFactura.ConsultarFact(long.Parse(Session["IdUsuario"].ToString()));
            Session["TotalPago"] = datos.AsEnumerable().Sum(x => x.Total);
            return View(datos);
        }

        [HttpGet]
        public ActionResult ConsultaFacturas()
        {
            var datos = claseFactura.ConsultaFacturas(long.Parse(Session["IdUsuario"].ToString()));
            return View(datos);
        }
        [HttpGet]
        public ActionResult ConsultaDetalleFactura(long q)
        {
            var datos = claseFactura.ConsultaDetalleFactura(q);
            return View(datos);
        }
        [HttpGet]
        public ActionResult EliminarRegistroFactura(long q)
        {
            claseFactura.EliminarRegistroFactura(q);

            var datos = claseFactura.ConsultarFact(long.Parse(Session["IdUsuario"].ToString()));
           
            Session["SubT"] = datos.AsEnumerable().Sum(x => x.SubTotal);
            return RedirectToAction("ConsultarFact", "Factura");
        }

    }
}