using Newtonsoft.Json;
using SevenApi.Models;
using SevenBusinessClient.Views.ArticleForm;

namespace SevenBusinessClient
{
    public partial class DataArticleView : Form, IDataArticleView
    {
        private string _action = "Creation";

        private Article _article;

        HttpClient _httpClient;

        public Article Article { get => (Article)LvArticle.SelectedItems[0].Tag; set => value = LvArticle.SelectedItems[0].Tag; }

        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler FormLoadEvent;        
        public event EventHandler ListViewDoubleClick;
        public event EventHandler ListViewClick;

        public DataArticleView(HttpClient httpClient)
        {
            InitializeComponent();
            AdjustColumnsWidth();
            _httpClient = httpClient;

            AssociatedAndRaiseEvent();
        }

        private void AssociatedAndRaiseEvent()
        {
            BtnAjouter.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            BtnModifier.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { FormLoadEvent?.Invoke(this, EventArgs.Empty); };
            LvArticle.Click += delegate { ListViewClick?.Invoke(this, EventArgs.Empty); };
            LvArticle.DoubleClick += delegate { ListViewDoubleClick?. Invoke(this, EventArgs.Empty); };

        }

        private void lvArticle_Resize(object sender, EventArgs e)
        {

            AdjustColumnsWidth();

        }
        private void AdjustColumnsWidth()
        {
            if (LvArticle.Columns.Count == 0) return;

            int totalWidth = LvArticle.ClientSize.Width;
            int columnWidth = totalWidth / LvArticle.Columns.Count;

            foreach (ColumnHeader column in LvArticle.Columns)
            {

                column.Width = columnWidth;

            }


        }

        public void Ajouter_Click(object sender, EventArgs e)
        {
            _action = "Creation";

            SaisieArticleView frm = new SaisieArticleView(_action,_httpClient);
            GLOBALS.LoadForm(frm, true);
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            _article = LvArticle.SelectedItems[0].Tag as Article ?? new Article();


            SaisieArticleView frm = new SaisieArticleView(_action, _article ,_httpClient);
            GLOBALS.LoadForm(frm, true);
        }

        private async void FrmDataArticle_Load(object sender, EventArgs e)
        {
            try
            {
                /* HttpClient _httpClient = new HttpClient
                 {
                     BaseAddress = new Uri("https://localhost:44332/api/"),
                     Timeout = TimeSpan.FromSeconds(30) // Optionnel : définit un délai d'attente global
                 };*/
                // Utilisation de l'instance partagée de HttpClient
                _httpClient.DefaultRequestHeaders.Accept.Clear();

                // Appel à l'API et désérialisation de la réponse
                string response = await _httpClient.GetStringAsync("articles");
                var articles = JsonConvert.DeserializeObject<List<Article>>(response) ?? new List<Article>();

                // Chargement des données dans le ListView
                loadListView(articles);
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



        private void loadListView(List<Article> articles)
        {
            LvArticle.BeginUpdate();

            foreach (Article item in articles)
            {
                string[] vs = { item.Reference, item.Designation, item.Description, item.Quantite.ToString(), item.PrixVente.ToString(), item.PrixAchat.ToString(), item.UniteVente, item.CategorieId.ToString() };

                ListViewItem lv = new ListViewItem(vs) { Tag = item };

                LvArticle.Items.Add(lv);
            }

            LvArticle.EndUpdate();
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
                btn.Cursor = Cursors.Hand;
        }

        private void LvArticle_DoubleClick(object sender, EventArgs e)
        {
            _action = "Modification";

            _article = LvArticle.SelectedItems[0].Tag as Article ?? new Article();


            SaisieArticleView frm = new SaisieArticleView(_action, _article, _httpClient);
            GLOBALS.LoadForm(frm, true);
        }

        private void LvArticle_Click(object sender, EventArgs e)
        {
            BtnModifier.Enabled = true;
            BtnDelete.Enabled = true;
            ListView listView = (ListView)sender;
            Article art = listView.SelectedItems[0].Tag as Article ?? new Article();

          
        }

        public void LoadListView(List<Article> source)
        {
            LvArticle.BeginUpdate();

            foreach (Article item in source)
            {
                string[] vs = { item.Reference, item.Designation, item.Description, item.Quantite.ToString(), item.PrixVente.ToString(), item.PrixAchat.ToString(), item.UniteVente, item.CategorieId.ToString() };

                ListViewItem lv = new ListViewItem(vs) { Tag = item };

                LvArticle.Items.Add(lv);
            }

            LvArticle.EndUpdate();
        }
    }
}

