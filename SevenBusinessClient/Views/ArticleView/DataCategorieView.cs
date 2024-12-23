using Newtonsoft.Json;
using MotherStoreBusiness.Models;
using MotherStoreBusiness.Views.ArticleForm;

namespace MotherStoreBusiness
{
    public partial class DataCategorieView : Form, IDataCategorieView
    {
     



        private Categorie _categorie;

       

      

        public Categorie Categorie { get => _categorie; set => _categorie = value; }
       

        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler FormLoadEvent;        
        public event EventHandler ListViewDoubleClick;
        public event EventHandler ListViewClick;

        public DataCategorieView()
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
           
            LvCategorie.Click += delegate {

                BtnModifier.Enabled = true;
                BtnDelete.Enabled = true;
                Categorie = LvCategorie.SelectedItems[0].Tag as Categorie ?? new Categorie();

                ListViewClick?.Invoke(this, EventArgs.Empty);
            };

            LvCategorie.DoubleClick += delegate {
                Article art = LvCategorie.SelectedItems[0].Tag as Article ?? new Article();
                ListViewDoubleClick?. Invoke(this, EventArgs.Empty); };

        }

        private void lvArticle_Resize(object sender, EventArgs e)
        {

            AdjustColumnsWidth();

        }
        private void AdjustColumnsWidth()
        {
            if (LvCategorie.Columns.Count == 0) return;

            int totalWidth = LvCategorie.ClientSize.Width;
            int columnWidth = totalWidth / LvCategorie.Columns.Count;

            foreach (ColumnHeader column in LvCategorie.Columns)
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

      
       

        public void LoadListView(List<Categorie> source)
        {
            LvCategorie.BeginUpdate();

            foreach (Categorie item in source)
            {
                string[] vs = { item.Reference, item.Name, item.Description,item.ParentCategorieId?.ToString() ?? "" };

                ListViewItem lv = new ListViewItem(vs) { Tag = item };

                LvCategorie.Items.Add(lv);
            }

            LvCategorie.EndUpdate();
        }
    }
}

