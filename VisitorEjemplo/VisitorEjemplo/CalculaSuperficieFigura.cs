using System;

namespace VisitorEjemplo
{
    internal class CalculaSuperficieFigura : VisitadorFigura
    {
        decimal superficie = 0;

        public override void VisitarCirculo(Circulo c)
        {
            superficie = c.getRadio() * c.getRadio() * (decimal)Math.PI;
        }

        public override void VisitarRectangulo(Rectangulo r)
        {
            superficie = r.getBase() * r.getAltura();
        }

        public override void VisitarTriangulo(Triangulo t)
        {
            superficie = t.getBase() * t.getAltura() / 2m;
        }

        public decimal calcular(Figura figura)
        {
            figura.Aceptar(this);
            return superficie;
        }
    }
}