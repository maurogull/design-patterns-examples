using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class Pasajero
    {
        private string nombre;

        public Pasajero(string n)
        {
            nombre = n;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
