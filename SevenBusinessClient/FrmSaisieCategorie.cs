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
    public partial class FrmSaisieCategorie : Form
    {
        private string action;



        public FrmSaisieCategorie(string action)
        {
            InitializeComponent();
            this.action = action;
            button1.Text = "Ajouter";
            panel1.Visible = false;
            groupBox1.Location = new Point(12, 59);
        }

        public FrmSaisieCategorie(string action, object _article)
        {
            InitializeComponent();
            this.action = action;
            button1.Text = "Modifier";
            panel1.Visible = true;
            panel1.Enabled = false;
            groupBox1.Location = new Point(12, 118);

        }

       
    }
}
