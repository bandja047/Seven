using MotherStoreBO.Models;
using System;

namespace MotherStoreBusiness.Views.TiersView
{
    public partial class DataFournisseursView : Form, IDataFournisseurView
    {
        private string _action = "Creation";

        private Fournisseur _fournisseur;
        public Fournisseur Fournisseur { get => _fournisseur; set => _fournisseur = value; }

        public void SetMdiParent (Form parentForm)
        {
            this.MdiParent = parentForm;
        }

        public event EventHandler FormLoadEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler ListViewDoubleClick;
        public event EventHandler ListViewClick;

        public DataFournisseursView()
        {
            InitializeComponent();
            AdjustColumnsWidth();
            //LvArticle.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            AssociatedAndRaiseEvent();
        }

        private void lvArticle_Resize(object sender, EventArgs e)
        {

            AdjustColumnsWidth();

        }
        private void AdjustColumnsWidth()
        {
            if (LvFournisseur.Columns.Count == 0) return;

            int totalWidth = LvFournisseur.ClientSize.Width;
            int columnWidth = totalWidth / LvFournisseur.Columns.Count;

            foreach (ColumnHeader column in LvFournisseur.Columns)
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

        public void AssociatedAndRaiseEvent()
        {
          
         
            LvFournisseur.Click += delegate {

                BtnModifier.Enabled = true;
                BtnSupprimer.Enabled = true;
                Fournisseur = LvFournisseur.SelectedItems[0].Tag as Fournisseur ?? new Fournisseur();

                ListViewClick?.Invoke(this, EventArgs.Empty);
            };

            LvFournisseur.DoubleClick += delegate {
                Fournisseur art = LvFournisseur.SelectedItems[0].Tag as Fournisseur ?? new Fournisseur();
                ListViewDoubleClick?.Invoke(this, EventArgs.Empty);
            };

            
            BtnAjouter.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            BtnModifier.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
           
            BtnSupprimer.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };

            this.Load += delegate { FormLoadEvent?.Invoke(this, EventArgs.Empty); };

        }


        public void LoadListView(List<Fournisseur> source)
        {
            LvFournisseur.BeginUpdate();
            foreach (Fournisseur item in source)
            {
                string[] vs = { item.Reference, item.Name, item.Prenom, item.Telephone,item.Email,item.Pays,item.Ville,item.Quartier,item.CodePostale };

                ListViewItem lv = new ListViewItem(vs) { Tag = item };

                LvFournisseur.Items.Add(lv);
            }

            LvFournisseur.EndUpdate();
        }
    }
}
