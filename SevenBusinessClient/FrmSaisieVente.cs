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
    public partial class FrmSaisieVente : Form
    {
        private string action;
        public FrmSaisieVente(string action)
        {
            InitializeComponent();

            this.action = action;

        }

        public FrmSaisieVente(string action, object _article)
        {
            InitializeComponent();

            this.action = action;


        }

        private void gbCategorie_Enter(object sender, EventArgs e)
        {

        }

        private void LvAchatProduits_Resize(object sender, EventArgs e)
        {

        }

        private void gbClients_Enter(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
