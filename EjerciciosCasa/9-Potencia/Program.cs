using System;

/* 9º Actividad.
Cree un programa que calcule la potencia de un número a partir de su base y su exponente. */

namespace _9_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca Base: ");
            double Base = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Introduzca Exponente: ");
            double exponente = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(Base, exponente);
            System.Console.WriteLine("Resultado potencia:  " + resultado);
        }
    }
}
