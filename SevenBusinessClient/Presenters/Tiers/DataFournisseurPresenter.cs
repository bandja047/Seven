using MotherStoreBO.Models;
using MotherStoreBusiness.ApiService;
using MotherStoreBusiness.Presenters.Articles;
using MotherStoreBusiness.Views.TiersView;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Presenters.Tiers
{
    public class DataFournisseurPresenter
    {
        private IDataFournisseurView View { get; set; }
        public Fournisseur  Models { get; set; }
        public RestApiService  Service { get; set; }

        private static DataFournisseurPresenter Instance {get;set;}

        public DataFournisseurPresenter(IDataFournisseurView view,Fournisseur models,RestApiService service)
        {
            View = view;
            Models = models;
            Service = service;

            WireEvents();

            View.TopMost = true;
            View.BringToFront();
          
            View.Show();
           
        }

        private void WireEvents()
        {
            View.ListViewDoubleClick += lv_DoubleClick;
            View.EditEvent += EditEvent;
            View.AddEvent += AddEvent;
            View.DeleteEvent += DeleteEvent;
            View.FormLoadEvent += Load;
        }

        private void DeleteEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Load(object? sender, EventArgs e)
        {
            try
            {
                var fournisseur = await Service.GetAllDataAsync<Fournisseur>("fournisseur");

                View.LoadListView(fournisseur);
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


        private void AddEvent(object? sender, EventArgs e)
        {



            FournisseurEntryView frm = new FournisseurEntryView();
            FournisseurEntryPresenter.GetInstance(frm, null, Service);
        }

        private void EditEvent(object? sender, EventArgs e)
        {



            FournisseurEntryView frm = new FournisseurEntryView();
            FournisseurEntryPresenter.GetInstance(frm, View.Fournisseur, Service);
        }

        private void lv_DoubleClick(object? sender, EventArgs e)
        {



            FournisseurEntryView frm = new FournisseurEntryView();
            FournisseurEntryPresenter.GetInstance(frm, View.Fournisseur, Service);
        }
        public static DataFournisseurPresenter GetInstance(IDataFournisseurView view, Fournisseur models, RestApiService service)
        {
           Instance = new DataFournisseurPresenter(view, models, service);
            return Instance;
        }

    }
}
