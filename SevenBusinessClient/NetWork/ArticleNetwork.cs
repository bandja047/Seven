using Newtonsoft.Json;
using SevenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenBusinessClient.NetWork
{
    public delegate void GetAllArticleEventHandler(object sender, GetAllArticleEventArgs e);

    public class GetAllArticleEventArgs : EventArgs
    {
        public List<Article> Articles;
        public GetAllArticleEventArgs(List<Article> articles)
        {
            Articles = articles;    
        }
    }
    public class ArticleNetwork
    {
        HttpClient _httpClient;
        public delegate void GetAllArticleEventHandler(object sender, GetAllArticleEventArgs e);
        event GetAllArticleEventHandler? ArticleCompleted;
        public ArticleNetwork(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void OnGetAllArticle(List<Article> articles)
        {
            ArticleCompleted?.Invoke(this, new GetAllArticleEventArgs(articles));
        }
        public async void GetAllArticles()
        {
            try
            {
                /* HttpClient _httpClient = new HttpClient
                 {
                     BaseAddress = new Uri("https://localhost:44332/api/"),
                     Timeout = TimeSpan.FromSeconds(30) // Optionnel : définit un délai d'attente global
                 };*/
                // Utilisation de l'instance partagée de HttpClient
                _httpClient.DefaultRequestHeaders.Accept.Clear();

                // Appel à l'API et désérialisation de la réponse
                string response = await _httpClient.GetStringAsync("articles");
                var articles = JsonConvert.DeserializeObject<List<Article>>(response) ?? new List<Article>();

                OnGetAllArticle(articles);
            }
            catch (HttpRequestException httpEx)
            {
                throw new HttpRequestException ($"Erreur lors de la récupération des articles : {httpEx.Message}");
            }
            catch (JsonException jsonEx)
            {
                throw new JsonException($"Erreur lors de l'analyse des données des articles : {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Une erreur inattendue est survenue : {ex.Message}");
            }
        }

       
    }
}
