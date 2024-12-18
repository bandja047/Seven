using Newtonsoft.Json;
using MotherStoreBusiness.Models;
using MotherStoreBusiness.ApiService;
using MotherStoreBusiness.Views.ArticleForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Presenters.Articles
{
    public class DataArticlePresenter : IDisposable
    {
        private string _action ="";
        public IDataArticleView _view;
        HttpClient _httpClient;
        RestApiService _service;
       
        public static DataArticlePresenter Instance;
        private DataArticlePresenter(IDataArticleView view, HttpClient httpClient,RestApiService service)
        {
            _view = view;
           // _view.ListViewClick += lv_Click;
           
            _httpClient = httpClient;
            _service = service;

            WireEvents();

            /*_view.BringToFront();
            _view.Show();*/
        }

        private void WireEvents()
        {
            _view.ListViewDoubleClick += lv_DoubleClick;
            _view.EditEvent += EditEvent;
            _view.AddEvent += AddEvent;
            _view.DeleteEvent += DeleteEvent;
            _view.FormLoadEvent += Load;
        }

        private DataArticlePresenter(IDataArticleView view, RestApiService service)
        {
            _view = view;
           // _view.ListViewClick += lv_Click;
            _view.ListViewDoubleClick += lv_DoubleClick;
            _view.EditEvent += EditEvent;
            _view.AddEvent += AddEvent;
            _view.DeleteEvent += DeleteEvent;
            _view.FormLoadEvent += Load;
          
            _service = service;


            _view.BringToFront();
            _view.Show();
        }

      
        private async void Load(object? sender, EventArgs e)
        {
            try
            {
               var articles = await _service.GetAllDataAsync<Article>("articles");

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


            ArticleEntryView frm = new ArticleEntryView();

            ArticleEntryPresenter.GetInstance(frm, null, _service);
        }

        private void EditEvent(object? sender, EventArgs e)
        {
            _action = "Modification";


            ArticleEntryView frm = new ArticleEntryView();
            ArticleEntryPresenter.GetInstance(frm, _view.Article, _service);
        }

        private void lv_DoubleClick(object? sender, EventArgs e)
        {
            _action = "Modification";


            ArticleEntryView frm = new ArticleEntryView();
            ArticleEntryPresenter.GetInstance(frm, _view.Article, _service); 
        }

        public static DataArticlePresenter GetInstance(IDataArticleView view, RestApiService restApiService)
        {
            Instance = new DataArticlePresenter(view, restApiService);
            return Instance;

        }

        public void Dispose()
        {
            Instance?.Dispose();
        }
    }
}
