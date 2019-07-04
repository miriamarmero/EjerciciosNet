using System;

//dibuja el perímetro de un cuadrado con las dimensiones que introduzca el usuario  ( filas y columnas ).

namespace _3_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce las filas del cuadrado: ");
            int filas = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduce las columnas del cuadrado: ");
            int columnas = Convert.ToInt16(Console.ReadLine());

            string[,] cuadrado = new string[filas, columnas];
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    if(i == 0 || i == filas - 1){cuadrado[i,j] = "▒ ";}
                    if(j == 0)
                    {
                        cuadrado[i,j] = "▒ ";
                    }
                    else 
                    {
                        if(j == columnas - 1)
                        {
                            cuadrado[i,j]="▒";
                        }
                        else
                        {
                            if(cuadrado[i,j] != "▒ ")
                            {
                                cuadrado[i,j] = "  ";
                            }
                        }
                    }
                }
            }

            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    Console.Write(cuadrado[i,j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
