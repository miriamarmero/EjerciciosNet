using System;

namespace _5_Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine(x.HasValue);

            /* bool y = x.GetValueOrDefault(); */
            
            try {
                /* Console.WriteLine("El valor de Y: " + y); */
            } catch(InvalidOperationException){
                Console.WriteLine("Operacion no válida!");
            }
        }
    }
}
