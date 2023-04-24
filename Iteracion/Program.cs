using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            String[] arregloDeStrings = new String[cantIteraciones];

            for (int i=0; i<cantIteraciones; i++)
            {
                Console.Write("Ingrese palabra " + (i+1) + ": ");
                arregloDeStrings[i] = Console.ReadLine();
            }

            for (int i=cantIteraciones; i > 0; i--)
            {
                Console.Write("- ");
                Console.WriteLine(arregloDeStrings[i-1]);
            }

        }
    }
}
