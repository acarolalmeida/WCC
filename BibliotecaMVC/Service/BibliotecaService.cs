using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace BibliotecaMVC.Service
{
    public class BibliotecaService
    {
        private const string url = "https://itunes.apple.com/search";
        private string termo = "";
        private string parametros = "";

        public Response BuscaLivro()
        {
            //string texto = "";
            Response retorno = null;
            parametros = $"?term=swift&entity=ibook";
            var newUrl = $"{url}{parametros}";

            HttpClient clientApi = new HttpClient
            {
                BaseAddress = new System.Uri(newUrl)
            };

            var resultado = clientApi.GetAsync(newUrl).Result;
            if(resultado.IsSuccessStatusCode)
            {
                //texto = resultado.Content.ReadAsStringAsync().Result;
                retorno = resultado.Content.ReadFromJsonAsync<Response>().Result;
            }
            
            clientApi.Dispose();
            return retorno;
        }
    }
}