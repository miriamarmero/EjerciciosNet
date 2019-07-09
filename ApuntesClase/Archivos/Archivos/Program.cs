using System;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"c:\tests\"))
            {
                Directory.CreateDirectory(@"c:\tests\");
            }

            try
            {
                foreach(string f in Directory.GetFiles("c:/"))
                {
                    Console.WriteLine("Archivo: " + f);
                }

                foreach(string d in Directory.GetDirectories("c:/"))
                {
                    Console.WriteLine("Directorio: " + d);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


