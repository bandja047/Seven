using SevenBusinessClient.ApiService;
using SevenBusinessClient.Presenters.Articles;
using SevenBusinessClient.Views;
using SevenBusinessClient.Views.ArticleForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenBusinessClient
{
    public partial class MainForm : Form
    {
        HttpClient httpClient;
        public MainForm(HttpClient client)
        {
            InitializeComponent();
            httpClient = client;
            comboBox1.SelectedIndex = 0;
        }
        private void MnuArticle_Click(object sender, EventArgs e)
        {
            // Vérifie si le présentateur singleton existe
            if (DataArticlePresenter.Instance != null && DataArticlePresenter.Instance._view is Form existingView)
            {
                // Vérifie si la vue associée est déjà supprimée ou non

                // Si la vue existe, affichez-la simplement
                    IDataArticleView frm2 = new DataArticleView();
                DataArticlePresenter.Instance._view = frm2;
                LoadForm((DataArticleView)DataArticlePresenter.Instance._view);
                return;
                
            }

            // Si l'instance ou la vue n'existe pas, créez une nouvelle instance
            IDataArticleView frm = new DataArticleView();
            RestApiService service = new RestApiService(httpClient);
            var presenter = DataArticlePresenter.GetInstance(frm, service);

            // Chargez et configurez la vue
           // LoadForm((DataArticleView)presenter._view);

            DataArticleView frm1 = (DataArticleView)presenter._view;
            frm1.MdiParent = this.MdiParent;
            frm1.TopMost = true;
            frm1.BringToFront();
            frm1.Show();
        }

        private void MnuAchat_Click(object sender, EventArgs e)
        {
            FrmDataAchat frm = new FrmDataAchat();
            LoadForm(frm);
        }

        private void MnuVentes_Click(object sender, EventArgs e)
        {
            FrmDataVentes frm = new FrmDataVentes();
            LoadForm(frm);
        }

        private void mnuClient_Click(object sender, EventArgs e)
        {
            FrmDataClients frm = new FrmDataClients();
            LoadForm(frm);
        }

        private void mnuFournisseur_Click(object sender, EventArgs e)
        {
            FrmDataFournisseurs frm = new FrmDataFournisseurs();
            LoadForm(frm);
        }

       
        private void LoadForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.TopMost = true;
            frm.BringToFront();
            frm.Show();
        }

        private void lvBenefice_DrawColumnHeader(object sender,
       DrawListViewColumnHeaderEventArgs e)
        {
            int a = e.ColumnIndex;
            using (StringFormat sf = new StringFormat())
            {
                // Store the column text alignment, letting it default
                // to Left if it has not been set to Center or Right.
                switch (e.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case HorizontalAlignment.Right:
                        sf.Alignment = StringAlignment.Far;
                        break;
                }

                // Draw the standard header background.
                e.DrawBackground();

                // Draw the header text.
                using (Font headerFont =
                            new Font("Helvetica", 10, FontStyle.Bold))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds, sf);
                }
            }
            return;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load(object sender, EventArgs e)
        {

        }
    }
}
