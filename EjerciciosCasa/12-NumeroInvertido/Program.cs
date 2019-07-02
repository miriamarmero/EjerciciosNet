using System;

namespace _12_NumeroInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, ni;

            Console.WriteLine("Escribe un numero de 5 cifras: ");
            n = int.Parse(Console.ReadLine());

            r = n % 10;
            n = n / 10;
            ni = r * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            r = n % 10;
            n = n / 10;
            ni = (ni + r) * 10;

            ni = ni + n;

            Console.WriteLine("Numero inverso: " + ni);
            Console.ReadKey();
        }
    }
}
