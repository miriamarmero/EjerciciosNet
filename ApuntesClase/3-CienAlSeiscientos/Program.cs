using System;

namespace _3_CienAlSeiscientos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cienAlSeiscientos = new string [501];
            int inicio = 100;
            for (int i = 0; i <= 500; i++)
            {
                cienAlSeiscientos[i] = (inicio + i).ToString();
            }
            Console.WriteLine(string.Join("\n", cienAlSeiscientos));
        }
    }
}
