namespace _12_Geometria
{
    public class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado): base(lado, lado)
        {
            System.Console.WriteLine("Cuadrado creado");
        }
    }
}