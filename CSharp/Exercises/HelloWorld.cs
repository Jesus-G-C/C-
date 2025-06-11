// /*
// Tipos de variables

// Tipo         Equivalente        Tamaño      Intervalo             Significado
// byte    ->   System.Byte    ->  8-bit   ->  0 a 255          ->   Entero sin signo
// sbyte   ->   System.SByte   ->  8-bit   ->  -128 a 127       ->   Entero con signo
// short   ->   System.Int16   ->  16-bit  ->  -32,768 a 32,767 ->   Entero corto con signo
// ushort  ->   System.UInt16  ->  16-bit  ->  0 a 65,535       ->   Entero corto sin signo
// int     ->  System.Int32    ->  32-bit  ->  -2,147,483,648 a ->   Entero medio con signo
//                                              2,147,483,647

// */

// using System;
// using Microsoft.VisualBasic;

// namespace CSharpHelloWorld
// {
//     class HelloWorld
//     {
//         static void Main(string[] args)
//         {
//             // Hola mundo
//             Console.WriteLine("Hola, C#");

//             string myString = "Esto es una cadena de texto";
//             myString = "Aqui cambio el valor de la cadena de texto";
//             Console.WriteLine(myString);

//             int myInt = 7;
//             myInt = myInt + 4;
//             Console.WriteLine(myInt - 1);
//             Console.WriteLine(myInt);

//             double myDouble = 6.5;
//             Console.WriteLine(myDouble);

//             float myFloat = 6.5f;
//             Console.WriteLine(myFloat);

//             Console.WriteLine(myDouble + myFloat + myInt);

//             bool myBool = true;
//             myBool = false;
//             Console.WriteLine(myBool);

//             dynamic myDynamic = 6;
//             myDynamic = "Mi dato dinámico";
//             Console.WriteLine(myDynamic);

//             var myVar = "Mi variable de tipo inferido";
//             Console.WriteLine(myVar);

//             Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

//             const string MyConst = "Mi constante";
//             Console.WriteLine(MyConst);

//             // Estructuras

//             var myArray = new string[] { "Jesús", "Gaspar", "Yisus" };
//             Console.WriteLine(myArray[0]);

//             myArray[2] = "23"; // No se puede agregar más espacios al array ya que esta definido con cierto tamaño
//             Console.WriteLine(myArray[1]); // Solo se puede agregar cadenas a este array ya que asi fue definido

//             var myDictionay = new Dictionary<string, int>
//             {
//                 {"jesus", 23},
//                 {"jordana", 23}
//             };
//             Console.WriteLine(myDictionay["jesus"]);

//             var mySet = new HashSet<string> { "Jesús", "Gaspar", "Yisus", "Jesús", "Jesús", "Jesús" }; // Se crea obviando los repetidos

//             var myTouple = ("Jesús", "Gaspar", "Yisus");
//             Console.WriteLine(myTouple); // No se accede a nivel index (myTouple[0])

//             // Bucles

//             for (int index = 0; index < 10; index++)
//             {
//                 Console.WriteLine(index);
//             }

//             foreach (var myItem in myArray)
//             {
//                 Console.WriteLine(myItem);
//             }

//             foreach (var myItem in myDictionay)
//             {
//                 Console.WriteLine(myItem);
//             }

//             foreach (var myItem in mySet)
//             {
//                 Console.WriteLine(myItem);
//             }

//             // Flujos

//             myInt = 12;

//             if (myInt == 11 && myBool == true)
//             {
//                 Console.WriteLine("El valor es 11");
//             }
//             else if (myInt == 12 || myBool == false)
//             {
//                 Console.WriteLine("El valor es 12");
//             }
//             else
//             {
//                 Console.WriteLine("El valor no es 11 ni 12");
//             }


//             // Funciones

//             MyFunction();
//             Console.WriteLine(MyFunctionWithReturn(5));

//             // Clases

//             var myClass = new MyClass("Jesús");
//             myClass.myName = "Emiliano";
//             Console.WriteLine(myClass.myName);
//         }

//         static void MyFunction()
//         {
//             Console.WriteLine("Mi función");
//         }

//         static int MyFunctionWithReturn(int param)
//         {
//             return 10 + param;
//         }

//         class MyClass
//         {
//             public string myName { get; set; }

//              public MyClass(string myName)
//             {
//                 this.myName = myName;
//             }
//         }
//     }
// }



