using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio2
{
    class Principal 
    {
        static void Main(string[] args)
        {

            Consultas c = new Consultas();
            c.insertar();

        }
    }
}
