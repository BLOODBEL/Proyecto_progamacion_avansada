using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Web;
using WebProyecto.Entities;
using System.Web.Mvc;

namespace WebProyecto.Models
{
    public class SuscripcionModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];





        public string RegistrarSuscripcion(SuscripcionEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "RegistrarSuscripcion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }


        public List<SuscripcionEnt> ConsultaSuscripciones()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaSuscripciones";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<SuscripcionEnt>>().Result;
            }
        }

        public SuscripcionEnt ConsultaSuscripcion(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaSuscripcion?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<SuscripcionEnt>().Result;
            }
        }




            public string ActualizarSuscripciones(SuscripcionEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarSuscripciones";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }


    }
}