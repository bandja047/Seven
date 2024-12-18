namespace MotherStoreBusiness
{
    public partial class FrmDataFournisseurs : Form
    {
        private string _action = "Creation";

        private object _article;
        public FrmDataFournisseurs()
        {
            InitializeComponent();
            AdjustColumnsWidth();
            //LvArticle.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        public void Ajouter_Click(object sender, EventArgs e)
        {
            _action = "Creation";

            FrmSaisieFournisseur frm = new FrmSaisieFournisseur(_action);
            GLOBALS.LoadForm(frm, true);
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            FrmSaisieFournisseur frm = new FrmSaisieFournisseur(_action, _article);
            GLOBALS.LoadForm(frm, true);
        }

        
    }
}
