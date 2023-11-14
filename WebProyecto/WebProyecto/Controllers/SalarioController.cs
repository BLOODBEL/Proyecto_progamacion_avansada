using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProyecto.Controllers
{
    public class SalarioController : Controller
    {
        [HttpGet]
        public ActionResult ConsultaSalario()
        {
            var datos = claseSalario.ConsultaSalario();
            return View(datos);
        }

        [HttpGet]
        public ActionResult ActualizarSalario(long q)
        {
            var datos = claseSalario.ConsultaSalario(q);

            return View(datos);
        }

    }