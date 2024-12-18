namespace MotherStoreBusiness
{
    public partial class FrmSaisieFournisseur : Form
    {
        private string action;

        public FrmSaisieFournisseur(string action)
        {
            InitializeComponent();
            this.action = action;
            button1.Text = "Ajouter";
            panel1.Visible = false;
            groupBox1.Location = new Point(12, 59);
        }

        public FrmSaisieFournisseur(string action, object _article)
        {
            InitializeComponent();
            this.action = action;
            button1.Text = "Modifier";
            panel1.Visible = true;
            panel1.Enabled = false;
            groupBox1.Location = new Point(12, 118);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            CategorieEntryView frm = new CategorieEntryView();
            //frm.Parent = this;
            frm.ShowDialog();
        }
    }
}
