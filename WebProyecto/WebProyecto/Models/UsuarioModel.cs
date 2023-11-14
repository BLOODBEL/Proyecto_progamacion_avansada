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
    public class UsuarioModel
    {
        public string rutaServidor = ConfigurationManager.AppSettings["RutaApi"];


        public UsuarioEnt IniciarSesion(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "IniciarSesion";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<UsuarioEnt>().Result;
            }
        }

        public string Registrarse(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "Registrarse";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result; 
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<UsuarioEnt> ConsultaUsuarios()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaUsuarios";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<UsuarioEnt>>().Result;
            }
        }

        public UsuarioEnt ConsultaUsuario(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ConsultaUsuario?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<UsuarioEnt>().Result;
            }
        }

        public string ActualizarCuenta(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarCuenta";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public string ActualizarEstadoUsuario(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarEstadoUsuario";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        /* ESTADISTICAS */

        public string RegistrarEstadistica(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "RegistrarEstadistica";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PostAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        public List<UsuarioEnt> VerEstadisticas()
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "VerEstadisticas";
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<List<UsuarioEnt>>().Result;
            }
        }

        public UsuarioEnt VerEstadistica(long q)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "VerEstadistica?q=" + q;
                var res = client.GetAsync(urlApi).Result;
                return res.Content.ReadFromJsonAsync<UsuarioEnt>().Result;
            }
        }

        public string ActualizarEstadistica(UsuarioEnt entidad)
        {
            using (var client = new HttpClient())
            {
                var urlApi = rutaServidor + "ActualizarEstadistica";
                var jsonData = JsonContent.Create(entidad);
                var res = client.PutAsync(urlApi, jsonData).Result;
                return res.Content.ReadFromJsonAsync<string>().Result;
            }
        }
        /* CLASES */

public string RegistrarClase(ClaseEnt entidad)
{
    using (var client = new HttpClient())
    {
        var urlApi = rutaServidor + "RegistrarClase";
        var jsonData = JsonContent.Create(entidad);
        var res = client.PostAsync(urlApi, jsonData).Result;
        return res.Content.ReadFromJsonAsync<string>().Result;
    }
}
public List<ClaseEnt> VerClases()
{
    using (var client = new HttpClient())
    {
        var urlApi = rutaServidor + "VerClases";
        var res = client.GetAsync(urlApi).Result;
        return res.Content.ReadFromJsonAsync<List<ClaseEnt>>().Result;
    }
}

public ClaseEnt VerClase(long q)
{
    using (var client = new HttpClient())
    {
        var urlApi = rutaServidor + "VerClase?q=" + q;
        var res = client.GetAsync(urlApi).Result;
        return res.Content.ReadFromJsonAsync<ClaseEnt>().Result;
    }
}

public string ActualizarClase(ClaseEnt entidad)
{
    using (var client = new HttpClient())
    {
        var urlApi = rutaServidor + "ActualizarClase";
        var jsonData = JsonContent.Create(entidad);
        var res = client.PutAsync(urlApi, jsonData).Result;
        return res.Content.ReadFromJsonAsync<string>().Result;
    }
}

    }
}
