namespace _12_Geometria
{
    public abstract class forma
    {
        private double perimetro;

        private double area;

        private double altura;

        private double b;

        // Constructores: 1º vacio el segundo llamando a set perimetro y set area
        public forma()
        {

        }

        public forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
            System.Console.WriteLine("Forma creada");
        }

        public abstract void dibujar();

        //getters and setters

        public double getArea()
        {
            return this.area;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public double getPerimetro()
        {
            return this.perimetro;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public override string ToString()
        {
            return string.Format("Soy una forma de perimetro: {0} y area: {1}", this.perimetro, this.area);
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getB()
        {
            return this.b;
        }

        public void setB(double b)
        {
            this.b = b;
        }
    }
}