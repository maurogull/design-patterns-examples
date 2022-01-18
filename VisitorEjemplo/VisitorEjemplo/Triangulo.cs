namespace VisitorEjemplo
{
    internal class Triangulo : Figura
    {
        private decimal _base;
        private decimal altura;

        public Triangulo(decimal _base, decimal altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public decimal getBase() { return _base; }
        public decimal getAltura() { return altura; }

        public override void Aceptar(VisitadorFigura vf)
        {
            vf.VisitarTriangulo(this);
        }

        public override string ToString()
        {
            return "Triangulo b=" + _base + " a=" + altura;
        }
    }
}