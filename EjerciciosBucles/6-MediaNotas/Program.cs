using System;

//Permite al usuario introducir 10 notas ( sin utilizar los argumentos) y calcula la media.

namespace _6_MediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int fin = 10;
            double[] notas = new double[fin];
            for (int i = 0; i < fin; i++){
                Console.Write("Introduce 10 notas (" +  (i + 1)  + " de " + fin + "): ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("La media de las notas es: " + media(notas));
        }

        static double media(double[] args){
            double suma = 0;
            foreach(double valor in args)
            {
                suma += valor;
            }
            return suma / args.Length;
        }
    }
}
