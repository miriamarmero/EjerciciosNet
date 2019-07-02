using System;

namespace _3_OrdenInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros;
            Console.Write("Ingrese 10 datos numéricos:");
            Numeros = int.Parse(Console.ReadLine());

            Numeros.Reverse(Numeros);

            Console.WriteLine("Numeros invertidos:\n");
            Console.Write(Numeros);
        }
    }
}
