using System;

/* 8º Actividad.
Cree un programa que a partir de un entero calcule su serie Fibonacci */

namespace _8_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int limite = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 1;
            int aux = 0;
            for (int i = 0; i < limite; i++)
            {
                aux = x;
                x = y;
                y = aux + x;
                System.Console.WriteLine(x);
            }
        }
    }
}
