namespace ClassLibrary1
{
    public class coche
    {
        private string Modelo { get; set; }
        private int VelocidadMaxima { get; set; }
        private int PotenciaMotor { get; set; }
        private bool Enmarcha {  get; set; }


        public coche(string modelo , int velocidamaxima , int potenciamotor , bool enmarcha )
        {
            this.Modelo = modelo;
            this.VelocidadMaxima = velocidamaxima;
            this.PotenciaMotor = potenciamotor;
            this.Enmarcha = enmarcha;
        }


        public void Acelerar()
        {
            this.VelocidadMaxima += 10;
            if (Enmarcha)
            {
                Console.WriteLine("el coche " + this.Modelo + "esta acelerando " + this.VelocidadMaxima+ "km/h");

            }
            else
            {
                Console.WriteLine("primero encienda el coche ");
            }

        }

        public void Frenar()
        {
            VelocidadMaxima = 0;
            Enmarcha = false;
            Console.WriteLine("el coche esta frenando  " +this.Modelo);
        }


        public void Encender()
        {
            Enmarcha = true;
            Console.WriteLine("El coche "+ this.Modelo+ "esta ensendido ");

        }

        public void Apagar()
        {
            Enmarcha = false ;
            Console.WriteLine("el coche " +this.Modelo+ "esta apagado");
        }




    }
}
