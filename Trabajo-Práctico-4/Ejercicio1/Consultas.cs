using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio1
{
    class Consultas : Conexion
    {


        public List<String> consulta()
        {
            
            MySqlDataReader reader = null;        
            List<String> lista = new List<string>();
            string dato = null;          
            //Se crea el StreamWriter para crear un archivo txt
            StreamWriter writer = new StreamWriter(@"D:\articulo_copy.txt");
            //Se realiza la conexión a la base de datos
            MySqlConnection conexionBD = base.conexion();
            //La variable entera limit sera la encargada de aumentar en 50 la escritura
            int limit = 0;
            int registros = registrosTotales(); //Metodo para saber la cantidad de registros de la base de datos
            //Esta cadena de texto pinta una línea en el txt con el siguiente contenido
            string cabecera = "id \t fechaAlta \t codigo \t denominacion \t precio \t publicado\n";
            writer.Write(cabecera);
            //Mientras el limit sea menor a la cantidad de registros entra
            while (limit <= registros)
            {
                try
                {
                    //Se abre la conexión
                    conexionBD.Open();
                    //Query → Selecciona todo de articulo con un limit de 50 en 50 y solo mostrando 50 registros
                    string sql = "SELECT * FROM articulo LIMIT " + limit + ", " + 50 + "";
                    //Se crea el comando al que se le pasa la query y la conexión
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    //Con reader se leen los registros de la base de datos
                    reader = comando.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        
                        dato += reader.GetString(0) + "\t";                       
                        dato += reader.GetString(1) + "\t";                       
                        dato += reader.GetString(2) + "\t";                       
                        dato += reader.GetString(3) + "\t";                       
                        dato += reader.GetString(4) + "\t";                       
                        dato += reader.GetString(5);                       
                        lista.Add(dato);
                        writer.Write(dato);
                        writer.WriteLine();
                        dato = "";
                        
                    }
                    limit += 50;
                    if (limit <= registros)
                    {
                        writer.WriteLine("------------------------------------------LOTE DE 50 CARGADO------------------------------------------");

                    }
                }

                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                }
                finally
                {
                    
                    conexionBD.Close();

                }
            }
            writer.Close();

            return lista;

        }

        public int registrosTotales()
        {
            MySqlDataReader reader = null;
            string sql = "SELECT COUNT(*) FROM articulo";
            int registro = 0;
            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    registro = int.Parse(reader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            return registro;

        }

       
    }
}
