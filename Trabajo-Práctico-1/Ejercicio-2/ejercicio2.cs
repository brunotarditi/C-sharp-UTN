/*Generar un número aleatorio entre 0 y 100, para ello use la función random de C#
Una vez generado el número codifique la lógica necesaria para encontrar el número aleatorio ayudando a
l usuario informando al mismo si el número ingresado es mayor o menor al número aleatorio buscado. 
Una vez encontrado el número muestre la cantidad de intentos necesarios para lograrlo.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 101);

            Console.WriteLine("Ingrese un número entre 0 y 100: ");
            int num_ingresado = Convert.ToInt32(Console.ReadLine());

            while (aleatorio != num_ingresado)
            {
                if (num_ingresado < aleatorio)
                {
                    Console.WriteLine("Es muy bajo.");
                    Console.WriteLine("Ingrese un número entre 0 y 100: ");
                    num_ingresado = Convert.ToInt32(Console.ReadLine());
                    intentos++;
                }
                else
                {
                    Console.WriteLine("Es muy alto.");
                    Console.WriteLine("Ingrese un número entre 0 y 100: ");
                    num_ingresado = Convert.ToInt32(Console.ReadLine());
                    intentos++;
                }

            }

            Console.WriteLine("¡Número encontrado!, en " + intentos + " intentos.");

        }

    }
}
