using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionBinaria lalala2 = new Suma(new Valor(2), new Redondeo(2.1));
            System.Console.WriteLine(lalala2.Resultado());

            

            
        }
    }
}
