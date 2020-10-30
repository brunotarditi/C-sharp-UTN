using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/*
 Lectura del Archivo: Mediante el uso de la clase StreamReader realice la lectura del archivo articulos.txt 
generado en el punto anterior, posteriormente realice una conexión a la base de datos utn e inserte en la tabla 
articulo_copy la información leída del archivo. La inserción en la tabla de base de datos debe realizarse 
ejecutando 1 transacción cada 50 filas leídas del archivo, deberá determinar si corresponde realizar un INSERT o 
un UPDATE haciendo uso del campo código para determinar si el registro ya existe o no en la tabla. Al finalizar 
controle que la cantidad de registros de la tabla articulo y articulo_copy sean la misma.
 */
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
