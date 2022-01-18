namespace VisitorEjemplo
{
    abstract class VisitadorFigura
    {
        public abstract void VisitarCirculo(Circulo c);
        public abstract void VisitarRectangulo(Rectangulo r);
        public abstract void VisitarTriangulo(Triangulo t);
    }
}