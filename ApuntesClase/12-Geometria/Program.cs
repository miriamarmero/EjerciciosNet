using System;
/* clase que sea forma y que tenga perimetro y area, dos constructores vacios que tenan perimetro y area */

namespace _12_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            /* forma f = new forma(); */
            double b = 10;
            double h = 5;
            forma r = new Rectangulo(b, h);
            forma c = new Cuadrado(b);
            forma t = new Triangulo((double)10, (double)10, (double)5, (double)10);

            System.Console.WriteLine(r);
            System.Console.WriteLine(c);
            System.Console.WriteLine(t);

            r.dibujar();
            t.dibujar();
        }
    }
}
