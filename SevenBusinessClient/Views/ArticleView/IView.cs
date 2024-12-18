using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.ArticleView
{
    public interface IView
    {
        string Action { get; set; }

        public bool TopMost { get; set; }

        internal void AssociatedAndRaiseEvent();

        event EventHandler FormLoadEvent;
        void Show();
        void BringToFront();
    }
}
