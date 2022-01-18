using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorEjemplo
{
    class Circulo : Figura
    {
        private decimal radio;

        public Circulo(decimal radio)
        {
            this.radio = radio;
        }

        public decimal getRadio() { return radio; }

        public override void Aceptar(VisitadorFigura vf)
        {
            vf.VisitarCirculo(this);
        }

        public override string ToString()
        {
            return "Circulo r=" + radio;
        }
    }
}
