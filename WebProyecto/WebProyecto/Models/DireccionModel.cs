using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using WebProyecto.Entities;
using System.Configuration;

namespace WebProyecto.Models
{
    public class DireccionModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];

        public string RegistrarDireccion(DireccionEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "RegistrarDireccion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        public List<DireccionEnt> VerDirecciones()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "VerDirecciones";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<DireccionEnt>>().Result;
            }
        }

        public DireccionEnt VerDireccion(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "VerDireccion?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<DireccionEnt>().Result;
            }
        }

        public string ActualizarDireccion(DireccionEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarDireccion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
    }
}