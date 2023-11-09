using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioModel claseUsuario = new UsuarioModel();

        [HttpGet]
        public ActionResult ConsultaUsuarios()
        {
            long IdUsuario = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseUsuario.ConsultaUsuarios().Where(x => x.IdUsuario != IdUsuario);
            return View(datos);
        }


        [HttpGet]
        public ActionResult ActualizarEstadoUsuario(long q)
        {
            var entidad = new UsuarioEnt();
            entidad.IdUsuario = q;

            string respuesta = claseUsuario.ActualizarEstadoUsuario(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaUsuarios", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido cambiar el estado del usuario";
                return View();
            }
        }


        [HttpGet]
        public ActionResult PerfilUsuario()
        {
            long q = long.Parse(Session["IdUsuario"].ToString());
            var datos = claseUsuario.ConsultaUsuario(q);
            Session["Nombre"] = datos.Nombre;
            
            return View(datos);
        }

        [HttpPost]
        public ActionResult PerfilUsuario(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";
                
                return View();
            }
        }

        [HttpGet]
        public ActionResult ActualizarUsuario(long q)
        {
            var datos = claseUsuario.ConsultaUsuario(q);
           
            return View(datos);
        }

        [HttpPost]
        public ActionResult ActualizarUsuario(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.ActualizarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("ConsultaUsuarios", "Usuario");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido actualizar su información";
                
                return View();
            }
        }
    }
}