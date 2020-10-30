using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1.ConectBD;
using Ejercicio_1.Model;
using Newtonsoft.Json;

/*
 Escribir JSON
Cree 2 tablas de base de datos:
Escritor: Campos-> id(PK),apellido, nombre, dni
Libro: Campos->nombre, año publicación, editorial, idEscritor(FK)
Cargue algunos campos de prueba en ambas tablas relacionando el escritor con el libro mediante sus claves (PK/FK)
Mediante C# realice la conexión a la base de datos, obtenga los datos y ejecute la escritura en un archivo con la siguiente estructura JSON.
 */

namespace Ejercicio_1
{
    class main
    {
        static void Main(string[] args)
        {
            Consultas c = new Consultas();
            string path = @"D:\Documentos\Programación UTN\3.Lab de computación 3\C-sharp-UTN\Trabajo-Práctico-6\bookstore.json";
           
            EscribirJsonFile(c.selectEscritor(), path);
            Console.WriteLine("Archivo JSON creado.");

        }

        #region EscrituraJSON
        public static void EscribirJsonFile(List<Escritor> escritores, string pathFile)
        {

            string jsonFile = JsonConvert.SerializeObject(escritores.ToArray(), Formatting.Indented);

            File.WriteAllText(pathFile, jsonFile);


        }

        #endregion
    }

}
