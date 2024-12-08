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
    public partial class FrmSaisieArticle : Form
    {
        private string action;

        public FrmSaisieArticle(string action)
        {
            InitializeComponent();
            this.action = action;
            button1.Text = "Ajouter";
            panel1.Visible = false;
            groupBox1.Location = new Point(12, 59);
        }

        public FrmSaisieArticle(string action, object _article)
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
            FrmSaisieCategorie frm = new FrmSaisieCategorie("Creation");
            //frm.Parent = this;
            frm.ShowDialog();
        }
    }
}
