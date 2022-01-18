using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEjemplo
{
    class Factura
    {
        List<ObservadorMontoTotal> omt;
        List<ObservadorItems> oi;
        List<Item> items;

        public Factura()
        {
            omt = new List<ObservadorMontoTotal>();
            oi = new List<ObservadorItems>();
            items = new List<Item>();
        }

        public void agregarObservadorMontoTotal(ObservadorMontoTotal observador)
        {
            omt.Add(observador);
        }

        public void agregarObservadorItems(ObservadorItems observador)
        {
            oi.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (ObservadorMontoTotal unObservador in omt)
            {
                unObservador.NotificarMontoTotal(getTotal());
            }

            foreach (ObservadorItems unObservador in oi)
            {
                unObservador.NotificarItems(items);
            }
        }

        public void agregarItem(Item i) {
            items.Add(i);
            notificarObservadores();
        }


        public void borrarItem(Item i)
        {
            items.Remove(i);
            notificarObservadores();
        }

        public decimal getTotal()
        {
            decimal total = 0;
            foreach (Item unItem in items)
            {
                total += unItem.Monto;
            }
            return total;
        }

    }
}
