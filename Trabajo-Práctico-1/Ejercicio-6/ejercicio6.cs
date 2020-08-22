/*Programar un algoritmo recursivo que en cada recursión multiplique a si mismo un número ingresado 
 * por el usuario hasta que el valor resultante sea mayor
100.000.000. Valide que el número ingresado por el usuario sea mayor a 1, ejemplo:
Se ingresa el valor 6
1 iteración => 6 * 6 = 36
2 iteración => 36 * 36 = 1296
3 iteración => 1296 * 1296 = 1679616
4 iteración => 1679616 * 1679616 = 2821109907456
Fin Recursión
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            long num = 0;

            while (num <= 1)
            {
                Console.WriteLine("Ingrese un número mayor a 1: ");
                num = Convert.ToInt64(Console.ReadLine());
            }

            multiplica(num);
        }

        private static long multiplica(long a)
        {
            long resultado;
            if (a > 100000000)
            {
                return a;
            }
            else
            {
                resultado = a * a;
                Console.WriteLine(a + " * " + a + " = " + resultado);
                return multiplica(resultado);
            }
        }
    }
}
