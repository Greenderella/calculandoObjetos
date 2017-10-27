namespace calculadora
{
    internal abstract class OperacionBinaria : Calculable
    {
        private Calculable elemento1;
        private Calculable elemento2;

        public OperacionBinaria(Calculable elemento1, Calculable elemento2)
        {
            this.elemento1 = elemento1;
            this.elemento2 = elemento2;
        }

        public float Elemento1()
        {
            return elemento2.Resultado();
        }
        public float Elemento2()
        {
            return elemento1.Resultado();
        }
    }
}