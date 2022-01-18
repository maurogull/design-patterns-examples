using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class EnTallerState : AvionState
    {
        public EnTallerState(Avion a) : base(a) { }

        public override List<Pasajero> GetPasajeros()
        {
            throw new OperacionNoPermitidaException();
        }

        public override void AgregarPasajero(Pasajero pasajero)
        {
            throw new OperacionNoPermitidaException();
        }

        public override void PonerAvionEnPuerta(int puerta)
        {
            avion.CambiarEstado( new EnPuertaState(avion, puerta) );
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
            return "En Taller";
        }
    }
}
