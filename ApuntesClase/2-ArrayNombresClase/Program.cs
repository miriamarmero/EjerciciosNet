using System;

namespace _2_ArrayNombresClase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombresClase = {"David", "Manolo", "Paz", "Steven", "Victor", "Nacho", "Vero", "Miriam"};
            string pegamento = "Nombre: ";
            Console.WriteLine(pegamento + string.Join("\n" + pegamento, nombresClase));
        }
    }
}
