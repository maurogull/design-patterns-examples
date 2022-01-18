using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    abstract class AvionState
    {
        protected Avion avion;

        public AvionState(Avion a)
        {
            avion = a;
        }

        abstract public List<Pasajero> GetPasajeros();
        abstract public void AgregarPasajero(Pasajero pasajero);
        abstract public void PonerAvionEnPuerta(int puerta);
        abstract public void CerrarAvion();
        abstract public void DespegarAvion();
        abstract public void AterrizarAvion();

        abstract public string EstadoDelAvion();

    }

    class OperacionNoPermitidaException : Exception { }
}
