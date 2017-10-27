namespace calculadora
{
    internal class Resta : OperacionBinaria
    {
        public Resta(Calculable elemento1, Calculable elemento2) : base(elemento1, elemento2)
        {
        }

        public float Restando1()
        {
            return this.Elemento1();
        }
        public float Restando2()
        {
            return this.Elemento2();
        }
        public override float Resultado()
        {
            return this.Restando1() - this.Restando2();
        }
    }
}