using MotherStoreBusiness.Models;
using MotherStoreBusiness.Views.ArticleView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotherStoreBusiness
{
    public partial class CategorieEntryView : Form, ICategorieEntryView
    {
        private string _action;



        public CategorieEntryView()
        {
            InitializeComponent();
            AssociatedAndRaiseEvent();


        }


        public object CategorieParent { get => cmbCategorie.SelectedItem ?? new { }; set => cmbCategorie.SelectedItem = value; }
        public Categorie categorie { get => new Categorie
        {
            Name = txtName.Text,
            Reference = txtReference.Text,
        }; set { txtName.Text = value.Name; txtReference.Text = value.Reference; } }
        public string Action { get => _action; set => _action = value; }

        public event EventHandler SaveEvent;
        public event EventHandler FormLoadEvent;
        public event EventHandler ShowAddCategorie;

        public void AssociatedAndRaiseEvent()
        {
            btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            Load += delegate
            {
                if (Action == "Modifier")
                {

                    btnSave.Text = "Modifier";
                    panel1.Visible = true;
                    panel1.Enabled = false;
                    groupBox1.Location = new Point(23, 91);
                }
                else
                {

                    btnSave.Text = "Ajouter";
                    panel1.Visible = true;
                    groupBox1.Location = new Point(23, 59);
                }

                FormLoadEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public void SetCategorieComboBox(BindingSource source)
        {
            cmbCategorie.DataSource = source;
            cmbCategorie.DisplayMember = "Name";
            cmbCategorie.ValueMember = "Id";
        }
    }
}
