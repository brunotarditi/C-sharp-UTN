using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

public class Conexion
{

    public MySqlConnection conexion()
    {
        string servidor = "localhost";
        string bd = "formulario_asp";
        string usuario = "root";
        string password = "1234";

        string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

        try
        {
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            return conexionBD;
        }
        catch (MySqlException ex)
        {

            Console.WriteLine("Error: " + ex.Message);
            return null;
        }

    }
}