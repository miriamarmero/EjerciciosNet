using System;

namespace _10_Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            string cad = "";
            int i, j;
            Console.WriteLine("Ingresa numero: ");
            var n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i < n+1; i++){
                for(j = 1; j < i+1; j++){
                    cad = cad + "*";
                }
                cad = cad + "\n";
            }
            Console.WriteLine(cad);
            Console.ReadLine();
        }
    }
}
