/*Codifique un programa que contenga un método llamado “ejecutarHiloCincoSeg()” que imprima por consola la leyenda 
 * “HILO EJECUTADO 5” y otro método llamado “ejecutarHiloDiezSeg()”que imprima por consola la leyenda “HILO EJECUTADO 10” 
 * implemente el código necesario para que por medio de la ejecución de Hilos el mensaje del método “ejecutarHiloCincoSeg()” 
 * se ejecute y muestre cada 5 segundos y el mensaje del método “ejecutarHiloDiezSeg()” se ejecute y muestre cada 10 segundos.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E1
{
    class ejercicio8
    {
        static void Main(string[] args)
        {

            new Thread(ejecutarHilo5Seg).Start();
            new Thread(ejecutarHilo10Seg).Start();

        }

        static void ejecutarHilo5Seg()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("HILO EJECUTADO 5");
                
            }
            
        }

        static void ejecutarHilo10Seg()
        {
            for (int i = 0; i < 5; i++)
            {

                Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("HILO EJECUTADO 10");
            }    
            
        }
    }
}
