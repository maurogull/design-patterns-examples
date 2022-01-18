using System;
using System.Collections.Generic;

namespace VisitorEjemplo
{
    class CalculaSuperficieColeccionFiguras : VisitadorFigura
    {
        decimal superficieTotal = 0;

        public override void VisitarCirculo(Circulo c)
        {
            var aux = new CalculaSuperficieFigura();
            superficieTotal += aux.calcular(c);
        }

        public override void VisitarRectangulo(Rectangulo r)
        {
            var aux = new CalculaSuperficieFigura();
            superficieTotal += aux.calcular(r);
        }

        public override void VisitarTriangulo(Triangulo t)
        {
            var aux = new CalculaSuperficieFigura();
            superficieTotal += aux.calcular(t);
        }

        public decimal calcular(List<Figura> figuras)
        {
            foreach(Figura f in figuras)
            {
                f.Aceptar(this);
            }

            return superficieTotal;
        }
    }
}