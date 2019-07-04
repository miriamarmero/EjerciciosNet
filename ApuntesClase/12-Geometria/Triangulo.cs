namespace _12_Geometria
{
    public class Triangulo : forma
    {
        private double lado, bTriangulo, altura, lado1;

        public Triangulo(double lado, double bTriangulo, double altura, double lado1)
            :base(bTriangulo + lado + lado1, bTriangulo * altura / 2)
        {
            this.lado = lado;
            this.bTriangulo = bTriangulo;
            this.altura = altura;
            this.lado1 = lado1;
            System.Console.WriteLine("Triángulo creado");
        }

        public override void dibujar()
        {
            System.Console.WriteLine("triangulo dibujado");
        }
    }
}