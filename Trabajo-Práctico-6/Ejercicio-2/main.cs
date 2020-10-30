using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_2.Model;
using Newtonsoft.Json;

/*
 * Leer JSON
Ejecute la lectura de un JSON, obtenido desde la URL randomuser.me/api/?results=10
Codifique las clases necesarias para mapear el JSON en los objetos correspondientes y muestre 
por la consola los atributos
First de name
Last de name
Username de login
Password de login
 */

namespace Ejercicio_2
{
    class main
    {
        static void Main(string[] args)
        {
            LeerJSONFromURL();

        }

        #region Leer JSON URL
        public static void LeerJSONFromURL()
        {

            var url = "https://randomuser.me/api/?results=10";

            WebClient wc = new WebClient();
            string usuariosJson = wc.DownloadString(url);

            var root = JsonConvert.DeserializeObject<Root>(usuariosJson);
            var usuarios = root.results;
            int i = 0;
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(i++ + "\n");
                Console.WriteLine("First name: " + usuario.name.first);
                Console.WriteLine("Last name: " + usuario.name.last);
                Console.WriteLine("Username: " + usuario.login.username);
                Console.WriteLine("Passwords: " + usuario.login.password);
                Console.WriteLine("--------------------------------------");
            }
        }
        #endregion
    }
}
