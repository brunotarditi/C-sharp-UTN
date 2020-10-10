using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1.ConectBD;
using Ejercicio_1.Model;
using Newtonsoft.Json;

namespace Ejercicio_1
{
    class main
    {
        static void Main(string[] args)
        {
            Consultas c = new Consultas();
            string path = @"D:\Documentos\Programación UTN\3.Lab de computación 3\C-sharp-UTN\Trabajo-Práctico-6\bookstore.json";
           
            EscribirJsonFile(c.selectEscritor(), path);


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
