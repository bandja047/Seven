using SevenBusinessClient.Presenters.Articles;
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
            IDataArticleView frm = new DataArticleView();
            DataArticlePresenter presenter = new DataArticlePresenter(frm,httpClient);
           
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
