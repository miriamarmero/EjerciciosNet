using System;

/* 4º Actividad.
Realizar un programa que no pida un unidad en kb y nos haga la conversión a MB */

namespace _4_KbConversionMb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            double Kb = Double.Parse(Console.ReadLine());
            double Mb = Kb / 1024;
            Console.WriteLine(Kb + " Kb son " + Mb + " Mb");
        }
    }
}
