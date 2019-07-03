using System;

/* 6º Actividad.
Escriba un programa que calcule el tiempo de caída de un objeto determinado desde una altura dada, para ello se pide la altura en metros. */

namespace _6_TiempoCaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la altura: ");
            double altura = Double.Parse(Console.ReadLine());

            double g = 9.81;
            double result = Math.Sqrt(altura / (g/2));

            System.Console.WriteLine("El tiempo que tarda en caer es de: " + result + " seg");
        }
    }
}
