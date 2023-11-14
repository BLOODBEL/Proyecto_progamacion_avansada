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

        public SalarioEnt ConsultaSalario(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaSalario?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<SalarioEnt>().Result;
            }
        }


        public List<SalarioEnt> ConsultaSalarios()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaSalarios";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<SalarioEnt>>().Result;
            }
        }


        public string RegistrarSalario(SalarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "RegistrarSalario";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }


        public string ActualizarSalario(SalarioEnt entidad)
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



        