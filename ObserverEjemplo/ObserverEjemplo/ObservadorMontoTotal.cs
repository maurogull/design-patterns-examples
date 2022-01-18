using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverEjemplo
{
    interface ObservadorMontoTotal
    {
        void NotificarMontoTotal(decimal monto);
    }
}
