/*Explique y ejemplifique los métodos para el manejo de cadenas en C#, 
 * Lenght, Contains, IndexOf, Remove, Replace, Substring, Append, ToUpper, ToLower.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class ejercicio7
    {
        static void Main(string[] args)
        {

            string cadena = "Esto es una cadena de texto.";

            //Lenght es el largo de la cadena

            Console.WriteLine("El largo de la cadena es: " + cadena.Length);

            //Contains devuelve un valor booleano si encuentra algo que existe en la cadena o no

            Console.WriteLine("Ingrese dos frases: ");
            string frase_1 = Console.ReadLine();
            Console.WriteLine("Ingrse la segunda: ");
            string frase_2 = Console.ReadLine();
            if (frase_1.Contains(frase_2))
            {
                Console.WriteLine("La segunda frase se encuentra en la primera.");
            }
            else
            {
                Console.WriteLine("La segunda no se encuentra en la primera.");
            }

            //Index of devuelve el indice del valor que se busca, si no lo encuentra devuelve -1

            Console.WriteLine("Index of: " + cadena.IndexOf("c"));

            //Remove sirve para eliminar una parte de la cadena entre dos parametros enteros

            Console.WriteLine("Remove: " + cadena.Remove(2, 7));

            //Replace sirve para reemplazar todos caracteres iguales por otro en la cadena

            Console.WriteLine("Replace: " + cadena.Replace(' ', ','));

            //Substring sirve para trocear un String desde una posición inicial hasta la longitud total que tiene la cadena

            Console.WriteLine("Substring: " + cadena.Substring(9, 4));

            //Append sirve para agregar a otra cadena 

            StringBuilder sb = new StringBuilder();

            sb.Append(cadena);
            sb.Append("-----");
            sb.Append(cadena);

            Console.WriteLine("Append" + sb);

            //ToUper sirve para convertir la cadena en mayúsculas

            Console.WriteLine(cadena.ToUpper());

            Console.WriteLine("Todo lo que escriba se transformará en mayúscula: ");
            cadena = Console.ReadLine().ToUpper();
            Console.WriteLine("ToUpper: " + cadena);

            //ToLower sirve para convertir la cadena en minúsculas

            Console.WriteLine("ToLower: " + cadena.ToLower());
        }
    }
}
