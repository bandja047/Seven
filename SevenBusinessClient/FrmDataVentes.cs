namespace SevenBusinessClient
{
    public partial class FrmDataVentes : Form
    {
        private string _action = "Creation";

        private object _article;
        public FrmDataVentes()
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
            if (LvVente.Columns.Count == 0) return;

            int totalWidth = LvVente.ClientSize.Width;
            int columnWidth = totalWidth / LvVente.Columns.Count;

            foreach (ColumnHeader column in LvVente.Columns)
            {

                column.Width = columnWidth;

            }


        }

        public void Ajouter_Click(object sender, EventArgs e)
        {
            _action = "Creation";

            FrmSaisieVente frm = new FrmSaisieVente(_action);
            GLOBALS.LoadForm(frm, true);
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            FrmSaisieVente frm = new FrmSaisieVente(_action, _article);
            GLOBALS.LoadForm(frm, true);
        }
    }
}
