using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class CerradoState : AvionState
    {
        private List<Pasajero> pasajeros;
        private int puerta;

        public CerradoState(Avion a, int puerta, List<Pasajero> pasajeros)
            : base(a)
        {
            this.puerta = puerta;
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
            avion.CambiarEstado(new DespegadoState(avion, pasajeros));
        }

        public override void AterrizarAvion()
        {
            throw new OperacionNoPermitidaException();
        }

        public override string EstadoDelAvion()
        {
            return "Cerrado en puerta " + puerta;
        }
    }
}
