/*Codifique 5 funciones C# que resuelvan las operaciones matemáticas:
Suma +
Resta –
Multiplicación *
División /
Modulo %
Aplicadas sobre 2 números decimales.
Posteriormente codifique un programa que solicite el ingreso por parte del usuario de 2 números decimales y 
una vez ingresados le pregunte qué operación quiere realizar:
a- Suma +
b- Resta –
c- Multiplicación *
d- División /
e- Modulo %
En caso de que no ingrese ninguna de las opciones permitidas emita el mensaje “La opción ingresada no es válida” y 
vuelva nuevamente a preguntarle qué operación matemática quiere ejecutar.
Si la opción es válida envié los números decimales ingresados por el usuario a la función que corresponda y 
retorne el resultado de la operación.
Finalmente muestre un mensaje indicando el resultado de la operación realizada.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class ejercicio4
    {
        static void Main(string[] args)
        {


            double resultado, num1, num2;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            ConsoleKeyInfo opcion;

            do
            {
                Console.WriteLine("\nIngrese la operación que desea ejecutar: ");
                Console.WriteLine("Para salir pulse la tecla 'ESC'.");
                Console.WriteLine("A → suma");
                Console.WriteLine("B → resta");
                Console.WriteLine("C → multiplicación");
                Console.WriteLine("D → división");
                Console.WriteLine("E → resto de la división entera.\n");

                opcion = Console.ReadKey(true);

                switch (opcion.Key)
                {
                    case ConsoleKey.A:
                        resultado = suma(num1, num2);
                        Console.WriteLine("La suma es: " + resultado);

                        break;

                    case ConsoleKey.B:
                        resultado = resta(num1, num2);
                        Console.WriteLine("La resta es: " + resultado);
                        break;
                    case ConsoleKey.C:
                        resultado = multiplicacion(num1, num2);
                        Console.WriteLine("La multiplicación es: " + resultado);
                        break;
                    case ConsoleKey.D:
                        resultado = division(num1, num2);
                        Console.WriteLine("La división es: " + resultado);
                        break;
                    case ConsoleKey.E:
                        resultado = modulo(num1, num2);
                        Console.WriteLine("El resto de la división entera es: " + resultado);
                        break;
                    case ConsoleKey.Escape:

                        Console.WriteLine("Adiós.");
                        break;
                    default:
                        Console.WriteLine("La opción ingresada no es válida. Vuelva a intentar.");
                        break;
                }


            } while (opcion.Key != ConsoleKey.Escape);


        }

        private static double suma(double a, double b)
        {
            return a + b;
        }

        private static double resta(double a, double b)
        {
            return a - b;
        }

        private static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        private static double division(double a, double b)
        {
            return a / b;
        }

        private static double modulo(double a, double b)
        {
            return a % b;
        }
    }
}
