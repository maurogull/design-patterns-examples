using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEjemplo
{
    interface ObservadorItems
    {
        void NotificarItems(List<Item> items);
    }
}
