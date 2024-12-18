using Newtonsoft.Json;
using MotherStoreBusiness.Models;
using MotherStoreBusiness.Views.ArticleForm;

namespace MotherStoreBusiness
{
    public partial class DataArticleView : Form, IDataArticleView
    {
        private string _action = "Creation";



        private Article _article;

      

        public Article Article { get => _article; set => _article = value; }

        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler FormLoadEvent;        
        public event EventHandler ListViewDoubleClick;
        public event EventHandler ListViewClick;

        public DataArticleView()
        {
            InitializeComponent();
            AdjustColumnsWidth();
         

            AssociatedAndRaiseEvent();
        }

        private void AssociatedAndRaiseEvent()
        {
            BtnAjouter.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            BtnModifier.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            BtnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { FormLoadEvent?.Invoke(this, EventArgs.Empty); };
           
            LvArticle.Click += delegate {

                BtnModifier.Enabled = true;
                BtnDelete.Enabled = true;
                Article = LvArticle.SelectedItems[0].Tag as Article ?? new Article();

                ListViewClick?.Invoke(this, EventArgs.Empty);
            };

            LvArticle.DoubleClick += delegate {
                Article art = LvArticle.SelectedItems[0].Tag as Article ?? new Article();
                ListViewDoubleClick?. Invoke(this, EventArgs.Empty); };

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


        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
                btn.Cursor = Cursors.Hand;
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

