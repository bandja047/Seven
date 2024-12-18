using MotherStoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.ArticleForm
{
    public interface IDataArticleView
    {
       
        Article Article { get; set; }

        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler FormLoadEvent;      
        event EventHandler ListViewDoubleClick;
        event EventHandler ListViewClick;


        void LoadListView(List<Article> source);
       
        void Show();
        void BringToFront();
    }
}
