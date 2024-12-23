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
using MotherStoreBusiness.Views.ArticleView;

namespace MotherStoreBusiness.Presenters.Articles
{
    public class DataCategoriePresenter : IDisposable
    {
        private string _action ="";
        public IDataCategorieView _view;
        public List<Categorie> Models { get; set; }

        RestApiService _service;
       
        public static DataCategoriePresenter? Instance;
      

        private void WireEvents()
        {
            _view.ListViewDoubleClick += lv_DoubleClick;
            _view.EditEvent += EditEvent;
            _view.AddEvent += AddEvent;
            _view.DeleteEvent += DeleteEvent;
            _view.FormLoadEvent += Load;
        }

        private DataCategoriePresenter(IDataCategorieView view, RestApiService service)
        {
            _view = view;

            Models = new List<Categorie>();
            _service = service;

             WireEvents();
            _view.TopMost = true;
            _view.BringToFront();
            _view.Show();
        }

      
        private async void Load(object? sender, EventArgs e)
        {
            try
            {
               var categories = await _service.GetAllDataAsync<Categorie>("categories");

               _view.LoadListView(categories);
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


           
            ICategorieEntryView frm = new CategorieEntryView();
            CategorieEntryPresenter.GetInstance(frm, null, _service);
        }

        private void EditEvent(object? sender, EventArgs e)
        {
           


            ICategorieEntryView frm = new CategorieEntryView();
            CategorieEntryPresenter.GetInstance(frm, _view.Categorie, _service);
        }

        private void lv_DoubleClick(object? sender, EventArgs e)
        {
           


            ICategorieEntryView frm = new CategorieEntryView();
            CategorieEntryPresenter.GetInstance(frm, _view.Categorie, _service);
        }

        public static DataCategoriePresenter GetInstance(IDataCategorieView view, RestApiService restApiService)
        {
            Instance = new DataCategoriePresenter(view, restApiService);
            return Instance;

        }

        public void Dispose()
        {
            Instance?.Dispose();
        }
    }
}
