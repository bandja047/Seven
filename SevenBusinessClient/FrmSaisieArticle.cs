using Newtonsoft.Json;
using SevenApi.DataTransfertObject;
using SevenApi.Models;
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
    public partial class FrmSaisieArticle : Form
    {
        private string action;
        private Article _article;
        private HttpClient _httpClient;

        public FrmSaisieArticle(string action, HttpClient httpClient)
        {
            InitializeComponent();
            this.action = action;
            btnAjouter.Text = "Ajouter";
            panel1.Visible = false;
            groupBox1.Location = new Point(12, 59);
            _httpClient = httpClient;   
        }

        public FrmSaisieArticle(string action, Article article,HttpClient httpClient)
        {
            InitializeComponent();
            this.action = action;
            btnAjouter.Text = "Modifier";
            panel1.Visible = true;
            panel1.Enabled = false;
            groupBox1.Location = new Point(12, 118);
            _article = article;
            _httpClient = httpClient;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            FrmSaisieCategorie frm = new FrmSaisieCategorie("Creation");
            //frm.Parent = this;
            GLOBALS.LoadForm(frm,true);
        }


        private async void button1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("je m'affiche au premier plan");
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
                Id=_article.Id,
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
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
                    response = await _httpClient.PutAsJsonAsync($"articles/{_article.Id}",articles);
                }

                // Vérification de la réponse
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Article ajouté avec succès : {result}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Erreur lors de l'ajout de l'article : {response.StatusCode}\nDétails : {error}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Gestion des exceptions
                MessageBox.Show($"Une exception s'est produite : {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCategorieCompleted()
        {
            try
            {
               
                _httpClient.DefaultRequestHeaders.Accept.Clear();

                // Appel à l'API et désérialisation de la réponse
                string response = await _httpClient.GetStringAsync("categories");

                var categories = JsonConvert.DeserializeObject<List<Categorie>>(response) ?? new List<Categorie>();

                // Chargement des données dans le ListView
                    LoadComboBox(categories);
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

        public void LoadComboBox(List<Categorie> list)
        {
         
            cmbCategorie.DataSource = list;
            cmbCategorie.DisplayMember = "Name";
            cmbCategorie.ValueMember = "Id";

           
        }
        private void FrmSaisieArticle_Load(object sender, EventArgs e)
        {
            GetCategorieCompleted();

            if(action == "Modification")
            {
                
                txtReference.Text = _article.Reference;
                txtDescription.Text = _article.Description;
                txtDesignation.Text = _article.Designation;
                txtQuantite.Text=_article.Quantite.ToString();
                txtPrixAchat.Text=_article.PrixAchat.ToString();
                txtPrixVente.Text=_article.PrixVente.ToString();
                txtUv.Text =_article.UniteVente;
            }
        }
    }
}
