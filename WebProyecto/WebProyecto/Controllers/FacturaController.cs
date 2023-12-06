using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class FacturaController : Controller
    {

        FacturaModel claseFactura = new FacturaModel();



        [HttpGet]
        public ActionResult ConsultaUsuarios()
        {
            var datos = claseFactura.ConsultaFacturas();
            return View(datos);
        }





    }
}