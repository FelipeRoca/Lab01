using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {

/*EJERCICIO 1*/


            Console.WriteLine("Ingrese un texto: ");
           String inputTexto = Console.ReadLine();

           if (inputTexto ==  "") { 
                Console.WriteLine("Texto vacio");
                Console.ReadKey();

            }
           else
            {
                Console.Write("El texto es: ");
                Console.WriteLine(inputTexto);

                Console.WriteLine("1. Mostrar en Mayusculas");
                Console.WriteLine("2. Mostrar en Minusculas");
                Console.WriteLine("3. Mostrar cantidad de caracteres");

                ConsoleKeyInfo opcion = Console.ReadKey();
                while (opcion.Key != ConsoleKey.D1 && opcion.Key != ConsoleKey.D2 && opcion.Key != ConsoleKey.D3) { 
                opcion = Console.ReadKey();
                }

                Console.WriteLine();

               /* if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else
                {
                    Console.WriteLine(inputTexto.Length);
                } */

 /*EJERCICIO 2*/
                
                
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:

                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    default:
                        Console.WriteLine(inputTexto.Length);
                        break;
                }

            }
        }
    }
}
