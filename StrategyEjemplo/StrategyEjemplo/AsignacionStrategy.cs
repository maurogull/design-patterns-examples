using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyEjemplo
{
    interface AsignacionStrategy
    {
        Dictionary<Trabajo, Trabajador> Asignar(List<Trabajador> trabajadores, List<Trabajo> trabajos);
    }
}
