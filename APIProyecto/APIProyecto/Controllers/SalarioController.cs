using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIProyecto.Controllers
{
    public class SalarioController : Controller
    {
        [HttpGet]
        [Route("ConsultaSalario")]
        public List<Salario"> ConsultaSalario"()
        {
            try
            {
                using (var context = new ProyectoPAEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return (from x in context.Salario
                            select x).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Salario>();
            }
        }
[HttpPut]
[Route("ActualizarSalario)]
public string ActualizarSalario(SalarioEnt entidad)
{
    try
    {
        using (var context = new ProyectoPAEntities())
        {
            context.ActualizarSalario(entidad.Salario, entidad.Descripcion);
            return "OK";
        }
    }
    catch (Exception)
    {
        return string.Empty;
    }
}

    }