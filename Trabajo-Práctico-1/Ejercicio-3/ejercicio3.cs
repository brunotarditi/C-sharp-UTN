/*Codifique un método denominado esPar que reciba como parámetro un valor numérico entero y retorne true 
 * en caso de que el numero sea par, caso contrario retorne false. 
 * Compruebe el funcionamiento del método solicitando al usuario del programa que ingrese números aleatorios.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿El número " + num + " que fue ingresado es par? " + esPar(num));


        }

        private static bool esPar(int n)
        {
            return n % 2 == 0;
        }
    }
}
