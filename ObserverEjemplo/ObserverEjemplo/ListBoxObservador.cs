using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverEjemplo
{
    class ListBoxObservador : ListBox, ObservadorItems
    {
        public void NotificarItems(List<Item> items)
        {
            this.Items.Clear();
            foreach (Item i in items)
            {
                this.Items.Add(i);
            }

            this.RefreshItems();
        }

    }
}
