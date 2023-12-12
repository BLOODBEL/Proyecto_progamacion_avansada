using APIProyecto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIProyecto.Controllers
{
    public class FacturaController : Controller
    {

        [HttpPost]
        [Route("RegistrarFactura")]
        public string RegistrarFactura(Factura factura)
        {
            using (var context = new ProyectoPAEntities())
            {
                var datos = (from x in context.Factura
                             where x.IdUsuario == factura.IdUsuario
                                && x.IdSuscripcion == factura.IdSuscripcion
                             select x).FirstOrDefault();

                if (datos == null)
                {
                    context.Factura.Add(factura);
                    context.SaveChanges();
                }
                else
                {
                    datos.Cantidad = factura.Cantidad;
                    context.SaveChanges();
                }
                return "OK";
            }
        }

        [HttpGet]
        [Route("ConsultarFact")]
        public object ConsultarFact(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return (from x in context.Factura
                        join y in context.Suscripcion on x.IdSuscripcion equals y.IdSuscripcion
                        where x.IdUsuario == q
                        select new
                        {
                            x.IdFactura,
                            x.IdUsuario,
                            x.IdSuscripcion,
                            x.Cantidad,
                            x.FechaFactura,
                            y.descripcion,
                            y.Precio,
                            SubTotal = (y.Precio * x.Cantidad),
                            Impuesto = (y.Precio * x.Cantidad) * 0.13M,
                            Total = (y.Precio * x.Cantidad) + (y.Precio * x.Cantidad) * 0.13M
                        }).ToList();
            }
        }

        [HttpGet]
        [Route("ConsultaFacturas")]
        public List<Maestro> ConsultaFacturas(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return (from x in context.Maestro
                        where x.IdUsuario == q
                        select x).ToList();
            }
        }

        [HttpGet]
        [Route("ConsultaDetalleFactura")]
        public object ConsultaDetalleFactura(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return (from x in context.Detalle
                        join y in context.Suscripcion on x.IdSuscripcion equals y.IdSuscripcion
                        where x.IdMaestro == q
                        select new
                        {
                            x.IdMaestro,
                            y.descripcion,
                            x.PrecioPagado,
                            x.CantidadPagado,
                            x.ImpuestoPagado,
                            SubTotal = (x.PrecioPagado * x.CantidadPagado),
                            Impuesto = (x.ImpuestoPagado * x.CantidadPagado),
                            Total = (x.PrecioPagado * x.CantidadPagado) + (x.ImpuestoPagado * x.CantidadPagado),
                        }).ToList();
            }
        }

        [HttpDelete]
        [Route("EliminarRegistroFactura")]
        public void EliminarRegistroCarrito(long q)
        {
            using (var context = new ProyectoPAEntities())
            {
                var datos = (from x in context.Factura
                             where x.IdFactura == q
                             select x).FirstOrDefault();

                context.Factura.Remove(datos);
                context.SaveChanges();
            }
        }

    }
}