using MotherStoreBO.DataTransfertObject;
using MotherStoreBO.Models;
using MotherStoreBusiness.ApiService;
using MotherStoreBusiness.Helpers;
using MotherStoreBusiness.Views.TiersView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Presenters.Tiers
{
    public class ClientEntryPresenter
    {
        private IClientEntryView View { get; set; }
        public Client? Models { get; set; }
        public RestApiService Service { get; set; }

        private static ClientEntryPresenter Instance { get; set; }

        public ClientEntryPresenter(IClientEntryView view, Client? models, RestApiService service)
        {
            View = view;
            Models = models;
            Service = service;

            View.Action = FormState.Creation;

            if (Models != null)
            {
                View.Action = FormState.Modification;
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
            


            if (View.Action == FormState.Modification)
            {
                Client client = new Client();
                client.Reference = Models?.Reference ?? "";
                client.Name = Models?.Name ?? "";
                client.Prenom =Models?.Prenom ?? "";
                client.Telephone = Models?.Telephone ?? "";
                client.Email = Models?.Email ?? "";
                client.Pays = Models?.Pays ?? "";
                client.Quartier = Models?.Quartier ?? "";
                client.Ville = Models?.Pays ?? "";
                client.CodePostale = Models?.Quartier ?? "";

                View.Client = client;



            }
        }
        private ClientCreateDto BuildModelsToCreate()
        {
            var f = View.Client;



            var Client = new ClientCreateDto
            {
               
                Name = f.Name,
                Prenom = f.Prenom,
                Telephone = f.Telephone,
                Email = f.Email,
                Pays = f.Pays,
                Ville = f.Ville,
                CodePostale = f.CodePostale,
                Quartier = f.Quartier,
                LimiteDeCredit= f.LimiteDeCredit,
                ProgrammeFidelite = f.ProgrammeFidelite,
                Type = "Client",

            };



            return Client;



            
        }

        private ClientUpdateDto BuildModelsToUpdate()
        {


            var f = View.Client;



            var Client = new ClientUpdateDto
            {
                Id = Models?.Id??0,
                Reference = f.Reference,
                Name = f.Name,
                Prenom = f.Prenom,
                Telephone = f.Telephone,
                Email = f.Email,
                Pays = f.Pays,
                Ville = f.Ville,
                CodePostale = f.CodePostale,
                Quartier = f.Quartier,
                LimiteDeCredit = f.LimiteDeCredit,
                ProgrammeFidelite = f.ProgrammeFidelite,
                Type = "Client",

            };



            return Client;
        }
        private async void SaveEvent(object? sender, EventArgs e)
        {
            try
            {



                bool response = true;  // Appel HTTP POST
                if (View.Action == FormState.Creation)
                {
                    var Client = BuildModelsToCreate();

                    response = await Service.PostDataAsync<ClientCreateDto>("Client", Client);
                }

                else
                {
                    var Client = BuildModelsToUpdate();
                    response = await Service.PutDataAsync<ClientUpdateDto>($"Client/{Models.Id}", Client);
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

        public static ClientEntryPresenter GetInstance(IClientEntryView view, Client? models, RestApiService service)
        {
            Instance = new ClientEntryPresenter(view, models, service);
            return Instance;
        }
    }
}
