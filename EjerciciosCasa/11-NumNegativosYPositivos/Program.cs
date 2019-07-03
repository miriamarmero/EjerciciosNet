using System;

/* 11º Actividad.
Cree un programa que a partir de n números introducidos nos índique el número de números positivos introducidos y el número de números negativos introducidos. */

namespace _11_NumNegativosYPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPositivos = 0;
            int numNegativos = 0;
            
            for (int i = 0; i < args.Length; i++)
            {
               if(args[i].Split("-").Length > 1){
                   numNegativos++;
               } else {
                   numPositivos++;
               }
            }
            System.Console.WriteLine("Numeros negativos: " + numNegativos);
            System.Console.WriteLine("Numeros positivos: " + numPositivos);
        }
    }
}
