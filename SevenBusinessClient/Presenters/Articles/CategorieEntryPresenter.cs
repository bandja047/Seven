using MotherStoreBusiness.ApiService;
using MotherStoreBusiness.DataTransfertObject;
using MotherStoreBusiness.Models;
using MotherStoreBusiness.Views.ArticleForm;
using MotherStoreBusiness.Views.ArticleView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherStoreBusiness.Presenters.Articles
{
    public class CategorieEntryPresenter
    {
        public Categorie Model { get; set; }
        public RestApiService Service { get; set; }
        public ICategorieEntryView View { get; set; }
        public static CategorieEntryPresenter Instance { get; private set; }
        BindingSource _bindingSource;
        private CategorieEntryPresenter(ICategorieEntryView view,Categorie model,RestApiService service)
        {
            Model = model;
            Service = service;
            View = view;

            _bindingSource = new BindingSource();
            view.Action = "Creation";

            if (model != null) {
                view.Action = "Modification";
            }

            WireEvent();

            view.TopMost = true;
            view.BringToFront();
            view.Show();
        }

        private void WireEvent()
        {
            View.SaveEvent += SaveEvent;
            View.FormLoadEvent += Load;
        }

        private void Load(object? sender, EventArgs e)
        {
            GetCategorieCompleted();

            if(View.Action == "Modification")
            {
                var categorie = new Categorie
                {
                    Name = Model.Name,
                    Reference = Model.Reference,
                    Id = Model.Id,
                };

               View.categorie = categorie;
            }
        }

        private CategorieCreateDto BuilCategorieToCreate()
        {
             var parent = View.CategorieParent as Categorie;


            var categorie = new CategorieCreateDto
            {
                Name = View.categorie.Name,
                ParentCategorieId = parent?.Id
               
            };



            return categorie;
        }

        private CategorieUpdateDto BuildArticleToUpdate()
        {
            var parent = View.CategorieParent as Categorie;

            var articles = new CategorieUpdateDto
            {
                Name = View.categorie.Name,
                Id = Model.Id,
                ParentCategorieId = parent.Id,
                Reference = View.categorie.Reference,
              

            };



            return articles;
        }

        private async void GetCategorieCompleted()
        {
            try
            {

                var categories = await Service.GetAllDataAsync<Categorie>("categories");

                // Chargement des données dans le ListView
                _bindingSource.DataSource = categories;
                 View.SetCategorieComboBox(_bindingSource);
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
        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {



                bool response = true;  // Appel HTTP POST
                if (View.Action == "Creation")
                {
                    var categorie = BuilCategorieToCreate();

                    response = await Service.PostDataAsync<CategorieCreateDto>("Categories", categorie);
                }

                else
                {
                    var categorie = BuildArticleToUpdate();
                    response = await Service.PutDataAsync<CategorieUpdateDto>($"articles/{Model.Id}", categorie);
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

        public static CategorieEntryPresenter GetInstance(ICategorieEntryView view,Categorie model, RestApiService restApiService)
        {
            Instance = new CategorieEntryPresenter(view,model, restApiService);
            return Instance;

        }


    }
}
