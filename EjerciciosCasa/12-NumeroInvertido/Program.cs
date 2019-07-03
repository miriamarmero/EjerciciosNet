using System;

/* 12º Actividad.
Cree un programa que invierta el número que se pide el usuario por ejemplo si el usuario introduce 4561 el programa debe devolver 1654 */

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
