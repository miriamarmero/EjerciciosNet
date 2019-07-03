using System;

/* 7º Actividad.
Escriba un programa que calcule la media de N numéro enteros introducidos. */

namespace _7_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float sumaTotal = 0;
            foreach (string input in args)
            {
                Int32 number = Int32.Parse(input);
                sumaTotal += number;
            }

            float result = sumaTotal / args.Length;
            
            Console.WriteLine("El resultado es: " + result);
        }
    }
}
