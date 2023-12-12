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
    public class InscritoEnModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];

        public string Inscribir(InscritoEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "Inscribir";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<InscritoEnt> Inscripciones(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "Inscripciones?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<InscritoEnt>>().Result;
            }
        }
    }
}