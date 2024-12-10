using Newtonsoft.Json;
using SevenApi.Models;
using SevenBusinessClient.Views.ArticleForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SevenBusinessClient.Presenters.Articles
{
    public class DataArticlePresenter
    {
        private string _action;
        IDataArticleView _view;
        HttpClient _httpClient;
        public DataArticlePresenter(IDataArticleView view, HttpClient httpClient)
        {
            _view = view;
            _view.ListViewClick += lv_Click;
            _view.ListViewDoubleClick += lv_DoubleClick;
            _view.EditEvent += EditEvent;
            _view.AddEvent += AddEvent;
            _view.DeleteEvent += DeleteEvent;
            _view.FormLoadEvent += Load;
            _httpClient = httpClient;



            _view.Show();
        }

        private async void Load(object? sender, EventArgs e)
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

                // Chargement des données dans le ListView
               _view.LoadListView(articles);
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la récupération des articles : {httpEx.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"Erreur lors de l'analyse des données des articles : {jsonEx.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur inattendue est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddEvent(object? sender, EventArgs e)
        {
            _action = "Creation";

            SaisieArticleView frm = new SaisieArticleView(_action, _httpClient);
            GLOBALS.LoadForm(frm, true);
        }

        private void EditEvent(object? sender, EventArgs e)
        {
            _action = "Modification";

            _article = _view.LvArticle.SelectedItems[0].Tag as Article ?? new Article();


            SaisieArticleView frm = new SaisieArticleView(_action, _article, _httpClient);
            GLOBALS.LoadForm(frm, true);
        }

        private void lv_DoubleClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lv_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
