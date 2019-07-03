using System;

/* 2º Actividad.
Escriba un método que imprima la representación de su parámetro entero en números romanos. Por ejemplo, si el parámetro es 1998, la salida debe ser MCMXCVIII */

namespace _2_NumeroRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Miles, Resto, Centenas, Decenas, Unidades,Numero;
            Console.Write("Ingrese un Año:");
            Numero = int.Parse(Console.ReadLine());
            Miles = Numero / 1000;
            Resto = Numero % 1000;
            Centenas = Resto / 100;
            Resto = Resto % 100;
            Decenas = Resto / 10;
            Resto = Resto % 10;
            Unidades = Resto;
            Console.Write("En Número Romanos es : ");
            switch (Miles)
            {
            case 1: Console.Write("M"); break;
            case 2: Console.Write("MM"); break;
            case 3: Console.Write("MMM"); break;
            }
            switch (Centenas)
            {
            case 1: Console.Write("C"); break;
            case 2: Console.Write("CC"); break;
            case 3: Console.Write("CCC"); break;
            case 4: Console.Write("CD"); break;
            case 5: Console.Write("D"); break;
            case 6: Console.Write("DC"); break;
            case 7: Console.Write("DCC"); break;
            case 8: Console.Write("DCCC"); break;
            case 9: Console.Write("CM"); break;
            }
            switch (Decenas)
            {
            case 1: Console.Write("X");
            break;
            case 2: Console.Write("XX");
            break;
            case 3: Console.Write("XXX");
            break;
            case 4: Console.Write("XL");
            break;
            case 5: Console.Write("L");
            break;
            case 6: Console.Write("LX");
            break;
            case 7: Console.Write("LXX");
            break;
            case 8: Console.Write("LXXX");
            break;
            case 9: Console.Write("XC");
            break;
            }
            switch (Unidades)
            {
            case 1: Console.Write("I"); break;
            case 2: Console.Write("II"); break;
            case 3: Console.Write("III"); break;
            case 4: Console.Write("IV"); break;
            case 5: Console.Write("V"); break;
            case 6: Console.Write("VI"); break;
            case 7: Console.Write("VII"); break;
            case 8: Console.Write("VIII"); break;
            case 9: Console.Write("IX"); break;
            }
        }
    }
}
