/*Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5. 
 * Utiliza las iteraciones for, while, do/while para resolver el mismo problema.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("El número " + i + " es divisible por 2 y 5.");
                }
            }
        }
    }
}
