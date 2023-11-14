using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices.Internal;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using WebProyecto.Entities;
using System.Web.Mvc;

namespace WebProyecto.Models
{
    public class SalarioModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];


       

       
        public List<SalarioEnt> ConsultaSalario()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaSalario";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<UsuarioEnt>>().Result;
            }
        }

       

        public string ActualizarSalario(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarSalario";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

       

       


    }
}
