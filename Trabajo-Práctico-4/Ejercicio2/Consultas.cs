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


            int contador = 0;

            try
            {
                conexionBd.Open();


                while (linea != null)

                {
                    while (contador < 50)
                    {

                        string[] arr = linea.Split('\t');

                        // Console.Write(linea);
                        for (int i = 0; i < arr.Length; i = i + 6)

                        {
                            int id = Convert.ToInt32(arr[i]);
                            if (existeArticulo(id))
                            {

                                string sql = "UPDATE articulo_copy SET fechaAlta= @fechaAlta, codigo= @codigo, denominacion= @denominacion, precio= @precio, publicado= @publicado WHERE id= @id";
                                MySqlTransaction transaccion = conexionBd.BeginTransaction();
                                try
                                {

                                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                                    comando.Transaction = transaccion;
                                    comando.Parameters.AddWithValue("@id", arr[i]);
                                    comando.Parameters.AddWithValue("@fechaAlta", Convert.ToDateTime(arr[i + 1]));
                                    comando.Parameters.AddWithValue("@codigo", arr[i + 2]);
                                    comando.Parameters.AddWithValue("@denominacion", arr[i + 3]);
                                    comando.Parameters.AddWithValue("@precio", Convert.ToDouble(arr[i + 4]));
                                    comando.Parameters.AddWithValue("@publicado", arr[i + 5]);
                                    comando.ExecuteNonQuery();
                                    transaccion.Commit();
                                    comando.Parameters.Clear();
                                    Console.WriteLine("Archivo actualizado.");
                                }
                                catch (MySqlException e)
                                {
                                    //transaccion.Rollback();
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
                                MySqlTransaction transaccion = conexionBd.BeginTransaction();
                                try
                                {

                                    MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                                    comando.Transaction = transaccion;
                                    comando.Parameters.AddWithValue("@id", arr[i]);
                                    comando.Parameters.AddWithValue("@fechaAlta", Convert.ToDateTime(arr[i + 1]));
                                    comando.Parameters.AddWithValue("@codigo", arr[i + 2]);
                                    comando.Parameters.AddWithValue("@denominacion", arr[i + 3]);
                                    comando.Parameters.AddWithValue("@precio", Convert.ToDouble(arr[i + 4]));
                                    comando.Parameters.AddWithValue("@publicado", arr[i + 5]);
                                    comando.ExecuteNonQuery();
                                    transaccion.Commit();
                                    comando.Parameters.Clear();
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

                        }
                        linea = reader.ReadLine();
                        Console.WriteLine();
                        contador++;
                    }

                    //Console.WriteLine("50 Cargados.");
                    contador = 0;

                }
                

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);

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


