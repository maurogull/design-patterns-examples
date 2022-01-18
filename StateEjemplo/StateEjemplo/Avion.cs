using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateEjemplo
{
    class Avion
    {
        private AvionState estado;

        public Avion()
        {
            estado = new EnTallerState(this);
        }

        public void CambiarEstado(AvionState s) {
            estado = s;
        }

        public string GetEstado()
        {
            return estado.EstadoDelAvion();
        }

        public List<Pasajero> GetPasajeros()
        {
            return estado.GetPasajeros();
        }

        public void AgregarPasajero(Pasajero pasajero)
        {
            estado.AgregarPasajero(pasajero);
        }

        public void PonerAvionEnPuerta(int puerta)
        {
            estado.PonerAvionEnPuerta(puerta);
        }

        public void CerrarAvion()
        {
            estado.CerrarAvion();
        }

        public void DespegarAvion()
        {
            estado.DespegarAvion();
        }

        public void AterrizarAvion()
        {
            estado.AterrizarAvion();
        }

    }
}
