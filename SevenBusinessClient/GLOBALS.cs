using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenBusinessClient
{
    public class GLOBALS
    {
        public  static void LoadForm(Form form)
        {
            form.TopMost = true;
            form.BringToFront();
            form.Show();
        }

        public static void LoadForm(Form form, Form mdiParent) {

            form.MdiParent = mdiParent;
            form.TopMost = true;
            form.BringToFront();
           

        }

        public static void LoadForm(Form form, bool asDialog = false)
        {

           
            form.TopMost = true;
            form.BringToFront();

            if (asDialog)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
          

        }
    }
}
