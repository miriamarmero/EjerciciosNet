using System;

namespace _1_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Int16 a = Convert.ToInt16(args[0]);
            Int16 b = Convert.ToInt16(args[1]);
            Int32 result = a * b;
            Console.WriteLine("El resultado es: \n \"hola\" " + result);

            Double numeroDoble = 12563.2;
            Int32 c = (Int32)numeroDoble;
            Console.WriteLine(c); */

            String numeros = "123456789";
            Console.WriteLine(numeros.Substring(2, 5));

            String number = "12345678910";
            Console.WriteLine(number.IndexOf("0", 3));
        }
    }
}
