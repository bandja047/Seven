using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenBusinessClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MnuArticle_Click(object sender, EventArgs e)
        {
            FrmDataArticle frm = new FrmDataArticle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuAchat_Click(object sender, EventArgs e)
        {
            FrmDataAchat frm = new FrmDataAchat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuVentes_Click(object sender, EventArgs e)
        {
            FrmDataVentes frm = new FrmDataVentes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
