namespace _12_Geometria
{
    public class Rectangulo : forma
    {
        private double b;
        private double h;

        public Rectangulo(double b, double h): base(2 * b + 2 * h, b * h)
        {
            System.Console.WriteLine("Rectangulo creado");
            this.b = b;
            this.h = h;
        }

        public override string ToString(){
            return string.Format("Esto es un rectangulo de altura: {0}, base: {1}, perimetro: {2} y area: {3}",
            this.h, this.b, base.getPerimetro(), base.getArea()
            );
        }
        public override void dibujar()
        {
            for (int i = 0; i < this.h; i++)
            {
                // multiplico por 2 la base para que se adapte más a la realidad
                System.Console.WriteLine(new string('▓', (int)this.b * 2)); 
            }
        }
    }
}