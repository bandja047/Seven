using MotherStoreBO.Models;
using MotherStoreBusiness.Helpers;

namespace MotherStoreBusiness.Views.TiersView
{
    public partial class FournisseurEntryView : Form,IFournisseurEntryView
    {
        private FormState _action;

        public FournisseurEntryView()
        {
            InitializeComponent();
            AssociatedAndRaiseEvent();
           
        }

      

        public Fournisseur Fournisseur { get => new Fournisseur
        {
            Reference = txtReference.Text,
            Name = txtNom.Text,
            Prenom = txtPrenom.Text,
            Telephone = txtTelephone.Text,
            Email = txtEmail.Text,
            Ville = txtVille.Text,
            Quartier = txtQuartier.Text,
            CodePostale = txtCodePostale.Text,
            Pays = txtPays.Text,
        }; set {
               txtReference.Text = value.Reference;
                txtNom.Text = value.Name;
                txtPrenom.Text = value.Prenom;
                txtTelephone.Text = value.Telephone;
                txtEmail.Text = value.Email;
                txtPays.Text = value.Pays;
                txtVille.Text = value.Ville;
                txtQuartier.Text = value.Quartier;
                txtCodePostale.Text = value.CodePostale;

            } }

        public FormState Action { get => _action; set { _action = value; } }

        public event EventHandler SaveEvent;
        public event EventHandler FormLoadEvent;

        public void AssociatedAndRaiseEvent()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            Load += delegate {

                if (Action == FormState.Modification)
                {

                    btnSave.Text = "Modifier";
                    panel1.Visible = true;
                    panel1.Enabled = false;
                    groupBox1.Location = new Point(12, 118);
                }
                else
                {

                    btnSave.Text = "Ajouter";
                    panel1.Visible = false;
                    groupBox1.Location = new Point(12, 59);
                }

                FormLoadEvent.Invoke(this, EventArgs.Empty); };
        }

      
    }
}
