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

        public FrmSaisieArticle(string action)
        {
            InitializeComponent();
            this.action = action;
            btnAjouter.Text = "Ajouter";
            panel1.Visible = false;
            groupBox1.Location = new Point(12, 59);
        }

        public FrmSaisieArticle(string action, Article article)
        {
            InitializeComponent();
            this.action = action;
            btnAjouter.Text = "Modifier";
            panel1.Visible = true;
            panel1.Enabled = false;
            groupBox1.Location = new Point(12, 118);
            _article = article;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            FrmSaisieCategorie frm = new FrmSaisieCategorie("Creation");
            //frm.Parent = this;
            frm.ShowDialog();
        }


        private async void button1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("je m'affiche au premier plan");
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
                var articles = new ArticleCreateDto
                {
                    Designation = "IPAD",
                    Description = "IPAD 12 GENERATION 25",
                    PrixAchat = 500000,
                    PrixVente = 8000000,
                    Quantite = 2,
                    UniteVente = "Pieces",
                    Categorie = new CategorieUpdateDao
                    {
                        Id = 2,
                        Reference = "",
                        DataVersion = 1,
                        Name = "",
                        ParentCategorieId = null
                    }
                };

                // Appel HTTP POST
                var response = await _httpClient.PostAsJsonAsync("articles", articles);

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

        private void FrmSaisieArticle_Load(object sender, EventArgs e)
        {
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
