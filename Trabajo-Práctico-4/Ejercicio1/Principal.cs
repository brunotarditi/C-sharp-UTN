using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio1
{
    class Principal
    {

        static void Main(string[] args)
        {

            Consultas c = new Consultas();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Cargando archivo. . .");
                Thread.Sleep(1000);
                List<String> lista = c.consulta();
                Console.WriteLine("Articulo.txt cargado.");
            }            

        }   

    }
}
