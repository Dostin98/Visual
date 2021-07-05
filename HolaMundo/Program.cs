using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dividir();
            Console.Read();
        }

        public static void Dividir()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //Opreadores Unarios

            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);
            Console.Read();
        }
    }
}
