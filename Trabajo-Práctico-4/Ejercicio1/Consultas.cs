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
            StreamWriter writer = new StreamWriter(@"D:\articulo_copy.txt");           
            MySqlConnection conexionBD = base.conexion();
            int limit = 0;
            int registros = registrosTotales();
            string cabecera = "id \t fechaAlta \t codigo \t denominacion \t precio \t publicado\n";
            writer.Write(cabecera);
            while (limit <= registros)
            {
                try
                {
                    conexionBD.Open();                                      
                    string sql = "SELECT * FROM articulo LIMIT " + limit + ", " + 50 + "";
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
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
