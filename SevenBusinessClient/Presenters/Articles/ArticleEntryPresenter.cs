using Newtonsoft.Json;
using SevenApi.DataTransfertObject;
using SevenApi.Models;
using SevenBusinessClient.ApiService;
using SevenBusinessClient.Views.ArticleView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SevenBusinessClient.Presenters.Articles
{
    public class ArticleEntryPresenter
    {
        public string Action = "Creation";
        IArticleEntryView _view;
        RestApiService _service;
        Article _model;
        private static ArticleEntryPresenter Instance;
        BindingSource _bindingSource;
        public ArticleEntryPresenter(IArticleEntryView view,Article model,RestApiService service) {


            _service = service;
            _view = view;
            _model = model;

             _bindingSource = new BindingSource();
             WireEvents();
             //_view.SetCategorieComboBox(_bindingSource);

            if (model != null) { Action = "Modification"; }

            _view.BringToFront();
            _view.Show();
        
        }

        private ArticleCreateDto BuildArticleToCreate()
        {
           var categorie = _view.Categorie as Categorie;


            var articles = new ArticleCreateDto
            {
                Designation = _view.Designation,
                Description = _view.Description,
                PrixAchat = double.Parse(_view.PrixAchat),
                PrixVente = double.Parse(_view.PrixVente),
                Quantite = double.Parse(_view.Quantite),
                UniteVente = _view.UniteDeVente,

                Categorie = new CategorieUpdateDao
                {
                    Id = categorie.Id,
                    Reference = categorie.Reference,
                    DataVersion = categorie.DataVersion,
                    Name = categorie.Name

                }
            };



            return articles;
        }

        private ArticleUpdateDto BuildArticleToUpdate()
        {
            var categorie = _view.Categorie as Categorie;

            var articles = new ArticleUpdateDto
            {
                Id = _model.Id,
                Reference = _view.Reference,
                Designation = _view.Designation,
                Description = _view.Designation,
                PrixAchat = double.Parse(_view.PrixAchat),
                PrixVente = double.Parse(_view.PrixVente),
                Quantite = double.Parse(_view.Quantite),
                UniteVente = _view.UniteDeVente,
                CategorieId = categorie.Id,

            };



            return articles;
        }
        private void WireEvents()
        {
            _view.SaveEvent += SaveEvent;
            _view.ShowAddCategorie += ShowSaisieCategorie;
            _view.FormLoadEvent += Load;
        }

        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {
                
                

                bool response = true;  // Appel HTTP POST
                if (Action == "Creation")
                {
                    var articles = BuildArticleToCreate();

                     response = await _service.PostDataAsync<ArticleCreateDto>("articles", articles);
                }

                else
                {
                    var articles = BuildArticleToUpdate();
                    response = await _service.PutDataAsync<ArticleUpdateDto>($"articles/{_model.Id}", articles);
                }

                // Vérification de la réponse
                if (response)
                {
                  
                    ToastNotification.ShowToast("Succès", $"Article ajouté avec succès ", Color.LimeGreen, 3000);
                    //MessageBox.Show($"Article ajouté avec succès : {result}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                 
                    ToastNotification.ShowToast("Erreur", $"Erreur lors de l'ajout de l'article ", Color.Red, 3000);
                    MessageBox.Show($"Erreur lors de l'ajout de l'article ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                
                // Gestion des exceptions
                ToastNotification.ShowToast("Exception", $"Une exception s'est produite : {ex.Message}", Color.Red, 3000);
                // MessageBox.Show($"Une exception s'est produite : {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCategorieCompleted()
        {
            try
            {

                var categories = await _service.GetAllDataAsync<Categorie>("categories");

                // Chargement des données dans le ListView
                _bindingSource.DataSource = categories;
                _view.SetCategorieComboBox(_bindingSource);
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
        private void Load(object? sender, EventArgs e)
        {
            GetCategorieCompleted();

            if (Action == "Modification")
            {

                _view.Reference = _model.Reference;
                _view.Description = _model.Description;
                _view.Designation= _model.Designation;
                _view.Quantite= _model.Quantite.ToString();
                _view.PrixAchat= _model.PrixAchat.ToString();
                _view.PrixVente= _model.PrixVente.ToString();
                _view.UniteDeVente = _model.UniteVente;
            }
        }

        private void ShowSaisieCategorie(object? sender, EventArgs e)
        {
            FrmSaisieCategorie frm = new FrmSaisieCategorie("Creation");
            //frm.Parent = this;
            GLOBALS.LoadForm(frm, true);
        }

        public static ArticleEntryPresenter GetInstance(IArticleEntryView view ,Article model,RestApiService restApiService)
        {
            Instance ??= new ArticleEntryPresenter(view, model, restApiService);
            return Instance;
        }
    }
}
