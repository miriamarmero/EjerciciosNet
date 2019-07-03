namespace _11_vehiculos
{
    public class vehiculo
    {
        private string color;
        private int ruedas;
        /* public vehiculo()
        {
            this.color = "Rojo";
            this.ruedas = 4;
        } */

        public vehiculo(string color, int ruedas)
        {
            this.color = color;
            this.ruedas = ruedas;
        }
        public static byte numRuedas;

        public byte getNumRuedas() {
            return this.numRuedas;
        }

        public void setNumRuedas(byte numRuedas) {
            this.numRuedas = 4;
        }

        public static byte numVolantes = 1;
        public static ushort numPasajeros;

        public ushort getNumPasajeros() {
            return this.numPasajeros;
        }

        public void setNumPasajeros(ushort numPasajeros) {
            this.numPasajeros = numPasajeros;
        }

        /* public static string[] color = {"rojo", "verde", "azul", "gris", "negro", "marron", "blanco"}; */

        public static byte numPuertas;

        public byte getNumPuertas() {
            return this.numPuertas;
        }

        public void setNumPuertas(byte numPuertas) {
            this.numPuertas = numPuertas;
        }

        public static string[] combustible = {"diesel", "gasolina", "electrico"};

        public static bool esAutomatico;

        public bool getEsAutomatico() {
            return this.esAutomatico;
        }

        public void isEsAutomatico(bool esAutomatico) {
            this.esAutomatico = esAutomatico;
        }

        public static ushort velocidadMax;

        public ushort getVelocidadMax() {
            return this.velocidadMax;
        }

        public void setVelocidadMax(ushort velocidadMax) {
            this.velocidadMax = 300;
        }

        private Random numBastidor;

        public bool encendido = velocidadMax;
        public void arrancar()
        {
            if (!encendido)
            {
                encendido = true;
                System.Console.WriteLine("Brrrummm Brrruuumm");
            }
        }
    }
}