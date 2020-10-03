using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//d- Leer el XML mediante XMLTextReader.

namespace Ejercicio_D
{
    class XMLTextReaderFile
    {
        static void Main(string[] args)
        {
            string xml = leerXML();
            Console.Write(xml);
            Console.ReadLine();
        }

        private static string leerXML()
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("Ejercicio-D\\bin\\Debug", "Ejercicio-B\\");

            using (XmlReader reader = XmlReader.Create(path + "empleadosTextWriter.xml"))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "empleados":
                                // Detect this element.
                                resultado += "Start <empleados> element." + "\n";
                                break;
                            case "listado":
                                resultado += "Start <listado> element." + "\n";
                                break;
                            case "empleado":
                                resultado += "Start <empleado> element." + "\n";
                                break;

                            case "id":
                                resultado += "Start <id> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "nombreCompleto":
                                resultado += "Start <nombreCompleto> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "cuil":
                                resultado += "Start <cuil> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "sector":
                                // Detect this element.
                                string attCodigo = reader["denominacion"];
                                string attCodigoOne = reader["id"];
                                string attCodigoTwo = reader["valorSemaforo"];
                                string attCodigoThree = reader["colorSemaforo"];
                                if (attCodigo != null || attCodigoOne != null || attCodigoTwo != null || attCodigoThree != null)
                                {
                                    resultado += "  Has attribute denominacion: " + attCodigo + "\n";
                                    resultado += "  Has attribute id: " + attCodigoOne + "\n";
                                    resultado += "  Has attribute valorSemaforo: " + attCodigoTwo + "\n";
                                    resultado += "  Has attribute colorSemaforo: " + attCodigoThree;
                                }
                                resultado += reader.Value.Trim() + "\n";
                                break;
                            case "cupoAsignado":
                                resultado += "Start <cupoAsignado> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "cupoConsumido":
                                resultado += "Start <cupoConsumido> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n\n";
                                }
                                break;
                            case "subsectores":
                                // Detect this element.
                                resultado += "Start <subsectores> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "totalCupoAsignadoSector":
                                // Detect this element.
                                resultado += "Start <totalCupoAsignadoSector> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "totalCupoConsumidoSector":
                                // Detect this element.
                                resultado += "Start <totalCupoConsumidoSector> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "valorDial":
                                // Detect this element.
                                resultado += "Start <valorDial> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                        }
                    }
                }
            }
            return resultado;
        }
    }
}
