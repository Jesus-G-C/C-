/*
Tipos de variables

Tipo         Equivalente        Tamaño      Intervalo             Significado
byte    ->   System.Byte    ->  8-bit   ->  0 a 255          ->   Entero sin signo
sbyte   ->   System.SByte   ->  8-bit   ->  -128 a 127       ->   Entero con signo
short   ->   System.Int16   ->  16-bit  ->  -32,768 a 32,767 ->   Entero corto con signo
ushort  ->   System.UInt16  ->  16-bit  ->  0 a 65,535       ->   Entero corto sin signo
int     ->  System.Int32    ->  32-bit  ->  -2,147,483,648 a ->   Entero medio con signo
                                             2,147,483,647

*/

using System;
using Microsoft.VisualBasic;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hola, C#");

            string myString = "Esto es una cadena de texto";
            myString = "Aqui cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myDouble + myFloat + myInt);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico";
            Console.WriteLine(myDynamic);

            var myVar = "Mi variable de tipo inferido";
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            // Estructuras
        }
    }
}



