﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProyecto.Entities;
using WebProyecto.Models;

namespace WebProyecto.Controllers
{
    public class LoginController : Controller
    {
        UsuarioModel claseUsuario = new UsuarioModel();



        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(UsuarioEnt entidad)
        {
            var respuesta = claseUsuario.IniciarSesion(entidad);

            if (respuesta != null)
            {
                Session["IdUsuario"] = respuesta.IdUsuario;
                Session["NombreUsuario"] = respuesta.Nombre;
                Session["DescripcionRol"] = respuesta.DescripcionRol;
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido validar su información";
                return View();
            }
        }



        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrarse(UsuarioEnt entidad)
        {

        entidad.Estado = true;

            string respuesta = claseUsuario.Registrarse(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido registrar su información";
                return View();
            }
        }
        [HttpGet]
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public ActionResult RecuperarCuenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarCuenta(UsuarioEnt entidad)
        {
            string respuesta = claseUsuario.RecuperarCuenta(entidad);

            if (respuesta == "OK")
            {
                return RedirectToAction("IniciarSesion", "Login");
            }
            else
            {
                ViewBag.MensajeUsuario = "No se ha podido recuperar su información";
                return View();
            }
        }

    }
}

    