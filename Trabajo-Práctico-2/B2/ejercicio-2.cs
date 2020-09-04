/*
Cree una aplicación de Consola que permita por parte del usuario el ingreso por teclado de una cadena de texto, 
posteriormente el sistema deberá permitir el ingreso de una segunda cadena de texto. 
Finalmente el sistema deberá emitir el mensaje “ENCONTRADO” o “NO ENCONTRADO” según sean el caso de que la segunda cadena 
existe o no existe en la primera cadena. Valide que la cantidad de caracteres de la segunda cadena sea menor o igual a la 
cantidad de caracteres de la primera cadena.
Ej.:
Entrada Cadena 1: jhsjdhsjdhsd8787dsdsds8ds8d7sd6ds76d
Entrada Cadena 2: ds8ds8d
Resultado: “ENCONTRADO” 
  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class ejercicio2
    {
        static void Main(string[] args)
        {

            string cadena_1, cadena_2;

            do
            {

                Console.WriteLine("Ingrese la primer cadena de texto: ");
                cadena_1 = Console.ReadLine();

                Console.WriteLine("Ingrese una segunda cadena de texto: ");
                cadena_2 = Console.ReadLine();


            } while (cadena_1.Length < cadena_2.Length);


            if (cadena_1.Contains(cadena_2))
            {
                Console.WriteLine("ENCONTRADO.");
            }
            else
            {
                Console.WriteLine("NO ENCONTRADO.");
            }


        }
    }
}
