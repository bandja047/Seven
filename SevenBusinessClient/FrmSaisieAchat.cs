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
    public partial class FrmSaisieAchat : Form
    {
        private string action;
        public FrmSaisieAchat(string action)
        {
            InitializeComponent();
           
            this.action = action;

        }

        public FrmSaisieAchat(string action, object _article)
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

      

      
    }
}
