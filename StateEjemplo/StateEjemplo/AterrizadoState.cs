using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class AterrizadoState : AvionState
    {
        private List<Pasajero> pasajeros;

        public AterrizadoState(Avion a, List<Pasajero> pasajeros)
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
            avion.CambiarEstado(new EnPuertaState(avion, puerta));
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
            throw new OperacionNoPermitidaException();
        }

        public override string EstadoDelAvion()
        {
            return "Aterrizado con " + pasajeros.Count + " pasajeros";
        }
    }
}
