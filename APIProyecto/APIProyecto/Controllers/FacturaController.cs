using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIProyecto.Controllers
{
    public class FacturaController : Controller
    {

        [HttpGet]
        [Route("ConsultaFacturas")]
        public List<Factura> ConsultaFacturas()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Factura
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Factura>();
            }
        }
        [HttpGet]
        [Route("ConsultaFactura")]
        public Factura ConsultaFactura(long q)
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Factura
                            where x.IdFactura == q
                            select x).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }






    }
}