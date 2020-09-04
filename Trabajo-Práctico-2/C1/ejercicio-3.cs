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
