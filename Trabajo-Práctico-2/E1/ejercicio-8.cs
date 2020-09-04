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
