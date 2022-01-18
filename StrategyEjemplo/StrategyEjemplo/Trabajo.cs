using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    class Trabajo
    {
        private string nombre;

        public Trabajo(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
