using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using WebProyecto.Entities;

namespace WebProyecto.Models
{
    public class RolModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];



        public string RegistrarRol(RolEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "RegistrarRol";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<RolEnt> ConsultaRoles()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaRoles";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<RolEnt>>().Result;
            }
        }

        public RolEnt ConsultaRol(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaRol?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<RolEnt>().Result;
            }
        }

        public string ActualizarRol (RolEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarRol";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

    }
}