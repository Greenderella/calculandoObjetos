namespace calculadora
{
    internal class Valor : Calculable
    {
        private int elemento;

        public Valor(int elemento)
        {
            this.elemento = elemento;
        }
        public override float Resultado()
        {
            return this.elemento;
        }
    }
}