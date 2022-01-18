using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class DespegadoState : AvionState
    {
        private List<Pasajero> pasajeros;

        public DespegadoState(Avion a, List<Pasajero> pasajeros)
            : base(a)
        {
            this.pasajeros = pasajeros;
        }

        public override List<Pasajero> GetPasajeros()
        {
            return pasajeros;
        }

        public override void AgregarPasajero(Pasajero pasajero)
        {
            throw new OperacionNoPermitidaException();
        }

        public override void PonerAvionEnPuerta(int puerta)
        {
            throw new OperacionNoPermitidaException();
        }

        public override void CerrarAvion()
        {
            throw new OperacionNoPermitidaException();
        }

        public override void DespegarAvion()
        {
            throw new OperacionNoPermitidaException();
        }

        public override void AterrizarAvion()
        {
            avion.CambiarEstado(new AterrizadoState(avion, pasajeros));
        }

        public override string EstadoDelAvion()
        {
            return "En vuelo con " + pasajeros.Count + " pasajeros";
        }
    }
}
