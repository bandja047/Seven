using Newtonsoft.Json;
using MotherStoreBusiness.DataTransfertObject;
using MotherStoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MotherStoreBusiness
{
    public class NetWork
    {
       static  HttpClient _httpClient;
        HttpMethod _method;

        public static async Task<string> Post(string url, string content)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44332/api/");
            _httpClient.DefaultRequestHeaders .Accept.Clear ();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue ("application/json"));
            var articles = new ArticleCreateDto { 
            
                   Designation = "IPAD",
                   Description = "IPAD 12 GENERATION 25",
                   PrixAchat = 500000,
                   PrixVente = 8000000,
                   Quantite = 2,
                   UniteVente = "Pieces",
                   Categorie = new CategorieUpdateDto { 
                        Id = 2
                   }
            
            };
            var response = await _httpClient.PostAsJsonAsync("articles", articles);

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<List<Article>> Get(string url, string content)
        {
            _httpClient.BaseAddress = new Uri("https://localhost:7174/api/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            //_httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
           
            var response = await _httpClient.GetStringAsync("articles");

            return JsonConvert.DeserializeObject<List<Article>>(response)?? new List<Article>();
        }
    }
}
