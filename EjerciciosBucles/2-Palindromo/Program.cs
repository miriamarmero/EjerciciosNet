using System;

// Dada una cadena de texto comprobar si es palíndromo o no.

namespace _2_Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe una palabra: ");
            string word = Console.ReadLine();            
            
            if(word.Length > 2)
            {
                if(word.Substring(0,1) == word.Substring(word.Length -1, 1))
                {                     
                    System.Console.WriteLine(word + " es un palindromo");
                }

                else 
                { 
                    System.Console.WriteLine(word + " NO es un palindromo");
                }
            }

            else 
            {
                System.Console.WriteLine(word + " NO es un palindromo");
            }
        }
    }
}
