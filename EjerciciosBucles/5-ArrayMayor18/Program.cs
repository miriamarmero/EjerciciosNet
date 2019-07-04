using System;

//Dado un array de edades mostrar por pantalla si todas son mayores de 18 o no.

namespace _5_ArrayMayor18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] years = new int[]{22, 21, 20, 35, 65};
            for(i = 0; i < years.Length; i++)
            {
                if(years[i] < 18)
                {
                    Console.WriteLine("No son todos mayores de edad");
                    i = (years.Length + 1);
                }
            }
            if(i == years.Length)
            {
                Console.WriteLine("¡Todos son mayores de edad!");
            }
        }
    }
}
