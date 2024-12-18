using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.ArticleView
{
    public interface IArticleEntryView
    {
         string Action { get; set; }
         string Reference { get; set; }
         string Designation { get; set; }
         object Categorie { get; set; }
         string Description { get; set; }
         string PrixVente { get; set; }
         string PrixAchat { get; set; }
         string Quantite { get; set; }
         string UniteDeVente { get; set; }

         string ActionName { get; set; }

        public bool TopMost { get; set; }

        event EventHandler SaveEvent;
         event EventHandler FormLoadEvent;
         event EventHandler ShowAddCategorie;

        void SetCategorieComboBox(BindingSource source);
        void Show();
        void BringToFront();
    }
}
