using System;

//Dado un numero introducido por el usuario devovler si es primo o no.

namespace _1_PrimoONo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            
            for(int i = 2; i < num; i++){
                if(num % i == 0){
                    System.Console.WriteLine("El numero " + num + " NO es primo");
                }
            }
            System.Console.WriteLine("El numero " + num + " es primo");
        }
    }
}
