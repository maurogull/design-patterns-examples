namespace VisitorEjemplo
{
    internal class Rectangulo : Figura
    {
        private decimal _base;
        private decimal altura;

        public Rectangulo(decimal _base, decimal altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public decimal getBase() { return _base; }
        public decimal getAltura() { return altura; }

        public override void Aceptar(VisitadorFigura vf)
        {
            vf.VisitarRectangulo(this);
        }

        public override string ToString()
        {
            return "Rectangulo b=" + _base + " a=" + altura;
        }
    }
}