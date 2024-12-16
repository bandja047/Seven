using Newtonsoft.Json;
using SevenApi.DataTransfertObject;
using SevenApi.Models;
using SevenBusinessClient.Views.ArticleView;
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

namespace SevenBusinessClient
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
        public string ActionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
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



      


       

        private ArticleCreateDto BuildArticleToCreate()
        {
            var categorie = cmbCategorie.SelectedItem as Categorie;


            var articles = new ArticleCreateDto
            {
                Designation = txtDesignation.Text,
                Description = txtDescription.Text,
                PrixAchat = double.Parse(txtPrixAchat.Text),
                PrixVente = double.Parse(txtPrixVente.Text),
                Quantite = double.Parse(txtQuantite.Text),
                UniteVente = txtUv.Text,

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
            var categorie = cmbCategorie.SelectedItem as Categorie;


            var articles = new ArticleUpdateDto
            {
                Id = _article.Id,
                Reference = txtReference.Text,
                Designation = txtDesignation.Text,
                Description = txtDescription.Text,
                PrixAchat = double.Parse(txtPrixAchat.Text),
                PrixVente = double.Parse(txtPrixVente.Text),
                Quantite = double.Parse(txtQuantite.Text),
                UniteVente = txtUv.Text,
                CategorieId = categorie.Id,

            };



            return articles;
        }
       /* private async void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                btnAjouter.Cursor = Cursors.WaitCursor;
                // Configuration de HttpClient
                using HttpClient _httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:44332/api/")
                };
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Création de l'objet article


                HttpResponseMessage response = null;  // Appel HTTP POST
                if (action == "Creation")
                {
                    var articles = BuildArticleToCreate();
                    response = await _httpClient.PostAsJsonAsync("articles", articles);
                }

                else
                {
                    var articles = BuildArticleToUpdate();
                    response = await _httpClient.PutAsJsonAsync($"articles/{_article.Id}", articles);
                }

                // Vérification de la réponse
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    ToastNotification.ShowToast("Succès", $"Article ajouté avec succès ", Color.LimeGreen, 3000);
                    //MessageBox.Show($"Article ajouté avec succès : {result}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    ToastNotification.ShowToast("Erreur", $"Erreur lors de l'ajout de l'article : {response.StatusCode}\nDétails : {error}", Color.Red, 3000);
                    MessageBox.Show($"Erreur lors de l'ajout de l'article : {response.StatusCode}\nDétails : {error}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnAjouter.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                btnAjouter.Cursor = Cursors.Default;
                // Gestion des exceptions
                ToastNotification.ShowToast("Exception", $"Une exception s'est produite : {ex.Message}", Color.Red, 3000);
                // MessageBox.Show($"Une exception s'est produite : {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private async void GetCategorieCompleted()
        {
            try
            {

                _httpClient.DefaultRequestHeaders.Accept.Clear();

                // Appel à l'API et désérialisation de la réponse
                string response = await _httpClient.GetStringAsync("categories");

                var categories = JsonConvert.DeserializeObject<List<Categorie>>(response) ?? new List<Categorie>();

                // Chargement des données dans le ListView
               // LoadComboBox(categories);
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

        public void LoadComboBox(BindingSource  source)
        {

            cmbCategorie.DataSource = source;
            cmbCategorie.DisplayMember = "Name";
            cmbCategorie.ValueMember = "Id";


        }
       /* private void FrmSaisieArticle_Load(object sender, EventArgs e)
        {
            GetCategorieCompleted();

            if (action == "Modification")
            {

                txtReference.Text = _article.Reference;
                txtDescription.Text = _article.Description;
                txtDesignation.Text = _article.Designation;
                txtQuantite.Text = _article.Quantite.ToString();
                txtPrixAchat.Text = _article.PrixAchat.ToString();
                txtPrixVente.Text = _article.PrixVente.ToString();
                txtUv.Text = _article.UniteVente;
            }
        }*/

        public void SetCategorieComboBox(BindingSource source)
        {
            cmbCategorie.DataSource = source;
            cmbCategorie.DisplayMember = "Name";
            cmbCategorie.ValueMember = "Id";
        }
    }
}
