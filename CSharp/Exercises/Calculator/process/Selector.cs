using MySum;

namespace MySelector
{
    public class Selector
    {           
    public static void select()
        {
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Elegiste Suma");
                    Console.WriteLine("Introduce el primer número: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo número: ");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {Sum.adder(n1, n2)}");
                    break;

                case "2":
                    Console.WriteLine("Elegiste Resta");
                    break;

                case "3":
                    Console.WriteLine("Elegiste División");
                    break;

                case "4":
                    Console.WriteLine("Elegiste Multiplicación");
                    break;

                case "5":
                    Console.WriteLine("Elegiste Potencia");
                    break;     
            }
        }
    }
}