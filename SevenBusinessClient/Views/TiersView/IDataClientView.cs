using MotherStoreBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherStoreBusiness.Views.TiersView
{
    public interface IDataClientView
    {

        Client Client { get; set; }

        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler FormLoadEvent;
        event EventHandler ListViewDoubleClick;
        event EventHandler ListViewClick;
        public bool TopMost { get; set; }
        Form? MdiParent { get; set; }

        public void SetMdiParent(Form parentForm);
        public void AssociatedAndRaiseEvent();      
        void LoadListView(List<Client> source);
        void Show();
        void BringToFront();
       
    }
}
