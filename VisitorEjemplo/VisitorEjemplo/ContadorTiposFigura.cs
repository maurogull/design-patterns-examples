using System;
using System.Collections.Generic;

namespace VisitorEjemplo
{
    class ContadorTiposFigura : VisitadorFigura
    {
        int circulos = 0;
        int rectangulos = 0;
        int triangulos = 0;

        public override void VisitarCirculo(Circulo c)
        {
            circulos++;
        }

        public override void VisitarRectangulo(Rectangulo r)
        {
            rectangulos++;
        }

        public override void VisitarTriangulo(Triangulo t)
        {
            triangulos++;
        }

        public string contar(List<Figura> figuras)
        {
            foreach(Figura f in figuras)
            {
                f.Aceptar(this);
            }

            return circulos + " circulos, " + rectangulos + " rectangulos, " + triangulos + " triangulos";
        }
    }
}