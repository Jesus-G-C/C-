using MySelector;

namespace MyCLI
{
    public class CLI
    {
        public static void runApp()
        {
            showMenu();
            Selector.select();
        }


        public static void showMenu()
        {
            Console.WriteLine(@"
***********************************************************            
****************Bienvenido a la Calculadora****************
**                                                       **
**           ¿Qué operación deseas realizar?             **
**                                                       **
**               1- Suma                                 **
**               2- Resta                                **
**               3- Division                             **
**               4- Multiplicación                       ** 
**               5- Potencia                             **
**               0- Salir                                **
**                                                       **
***********************************************************   
            ");
        }
    }
}