using ClassLibrary1;

namespace ConsoleApp11
{
    public class Program
    {
        static void Main(string[] args)
        {
            coche cones = new coche("Honda cr-v" , 120, 1200 , false);


            cones.Encender();
            cones.Acelerar();
            cones.Frenar();
            cones.Apagar();

            coche nana = new coche("bmw", 320, 3000, false);
            nana.Encender();
            nana.Acelerar();
            nana.Frenar();
            nana.Apagar();



        }
    }
}
