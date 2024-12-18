using Newtonsoft.Json;
using MotherStoreBusiness.DataTransfertObject;
using MotherStoreBusiness.Models;
using MotherStoreBusiness.Views.ArticleView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherStoreBusiness
{
    public partial class ArticleEntryView : Form, IArticleEntryView
    {
        private string _action;
        private Article _article;
        private HttpClient _httpClient;
       

        public event EventHandler SaveEvent;
        public event EventHandler FormLoadEvent;
        public event EventHandler ShowAddCategorie;

        public string Reference { get => txtReference.Text; set => txtReference.Text = value; }
        public string Designation { get => txtDesignation.Text; set => txtDesignation.Text = value; }
        public object Categorie { get => cmbCategorie.SelectedItem ?? new {}; set => cmbCategorie.SelectedItem = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string PrixVente { get => txtPrixVente.Text; set => txtPrixVente.Text = value; }
        public string PrixAchat { get => txtPrixAchat.Text; set => txtPrixAchat.Text = value; }
        public string Quantite { get => txtQuantite.Text; set => txtQuantite.Text = value; }
        public string UniteDeVente { get => txtUv.Text; set => txtUv.Text = value; }
        public string Action { get => _action; set => _action = value; }
        public string ActionName { get => _action; set => _action = value; }

        
        public ArticleEntryView()
        {
            InitializeComponent();           
            AssociatedAndRaiseEvent();
        }

        private void AssociatedAndRaiseEvent()
        {
            btnAjouter.Click += delegate {

                btnAjouter.Cursor = Cursors.WaitCursor;
                SaveEvent?.Invoke(this, EventArgs.Empty);
                btnAjouter.Cursor = Cursors.Default;
            };
            Load += delegate {
                
                if(Action == "Creation")
                {
                    btnAjouter.Text = "Ajouter";
                    panel1.Visible = false;
                    groupBox1.Location = new Point(12, 59);
                }
                else
                {
                    btnAjouter.Text = "Modifier";
                    panel1.Visible = true;
                    panel1.Enabled = false;
                    groupBox1.Location = new Point(12, 118);
                }
                
                FormLoadEvent?.Invoke(this, EventArgs.Empty);
            
            };
            BtnAddCategorie.Click += delegate { ShowAddCategorie?.Invoke(this, EventArgs.Empty); };
        }


        public void SetCategorieComboBox(BindingSource source)
        {
            cmbCategorie.DataSource = source;
            cmbCategorie.DisplayMember = "Name";
            cmbCategorie.ValueMember = "Id";
        }
    }
}
