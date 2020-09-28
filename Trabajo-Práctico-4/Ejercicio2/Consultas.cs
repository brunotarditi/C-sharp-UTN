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
            StreamReader reader = new StreamReader(@"D:\articulo_copy.txt");
            //Leer hasta salto de línea
            string linea = reader.ReadLine();
            //CONECTAR A LA BASE DE DATOS
            MySqlConnection conexionBd = base.conexion();

            //Este contador sirve como condición de hasta cuantas lineas cargar
            int contador = 0;

            try
            {
                //se abre la conexion
                conexionBd.Open();

                //Mientras la linea sea distinta a null entra al bucle
                while (linea != null)

                {
                    //Mientras el contador sea menor a 50 entra al bucle
                    while (contador < 50)
                    {
                        //Splitea la tabulación de la linea
                        string[] arr = linea.Split('\t');
                        
                        //Recorremos la linea
                        for (int i = 0; i < arr.Length; i = i + 6)

                        {
                            //Se almacena la primera posición del arreglo que es el id en un entero
                            int id = Convert.ToInt32(arr[i]);
                            if (existeArticulo(id))//Corresponde a la validación del método
                            {
                                //Query
                                string sql = "UPDATE articulo_copy SET fechaAlta= @fechaAlta, codigo= @codigo, denominacion= @denominacion, precio= @precio, publicado= @publicado WHERE id= @id";
                                MySqlTransaction transaccion = conexionBd.BeginTransaction();
                                try
                                {
                                    //Se crea el comando y se le pasa la conexion y la query
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
                            {   //Query
                                string sql = "INSERT INTO articulo_copy VALUES (@id, @fechaAlta, @codigo, @denominacion, @precio, @publicado)";
                                MySqlTransaction transaccion = conexionBd.BeginTransaction();
                                try
                                {
                                    //Se crea el comando y se le pasa la conexion y la query
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
                        //Leer siguiente linea hasta el salto
                        linea = reader.ReadLine();
                        Console.WriteLine();
                        contador++; //contador aumenta en 1
                        
                    }

                    Console.WriteLine("50 FUERON CARGADOS."); 
                    contador = 0; //Reinicia el contador
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

        private bool existeArticulo(int id) //Este método retorna una condición booleana en caso de existir o no un articulo
        {
            //Se crea una conexión
            MySqlConnection conexionBd = base.conexion();
            conexionBd.Open(); //Se abre la conexión
            string sql = "SELECT id FROM articulo_copy WHERE id='" + id + "'"; //query → Seleccionar id de articulo_copy donde id sea id referido
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


