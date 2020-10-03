using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

//Leer el XML.

namespace Ejercicio_C
{
    class XMLReadFile
    {
        static void Main(string[] args)
        {

            string xml = leerXML();
            Console.Write(xml);
            Console.ReadLine();
        }

        public static string leerXML()
        {
            string resultado = "";

            string path = Directory.GetCurrentDirectory();
            path = path.Replace("Ejercicio-C\\bin\\Debug", "Ejercicio-A\\");

            try
            {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path + "miXMLEmpleados.xml");

                XmlNodeList empleados = xDoc.GetElementsByTagName("empleados");
                XmlNodeList listado = xDoc.GetElementsByTagName("listado");
                XmlNodeList subsectores = xDoc.GetElementsByTagName("subsectores");
                XmlNodeList listaEmpleado = ((XmlElement)listado[0]).GetElementsByTagName("empleado");
                XmlNodeList listaSubsectores = ((XmlElement)empleados[0]).GetElementsByTagName("subsectores");
                XmlNodeList listaTotalCupoAsignadoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoAsignadoSector");
                XmlNodeList listaTotalCupoConsumidoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoConsumidoSector");
                XmlNodeList listaValorDial = ((XmlElement)empleados[0]).GetElementsByTagName("valorDial");


                foreach (XmlElement nodo in listaEmpleado)
                {

                    int i = 0;

                    XmlNodeList _id = nodo.GetElementsByTagName("id");
                    XmlNodeList _nombre = nodo.GetElementsByTagName("nombreCompleto");
                    XmlNodeList _cuil = nodo.GetElementsByTagName("cuil");
                    XmlNodeList sector = nodo.GetElementsByTagName("sector");

                    String aux = "";
                    String denominacion = ((XmlElement)sector[0]).GetAttribute("denominacion");
                    String idS = ((XmlElement)sector[0]).GetAttribute("dd");
                    String valorSemaforo = ((XmlElement)sector[0]).GetAttribute("valorSemaforo");
                    String colorSemaforo = ((XmlElement)sector[0]).GetAttribute("colorSemaforo");
                    aux += "Denominación: " + denominacion + " Id: " + idS + " Valor Semáforo: " + valorSemaforo + " Color Semáforo: " + colorSemaforo;
                    
                    XmlNodeList _cupoAsignado = nodo.GetElementsByTagName("cupoAsignado");
                    XmlNodeList _cupoConsumido = nodo.GetElementsByTagName("cupoConsumido");

                    resultado += "Elemento empleado:\n" + "ID: " + _id[i].InnerText + " " +
                        "\nNombre: " + _nombre[i].InnerText + " " +
                        "\nCuil: " + _cuil[i].InnerText + " " +
                        "\nSector: [" + aux + "]" +
                        "\nCupo asignado: " + _cupoAsignado[i].InnerText + "\n" +
                        "Cupo consumido: " + _cupoConsumido[i++].InnerText + "\n\n";
                }
                resultado += "Subsectores: " + listaSubsectores[0].InnerText + "\n" + "Total cupo asignado sector: " + 
                    listaTotalCupoAsignadoSector[0].InnerText + "\n" + "Total cupo consumido sector: " + 
                    listaTotalCupoConsumidoSector[0].InnerText + "\n" + "Valor dial:" + listaValorDial[0].InnerText;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

            return resultado;

        }
    }
}
