using MotherStoreBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.ArticleForm
{
    public interface IDataCategorieView
    {
       
        Categorie Categorie { get; set; }
        bool TopMost { get; set; }

        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler FormLoadEvent;      
        event EventHandler ListViewDoubleClick;
        event EventHandler ListViewClick;


        void LoadListView(List<Categorie> source);
       
        void Show();
        void BringToFront();
    }
}
