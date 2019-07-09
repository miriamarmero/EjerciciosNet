using System;
using System.Collections.Generic;

namespace _13_Listas
{
    class Pez: IEquatable<Pez>
    {
        public string color { get; set; }
        public string nombre { get; set; }
        public bool Equals(Pez other)
        {
            return this.color == other.color && this.nombre == other.nombre;
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            //List<string> peces = new List<string>();
            string[] input =
            {
                "Salmon",
                "Emperador",
                "Atun"
            };
            //List<string> peces = new List<string>(input);
            //List<int> numeroLetras = peces.ConvertAll<int>(p => p.Length);
            Dictionary<string, Pez> peces = new Dictionary<string, Pez>();

            peces.Add("nemo", new Pez() { nombre = "mi nemo", color = "dorado"});

            try
            {
                peces.Add("nemo", new Pez() { nombre = "mi nemo", color = "dorado" });
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Clave duplicada");
            }

            //Console.WriteLine(numeroLetras[0]);
            //peces.Add("Pez Espada");
            //peces.Remove("Atun");
            //Console.WriteLine(peces.Count);
            //Console.WriteLine(peces.Capacity);
            //Console.WriteLine(peces.Contains("Emperador"));

            //peces.Remove(new Pez() { nombre = "Dorada", color = "Gris" });
            //bool encontrado = peces.Contains(new Pez() { nombre = "Dorada", color = "Gris" });
            //Console.WriteLine(encontrado ? "Encontrado!!" : "No esta");
            foreach(var p in peces)
            {
                Console.WriteLine(p);
            }
        }
    }
}
