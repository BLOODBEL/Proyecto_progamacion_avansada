using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class SalarioController : Controller
    {
        SalarioModel claseSalario = new SalarioModel();

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

        [HttpPost]
        public ActionResult ActualizarSalario(SalariooEnt entidad)
        {
            string respuesta = claseSalario.ActualizarSalario(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaSalario", "Salario");
            }
            else
            {
                ViewBag.MensajeSalario = "+++++++++++++";
                
                return View();
            }
        }

}
    }
}
