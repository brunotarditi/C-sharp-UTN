using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1.Model;
using MySql.Data.MySqlClient;

namespace Ejercicio_1.ConectBD
{
    class Consultas : Conexion
    {
        public List<Escritor> selectEscritor()
        {
            List<Escritor> lista = new List<Escritor>();
            MySqlDataReader reader;
            
            string sql = "SELECT * FROM escritor";
            try
            {
                
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Escritor _escritor = new Escritor();
                    _escritor.Id = long.Parse(reader.GetString(0));
                    _escritor.Nombre = reader[1].ToString();
                    _escritor.Apellido = reader.GetString(2);
                    _escritor.Dni = long.Parse(reader.GetString(3));
                    _escritor.Libros = selectLibros(long.Parse(reader.GetString(0)));
                    lista.Add(_escritor);

                }

            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            return lista;

        }

        public List<Libro> selectLibros(long idEscritor)
        {
            List<Libro> lista = new List<Libro>();
            MySqlDataReader reader;
            
            string sql = "SELECT * FROM libro WHERE idEscritor=" + idEscritor;
            try
            {

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro _libro = new Libro();
                    _libro.Nombre = reader.GetString(0);
                    _libro.AñoPublicacion = long.Parse(reader[1].ToString());
                    _libro.Editorial = reader.GetString(2);

                    lista.Add(_libro);

                }

            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            return lista;

        }

    }
}
