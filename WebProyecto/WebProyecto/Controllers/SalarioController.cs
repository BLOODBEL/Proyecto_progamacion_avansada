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
        public ActionResult RegistrarSalario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarSalario(SalarioEnt entidad)
        {
            string respuesta = claseSalario.RegistrarSalario(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaSalarios", "Salario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }

        [HttpGet]
        public ActionResult ConsultaSalarios()
        {
            var datos = claseSalario.ConsultaSalarios();
            return View(datos);
        }

        [HttpGet]
        public ActionResult ConsultaSalario()
        {
            long q = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseSalario.ConsultaSalario(q);
            Session["IdUsuario"] = datos.IdUsuario;

            return View(datos);
        }

        [HttpPost]
        public ActionResult ConsultaSalario(SalarioEnt entidad)
        {
            string respuesta = claseSalario.ActualizarSalario(entidad);

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
        public ActionResult ActualizarSalario(long q)
        {
            var datos = claseSalario.ConsultaSalario(q);
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarSalario(SalarioEnt entidad)
        {
            string respuesta = claseSalario.ActualizarSalario(entidad);

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