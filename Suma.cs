namespace calculadora
{
    internal class Suma : OperacionBinaria
    {
        public Suma(Calculable elemento1, Calculable elemento2) : base(elemento1, elemento2)
        {
        }

        public float Sumando1()
        {
            return this.Elemento1();
        }
        public float Sumando2()
        {
            return this.Elemento2();
        }
        public override float Resultado()
        {
            return this.Sumando1() + this.Sumando2();
        }
    }
}