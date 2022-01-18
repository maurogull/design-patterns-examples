using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class EnPuertaState : AvionState
    {
        private List<Pasajero> pasajeros;
        private int puerta;

        public EnPuertaState(Avion a, int puerta)
            : base(a)
        {
            this.puerta = puerta;
            pasajeros = new List<Pasajero>();
        }

        public override List<Pasajero> GetPasajeros()
        {
            return pasajeros;
        }

        public override void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public override void PonerAvionEnPuerta(int puerta)
        {
            throw new OperacionNoPermitidaException();
        }

        public override void CerrarAvion()
        {
            avion.CambiarEstado(new CerradoState(avion, puerta, pasajeros));
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
            return "En Puerta " + puerta;
        }
    }
}
