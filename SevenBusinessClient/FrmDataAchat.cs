using Newtonsoft.Json;
using MotherStoreBusiness.Models;
using System.Net.Http;

namespace MotherStoreBusiness
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

            FrmSaisieAchat frm = new FrmSaisieAchat(_action);
            GLOBALS.LoadForm(frm, true);
        }

        public void Modifier_Click(object sender, EventArgs e)
        {
            _action = "Modification";

            FrmSaisieAchat frm = new FrmSaisieAchat(_action, _article);
            GLOBALS.LoadForm(frm, true);
        }

        private void LvApprovisionnement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void FrmDataAchat_Load(object sender, EventArgs e)
        {
           
        }

      
    }
}
