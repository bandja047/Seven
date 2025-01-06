using MotherStoreBO.Models;
using MotherStoreBusiness.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.TiersView
{
    public interface IClientEntryView
    {
        Client Client { get; set; }

        event EventHandler SaveEvent;
        event EventHandler FormLoadEvent;

        public bool TopMost  { get; set; }
        FormState Action { get; set; }

        public void AssociatedAndRaiseEvent();
        
        void Show();
        void BringToFront();
    }
}
