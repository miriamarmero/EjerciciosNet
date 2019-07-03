using System;

/* 13º Actividad.
Escribe un programa que muestre tres apuestas de la quiniela en tres columnas para los 14 partidos y el pleno al quince (15 filas) */

namespace _13_Quiniela
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultadoPartido;
            int columnas = 3;
            Random rand = new Random();
    
            for (int fila = 1; fila <= 15; fila++) {
                System.Console.WriteLine("%4d. |", fila);
      
                if (fila == 15) {
                    columnas = 1;
                }
            }

            for (int apuesta = 1; apuesta <= columnas; apuesta++) {
                resultadoPartido = (int)(rand.NextDouble() * 3);
                switch(resultadoPartido) {
                    case 1:
                        System.Console.WriteLine("1  |");
                    break;
                    case 2:
                        System.Console.WriteLine("  2|");
                    break;
                    case 3:
                        System.Console.WriteLine(" X |");
                    break;
                }
            }
            System.Console.WriteLine();
        }
    }
}