/*
 Codifique un programa que permita la carga de una cadena de números separados por coma. 
Al finalizar la carga ejecute la función Split de C# para separar la cadena y formar un arreglo de
elementos. Recorra el arreglo de valores numéricos y obtenga la suma total de los valores. 
Muestre el resultado por consola o pantalla.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese números separados por coma, luego serán sumados.");
            string cadena = Console.ReadLine();

            string [] arr = cadena.Split(',');
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    total += Convert.ToInt32(arr[i]);
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("¡Error! " + ex.Message + " Solo deben ser números separados por coma. " +
                        "\nSi se han ingresado números separados por coma, serán considerados para la suma.\n" );
                }
                
            }


            Console.WriteLine("La suma total de los valores es: " + total);
        }
    }
}
