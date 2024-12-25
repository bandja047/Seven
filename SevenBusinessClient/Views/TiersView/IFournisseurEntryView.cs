using MotherStoreBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.TiersView
{
    public interface IFournisseurEntryView
    {
        Fournisseur Fournisseur { get; set; }

        event EventHandler SaveEvent;
        event EventHandler FormLoadEvent;

        public bool TopMost  { get; set; }
        string Action { get; set; }

        public void AssociatedAndRaiseEvent();
        
        void Show();
        void BringToFront();
    }
}
