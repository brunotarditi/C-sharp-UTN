using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

public class Gestor : Conexion
{

    public void guardar(string nombre, string apellido, string usuario, string contrasenia, string fech_nac, string sexo, string telefono, string email_alt, string ubicacion)
    {
        MySqlConnection conexionBd = base.conexion();
       
        try
        {
            
            //Query
            string sql = "INSERT INTO usuario_asp VALUES (@nombre, @apellido, @usuario, @password, @fech_nac, @sexo, @telefono, @email_alt, @ubicacion)";
            conexionBd.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBd);         
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", contrasenia);
            comando.Parameters.AddWithValue("@fech_nac", fech_nac);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email_alt", email_alt);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);
            comando.ExecuteNonQuery();
            
        }
        catch (MySqlException ex)
        {
            
            Console.WriteLine("Error:" + ex.Message);
        }
        finally
        {
            conexionBd.Close();
        }

    }

}
