using System;

namespace _4_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-Suma" + "\n" + "2-Resta" + "\n" + "3-Multiplicación" + "\n" + "4-División" + "\n");
            Console.Write("Seleccione una opción: ");

            int num1, num2, suma, resta, multiplicación, division;
            switch (Console.Read())
            {
                case '1': Console.Write("Suma: ");
                    Console.Write("\nInserta primer numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInserta segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    suma = num1 + num2;

                    Console.WriteLine("El resultado es: " + suma);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                break;
                case '2': Console.Write("Resta: ");
                    Console.Write("\nInserta primer numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInserta segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    resta = num1 - num2;

                    Console.WriteLine("El resultado es: " + resta);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                break;
                case '3': Console.Write("Multiplicación: ");
                    Console.Write("\nInserta primer numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInserta segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    multiplicación = num1 * num2;

                    Console.WriteLine("El resultado es: " + multiplicación);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                break;
                case '4': Console.Write("División: ");
                    Console.Write("\nInserta primer numero: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInserta segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());

                    division = num1 / num2;

                    Console.WriteLine("El resultado es: " + division);

                    Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
                    Console.ReadKey();
                break;

            } 
            Console.ReadKey();
        }
    }
}
