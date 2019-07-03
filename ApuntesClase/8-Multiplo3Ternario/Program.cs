using System;

namespace _8_Multiplo3Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
               Console.WriteLine (i + ((i % 3 == 0)? " Es multiplo de 3" : " NO es multiplo de 3"));
            }
        }
    }
}
