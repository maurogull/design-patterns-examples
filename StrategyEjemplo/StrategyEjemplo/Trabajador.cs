using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    class Trabajador
    {
        private string nombre;

        public Trabajador(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
