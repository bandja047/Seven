using MotherStoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.ArticleView
{
    public interface ICategorieEntryView : IView
    {
        Categorie categorie { get; set; }

        event EventHandler SaveEvent;

        public object CategorieParent { get; set; }
        void SetCategorieComboBox(BindingSource source);
    }
}
