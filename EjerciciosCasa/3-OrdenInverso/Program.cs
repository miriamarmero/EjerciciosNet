using System;

/* 3º Actividad.
Leer 10 datos numéricos y mostrarlos en orden inverso */

namespace _3_OrdenInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 10){
                Console.WriteLine("Ingrese 10 datos numéricos: " + args.Length);
            } else {
                for (int i = 9; i >= 0; i--)
                {
                    System.Console.WriteLine(args[i]);
                }
            }
        }
    }
}
