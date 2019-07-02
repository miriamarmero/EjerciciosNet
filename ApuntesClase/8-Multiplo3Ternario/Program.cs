using System;

namespace _8_Multiplo3Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            numero % 3 == 0 ? "Es múltiplo de 3" : "NO es multiplo de 3";
            Console.WriteLine(6 % 3);
        }
    }
}
