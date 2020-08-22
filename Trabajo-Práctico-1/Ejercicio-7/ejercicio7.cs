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

            Console.WriteLine(cadena.Length);

            //Contains devuelve un valor booleano si encuentra algo que existe en la cadena o no

            Console.WriteLine(cadena.Contains("Esto"));

            //Index of devuelve el indice del valor que se busca, si no lo encuentra devuelve -1

            Console.WriteLine(cadena.IndexOf("c"));

            //Remove sirve para eliminar una parte de la cadena entre dos parametros enteros

            Console.WriteLine(cadena.Remove(2, 7));

            //Replace sirve para reemplazar todos caracteres iguales por otro en la cadena

            Console.WriteLine(cadena.Replace(' ', ','));

            //Substring sirve para que la cadena inicie desde una posición específica

            Console.WriteLine(cadena.Substring(9));

            //Append sirve para agregar a otra cadena 

            StringBuilder sb = new StringBuilder();

            sb.Append(cadena);
            sb.Append("-----");
            sb.Append(cadena);

            Console.WriteLine(sb);


            //ToUper sirve para convertir la cadena en mayúsculas

            Console.WriteLine(cadena.ToUpper());

            //ToLower sirve para convertir la cadena en minúsculas

            Console.WriteLine(cadena.ToLower());
        }
    }
}
