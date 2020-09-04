/*Cree un programa que permita ingresar por teclado dos valores enteros el primero para indicar el número de filas y 
 * el segundo para el número de columnas. Mediante los 2 valores cree una matriz de 2 dimensiones de orden filas X columnas.
Asigne a cada elemento de la matriz el valor X si la suma de los valores enteros ingresados es igual a la suma de la fila y 
columna de la celda caso contrario asigne una 0. (Se considera el valor de la posición y no del índice de la tabla para el 
cálculo, es decir la primer posición es 1 no 0)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el valor que llevara el tamaño de las filas de la matriz: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor que llevara el tamaño de las columnas de la matriz: ");
            int column = Convert.ToInt32(Console.ReadLine());

            string [,] matriz = new string[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    if (i+j+2 == row + column)
                    {
                        matriz[i, j] = "X";
                    }
                    else
                    {
                        matriz[i, j] = "0";
                    }

                }

            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                    Console.Write(matriz[i,j] + "");
                }

                Console.WriteLine();

            }
        }
    }
}
