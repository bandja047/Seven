using MotherStoreBO.Models;
using MotherStoreBusiness.Views.TiersView;

namespace MotherStoreBusiness.Views.TiersView
{
    public partial class DataClientView : Form, IDataClientView
    {
        private string _action = "Creation";

        private Client _client;

        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler FormLoadEvent;
        public event EventHandler ListViewDoubleClick;
        public event EventHandler ListViewClick;

        public Client Client { get => _client; set => _client = value; }

        public DataClientView()
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

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
                btn.Cursor = Cursors.Hand;
        }
        private void AdjustColumnsWidth()
        {
            if (LvClient.Columns.Count == 0) return;

            int totalWidth = LvClient.ClientSize.Width;
            int columnWidth = totalWidth / LvClient.Columns.Count;

            foreach (ColumnHeader column in LvClient.Columns)
            {

                column.Width = columnWidth;

            }


        }

      

        public void SetMdiParent(Form parentForm)
        {
            throw new NotImplementedException();
        }

        public void AssociatedAndRaiseEvent()
        {
          

            LvClient.Click += delegate {

                BtnSupprimer.Enabled = true;
                BtnSupprimer.Enabled = true;
                Client = LvClient.SelectedItems[0].Tag as Client ?? new Client();

                ListViewClick?.Invoke(this, EventArgs.Empty);
            };

            LvClient.DoubleClick += delegate {
                Client art = LvClient.SelectedItems[0].Tag as Client ?? new Client();
                ListViewDoubleClick?.Invoke(this, EventArgs.Empty);
            };

            Load += delegate { FormLoadEvent?.Invoke(this, EventArgs.Empty); };
            BtnAjouter.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            BtnSupprimer.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };

            BtnSupprimer.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void LoadListView(List<Client> source)
        {
            LvClient.BeginUpdate();
            foreach (Client item in source)
            {
                string[] vs = { item.Reference, item.Name, item.Prenom, item.Telephone, item.Email, item.Pays, item.Ville, item.Quartier, item.CodePostale };

                ListViewItem lv = new ListViewItem(vs) { Tag = item };

                LvClient.Items.Add(lv);
            }

            LvClient.EndUpdate();
        }
    }
}
