using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejercicio2
{
    class Consultas : Conexion
    {

        public void insertar()
        {
            //ABRIR PARA LEER EL ARCHIVO
            StreamReader reader = new StreamReader(@"D:\prueba.txt");
            //Leamos todas las lineas
            string linea = reader.ReadLine();
            //CONECTAR A LA BASE DE DATOS
            MySqlConnection conexionBd = base.conexion();
            conexionBd.Open();
            MySqlCommand comando = conexionBd.CreateCommand();
            MySqlTransaction transaccion;
            transaccion = conexionBd.BeginTransaction();
            comando.Connection = conexionBd;
            comando.Transaction = transaccion;
            int contador = 0;
            try
            {
                             
                while (contador < 50)
                {
                    while (linea != null)

                    { 
                        string[] arr = linea.Split('\t');
                  
                        // Console.Write(linea);
                        for (int i = 0; i < arr.Length; i = i + 6)

                        {
                            int id = Convert.ToInt32(arr[i]);
                            if (existeArticulo(id))
                            {
                                string sql = "UPDATE articulo_copy SET fechaAlta= @fechaAlta, codigo= @codigo, denominacion= @denominacion, precio= @precio, publicado= @publicado WHERE id= @id";
                                try
                                {
                                    comando = new MySqlCommand(sql);                                   
                                    comando.Parameters.AddWithValue("@id", arr[i]);
                                    comando.Parameters.AddWithValue("@fechaAlta", Convert.ToDateTime(arr[i + 1]));
                                    comando.Parameters.AddWithValue("@codigo", arr[i + 2]);
                                    comando.Parameters.AddWithValue("@denominacion", arr[i + 3]);
                                    comando.Parameters.AddWithValue("@precio", Convert.ToDouble(arr[i + 4]));
                                    comando.Parameters.AddWithValue("@publicado", arr[i + 5]);
                                    comando.ExecuteNonQuery();
                                    transaccion.Commit();
                                    Console.WriteLine("Archivo actualizado.");
                                }
                                catch (MySqlException e)
                                {

                                    try
                                    {
                                        transaccion.Rollback();
                                    }
                                    catch (MySqlException ex)
                                    {
                                        if (transaccion.Connection != null)
                                        {
                                            Console.WriteLine("Exception de tipo " + ex.GetType() +
                                            " al ejecutar el roll back de la transaction.");
                                        }
                                    }
                                    Console.WriteLine("Exception de tipo " + e.GetType() +
                                    " mientras se insertaban los datos.");
                                }
                            }
                            else
                            {
                                string sql = "INSERT INTO articulo_copy VALUES (@id, @fechaAlta, @codigo, @denominacion, @precio, @publicado)";
                                try
                                {
                                    comando = new MySqlCommand(sql);
                                    comando.Parameters.AddWithValue("@id", arr[i]);
                                    comando.Parameters.AddWithValue("@fechaAlta", Convert.ToDateTime(arr[i + 1]));
                                    comando.Parameters.AddWithValue("@codigo", arr[i + 2]);
                                    comando.Parameters.AddWithValue("@denominacion", arr[i + 3]);
                                    comando.Parameters.AddWithValue("@precio", Convert.ToDouble(arr[i + 4]));
                                    comando.Parameters.AddWithValue("@publicado", arr[i + 5]);
                                    comando.ExecuteNonQuery();
                                    transaccion.Commit();
                                    Console.WriteLine("Archivo insertado.");
                                }
                                catch (MySqlException e)
                                {

                                    try
                                    {
                                        transaccion.Rollback();
                                    }
                                    catch (MySqlException ex)
                                    {
                                        if (transaccion.Connection != null)
                                        {
                                            Console.WriteLine("Exception de tipo " + ex.GetType() +
                                            " al ejecutar el roll back de la transaction.");
                                        }
                                    }
                                    Console.WriteLine("Exception de tipo " + e.GetType() +
                                    " mientras se insertaban los datos.");
                                }
                            }
                            //LEER LA SIGUIENTE LINEA DEL ARCHIVO
                            linea = reader.ReadLine();
                            Console.WriteLine();
                            contador++;

                        }
                    }
                                      
                }               

                contador = 0;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //CERRAR LA LECTURA DEL ARCHIVO
                reader.Close();
                //CERRAR CONEXION
                conexionBd.Close();
            }

        }

        private bool existeArticulo(int id)
        {
            MySqlConnection conexionBd = base.conexion();
            conexionBd.Open();
            string sql = "SELECT id FROM articulo_copy WHERE id='" + id + "'";
            MySqlCommand comando = new MySqlCommand(sql, conexionBd);
            int num = Convert.ToInt32(comando.ExecuteScalar());

            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}


