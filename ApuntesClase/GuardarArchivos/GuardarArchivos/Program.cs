using System;
using System.IO;
using System.Linq;

namespace GuardarArchivos
{
    class Program
    {
        //static string dataPath = @"c:\tests\hello.txt";
        static void Main(string[] args)
        {
            //File.WriteAllText("c:/tests/hello.txt", "Hello World");
            //File.AppendAllText("c:/tests/hello.txt", "Perro");

            //foreach (string f in Directory.GetFiles("c:/tests"))
            //{
            //Console.WriteLine("Archivo: " + f);
            //}
            //foreach (string d in Directory.GetDirectories("c:/tests"))
            //{
            //Console.WriteLine("Directorio: " + d);
            //}

            //var da = from line in File.ReadLines(dataPath)
            //where (line.StartsWith("a"))
            //select line;

            //File.WriteAllLines(@"c:\tests\hello.txt", da);
            //File.AppendAllLines(@"c:\tests\hello.txt", da);

            //StreamWriter file = new StreamWriter(@"c:\tests\hello.txt", true);
            //file.WriteLine("helllloooo");
            //file.Close(); //SIEMPRE HAY QUE CERRAR, MUY IMPORTANTE

            string path = @"c:\tests\hello.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "Hello", "And", "Welcome" };
                File.WriteAllLines(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }

            StreamReader sr = new StreamReader(@"c:\tests\hello.txt");
            while (sr.Peek() >= 0)
            {
                Console.Write((char)sr.Read());
            }
            sr.Close();
        }
    }
}
