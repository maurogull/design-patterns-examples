using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    class AsignadorTrabajos
    {
        List<Trabajo> trabajos;
        List<Trabajador> trabajadores;
        AsignacionStrategy strategy;

        public void SetTrabajos(List<Trabajo> trabajos)
        {
            this.trabajos = trabajos;
        }

        public void SetTrabajadores(List<Trabajador> trabajadores)
        {
            this.trabajadores = trabajadores;
        }

        internal void SetEstrategia(AsignacionStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Dictionary<Trabajo, Trabajador> Asignar()
        {
            if(strategy == null) throw new StrategyNoDefinidaException();

            return strategy.Asignar(trabajadores, trabajos);
        }
    }

    class StrategyNoDefinidaException : Exception { }
}
