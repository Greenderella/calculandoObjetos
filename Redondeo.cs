namespace calculadora
{
    internal class Redondeo : Calculable
    {
        private double v;

        public Redondeo(double v)
        {
            this.v = v;
        }

        public override float Resultado()
        {
            return (float)System.Math.Round(v);
        }
    }
}