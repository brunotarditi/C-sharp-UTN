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
            StreamWriter write = new StreamWriter(@"D:\articulo.txt");
            string sql = limit();
            MySqlConnection conexionBD = base.conexion();
            try
            {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();
                    string cabecera = "id \t fechaAlta \t codigo \t denominacion \t precio \t publicado\n";
                    write.Write(cabecera);

                    while (reader.Read())
                    {

                        dato += reader.GetString(0) + "\t";
                        dato += reader.GetString(1) + "\t";
                        dato += reader.GetString(2) + "\t";
                        dato += reader.GetString(3) + "\t";
                        dato += reader.GetString(4) + "\t";
                        dato += reader.GetString(5);
                        lista.Add(dato);
                        write.Write(dato);
                        write.WriteLine();
                        dato = "";

                    }

            }

            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                write.Close();
                conexionBD.Close();
               
            }

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

        public string limit()
        {
            string sql = "";
            int limit = 50;
            int registros = registrosTotales() + 50;
            while (limit < registros)
            {

                sql = "SELECT * FROM articulo LIMIT " + limit;
                limit += 50;

            }

            return sql;
        }
    }
}
