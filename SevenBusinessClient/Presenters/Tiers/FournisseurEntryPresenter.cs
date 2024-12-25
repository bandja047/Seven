using MotherStoreBO.DataTransfertObject;
using MotherStoreBO.Models;
using MotherStoreBusiness.ApiService;
using MotherStoreBusiness.Views.TiersView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Presenters.Tiers
{
    public class FournisseurEntryPresenter
    {
        private IFournisseurEntryView View { get; set; }
        public Fournisseur Models { get; set; }
        public RestApiService Service { get; set; }

        private static FournisseurEntryPresenter Instance { get; set; }

        public FournisseurEntryPresenter(IFournisseurEntryView view, Fournisseur models, RestApiService service)
        {
            View = view;
            Models = models;
            Service = service;

            View.Action = "Creation";

            if (Models != null)
            {
                View.Action = "Modification";
            }

            WireEvents();

            View.TopMost = true;
            View.BringToFront();

            View.Show();

        }

        private void WireEvents()
        {
            View.SaveEvent += SaveEvent;
            View.FormLoadEvent += Load;
        }

        private void Load(object? sender, EventArgs e)
        {
            


            if (View.Action == "Modification")
            {

                View.Fournisseur.Reference = Models.Reference ?? "";
                View.Fournisseur.Name = Models.Name ?? "";
                View.Fournisseur.Prenom =Models.Prenom ?? "";
                View.Fournisseur.Telephone = Models.Telephone ?? "";
                View.Fournisseur.Email = Models.Email ?? "";
                View.Fournisseur.Pays = Models.Pays ?? "";
                View.Fournisseur.Quartier = Models.Quartier ?? "";
                View.Fournisseur.Ville = Models.Pays ?? "";
                View.Fournisseur.CodePostale = Models.Quartier ?? "";



            }
        }
        private FournisseurCreateDto BuildModelsToCreate()
        {
            var f = View.Fournisseur;



            var fournisseur = new FournisseurCreateDto
            {
               
                Name = f.Name,
                Prenom = f.Prenom,
                Telephone = f.Telephone,
                Email = f.Email,
                Pays = f.Pays,
                Ville = f.Ville,
                CodePostale = f.CodePostale,
                Quartier = f.Quartier,
                DealaiLivraison = 2

            };



            return fournisseur;



            
        }

        private FournisseurUpdateDto BuildModelsToUpdate()
        {
            

            var fournisseur = new FournisseurUpdateDto
            {
                Id = Models.Id,
                Reference = Models.Reference,
                Name = Models.Name,
                Prenom   = Models.Prenom    ,
                Telephone = Models.Telephone,
                Email = Models.Email,
                Pays = Models.Pays,
                Ville = Models.Ville,
                Quartier = Models.Quartier,
                DealaiLivraison = 2

            };



            return fournisseur;
        }
        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {



                bool response = true;  // Appel HTTP POST
                if (View.Action == "Creation")
                {
                    var fournisseur = BuildModelsToCreate();

                    response = await Service.PostDataAsync<FournisseurCreateDto>("fournisseur", fournisseur);
                }

                else
                {
                    var fournisseur = BuildModelsToUpdate();
                    response = await Service.PutDataAsync<FournisseurUpdateDto>($"fournisseur/{Models.Id}", fournisseur);
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

        public static FournisseurEntryPresenter GetInstance(IFournisseurEntryView view, Fournisseur models, RestApiService service)
        {
            Instance = new FournisseurEntryPresenter(view, models, service);
            return Instance;
        }
    }
}
