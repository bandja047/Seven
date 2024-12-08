namespace SevenBusinessClient
{
    public partial class FrmDataClients : Form
    {
        private string _action = "Creation";

        private object _article;
        public FrmDataClients()
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
            if (LvClient.Columns.Count == 0) return;

            int totalWidth = LvClient.ClientSize.Width;
            int columnWidth = totalWidth / LvClient.Columns.Count;

            foreach (ColumnHeader column in LvClient.Columns)
            {

                column.Width = columnWidth;

            }


        }

        public void Ajouter_Click(object sender, EventArgs e)
        {
            _action = "Creation";

            FrmSaisieClient frm = new FrmSaisieClient(_action);
            GLOBALS.LoadForm(frm, true);
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            FrmSaisieClient frm = new FrmSaisieClient(_action, _article);
            GLOBALS.LoadForm(frm, true);
        }
    }
}
