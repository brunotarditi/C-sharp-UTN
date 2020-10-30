using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*Realice una conexión a la base de datos utn, seleccionaremos los datos de la tabla artículos 
 * haciendo uso de la cláusula LIMIT, ejemplo
SELECT * FROM articulo LIMIT 0, 50; //selecciona los registros del 1 al 50
SELECT * FROM articulo LIMIT 50, 100; //selecciona los registros del 51 al 100
 Escritura del Archivo: Mediante el uso de la clase StreamWriter realice la escritura de un archivo llamado 
articulos.txt que contenga la totalidad de los campos de la tabla artículos. La primera fila del archivo debe 
corresponder al encabezado y debe contener el nombre de las columnas de la tabla.
La escritura del archivo debe hacerse mediante grupos de 50 registros, objetivo que logramos aplicando la 
cláusula LIMIT descripta anteriormente.
Realice la separación de los campos mediante tabulaciones “\t” y la separación de cada fila mediante saltos 
de línea “\n”. Verifique que el archivo pueda abrirse haciendo uso del programa EXCEL.
 */

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
