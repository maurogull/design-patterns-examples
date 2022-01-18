using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEjemplo
{
    public class Item
    {
        public decimal Monto { get; set; }

        public Item(decimal monto)
        {
            this.Monto = monto;
        }

        public override string ToString()
        {
            return Monto.ToString();
        }
    }
}
