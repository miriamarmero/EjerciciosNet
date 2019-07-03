using System;

/* 5º Actividad.
Realizar un programa que nos pida el radio y la altura y nos calcule el volumen de un cono. */

namespace _5_VolumenCono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio: ");
            double radio = Double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura: ");
            double altura = Double.Parse(Console.ReadLine());

            const double pi = 3.1416;
            double volumen = (pi * radio * radio * altura) / 3;
            
            System.Console.WriteLine("El volumen del cono es: " + volumen + " centímetros cúbicos");
        }
    }
}
