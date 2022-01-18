using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    class AsignacionEquitativaStrategy : AsignacionStrategy
    {
        public Dictionary<Trabajo, Trabajador> Asignar(List<Trabajador> trabajadores, List<Trabajo> trabajos)
        {
            var aux = new Dictionary<Trabajo, Trabajador>();
            
            foreach (Trabajo t in trabajos)
            {
                aux[t] = EncontrarTrabajadorConMenosTrabajos(aux, trabajadores);
            }

            return aux;
        }

        private Trabajador EncontrarTrabajadorConMenosTrabajos(Dictionary<Trabajo, Trabajador> asignados, List<Trabajador> trabajadores)
        {
            Random r = new Random();

            var contador = new Dictionary<Trabajador, int>();
            foreach (Trabajador t in trabajadores) contador[t] = 0;
            foreach (var a in asignados) contador[a.Value]++;

            Trabajador minimo = trabajadores[r.Next(trabajadores.Count)];
            foreach (var c in contador)
            {
                if (c.Value < contador[minimo]) minimo = c.Key;
            }

            return minimo;
        }
    }
}
