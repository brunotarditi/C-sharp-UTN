using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio1
{
    class Principal 
    {

        static void Main(string[] args)
        {

            Consultas c = new Consultas();
            List<String> lista = c.consulta();
            
            foreach (string dato in lista)
            {
                
                Console.WriteLine(dato);
            }
            

           
           
        }

    }
}
