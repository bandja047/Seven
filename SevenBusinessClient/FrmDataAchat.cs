namespace SevenBusinessClient
{
    public partial class FrmDataAchat : Form
    {
        private string _action = "Creation";

        private object _article;
        public FrmDataAchat()
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
            if (LvApprovisionnement.Columns.Count == 0) return;

            int totalWidth = LvApprovisionnement.ClientSize.Width;
            int columnWidth = totalWidth / LvApprovisionnement.Columns.Count;

            foreach (ColumnHeader column in LvApprovisionnement.Columns)
            {

                column.Width = columnWidth;

            }


        }

        public void Ajouter_Click(object sender, EventArgs e)
        {
            _action = "Creation";

            FrmSaisieArticle frm = new FrmSaisieArticle(_action);
            frm.ShowDialog();
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            FrmSaisieArticle frm = new FrmSaisieArticle(_action, _article);
            frm.ShowDialog();
        }
    }
}
