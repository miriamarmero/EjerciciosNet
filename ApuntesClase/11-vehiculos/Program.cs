using System;

namespace _11_vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Tipo de combustible: " + vehiculo.combustible[0]);
            System.Console.WriteLine("Volantes: " + vehiculo.numVolantes);
            System.Console.WriteLine("Puertas: " + vehiculo.numPuertas);
            System.Console.WriteLine("Automatico: " + vehiculo.esAutomatico);
            System.Console.WriteLine("Pasajeros: " + vehiculo.numPasajeros);
            System.Console.WriteLine("Velocidad Maxima: " + vehiculo.velocidadMax);
            System.Console.WriteLine("Ruedas: " + vehiculo.numRuedas);
        }
    }
}
