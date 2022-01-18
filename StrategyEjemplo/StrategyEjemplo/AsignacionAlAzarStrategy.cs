using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    class AsignacionAlAzarStrategy : AsignacionStrategy
    {

        public Dictionary<Trabajo, Trabajador> Asignar(List<Trabajador> trabajadores, List<Trabajo> trabajos)
        {
            Random r = new Random();
            var aux = new Dictionary<Trabajo, Trabajador>();

            foreach (Trabajo t in trabajos)
            {
                aux[t] = trabajadores[r.Next(trabajadores.Count)];
            }

            return aux;
        }
    }
}
