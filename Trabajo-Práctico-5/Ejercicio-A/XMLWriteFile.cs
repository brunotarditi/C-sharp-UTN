using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//a- Escribir el XML en un archivo.

namespace Ejercicio_A
{
    class XMLWriteFile
    {
        static void Main(string[] args)
        {
            CrearDocumentoXML();
        }

        protected static void CrearDocumentoXML()
        {
            try
            {
                //EMPLEADOS
                XElement empleados = new XElement("empleados");
                
                //LISTADO
                XElement listado = new XElement("listado");

                //PRIMER EMPLEADO
                XElement empleado = new XElement("empleado");
                XElement id = new XElement("id", "4884");
                empleado.Add(id);
                XElement nombre = new XElement("nombreCompleto", "Rodriguez, Victor");
                empleado.Add(nombre);
                XElement cuil = new XElement("cuil", "20103180326");
                empleado.Add(cuil);
                XElement sector = new XElement("sector");
                XAttribute denominacion = new XAttribute("denominacion", "Gerencia Recursos Humanos");
                sector.Add(denominacion);
                XAttribute idSector = new XAttribute("id", "130");
                sector.Add(idSector);
                XAttribute valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                XAttribute colorSemaforo = new XAttribute("colorSemaforo", "VERDE");
                sector.Add(colorSemaforo);
                empleado.Add(sector);
                XElement cupoAsignado = new XElement("cupoAsignado", "1837.15");
                empleado.Add(cupoAsignado);
                XElement cupoConsumido = new XElement("cupoConsumido", "658.02");
                empleado.Add(cupoConsumido);
                //DENTRO DE LISTADO ESTÁ EMPLEADO
                listado.Add(empleado);

                //SEGUNDO EMPLEADO
                empleado = new XElement("empleado");
                id = new XElement("id", "1225");
                empleado.Add(id);
                nombre = new XElement("nombreCompleto", "Sanchez, Juan Ignacio");
                empleado.Add(nombre);
                cuil = new XElement("cuil", "20271265817");
                empleado.Add(cuil);
                sector = new XElement("sector");
                denominacion = new XAttribute("denominacion", "Gerencia Operativa");
                sector.Add(denominacion);
                idSector = new XAttribute("id", "44");
                sector.Add(idSector);
                valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                colorSemaforo = new XAttribute("colorSemaforo", "ROJO");
                sector.Add(colorSemaforo);
                empleado.Add(sector);
                cupoAsignado = new XElement("cupoAsignado", "750.87");
                empleado.Add(cupoAsignado);
                cupoConsumido = new XElement("cupoConsumido", "625.46");
                empleado.Add(cupoConsumido);

                //DENTRO DE LISTADO ESTÁ EMPLEADO
                listado.Add(empleado);
                //DENTRO DE EMPLEADOS ESTÁ LISTADO
                empleados.Add(listado);

                //SUBSECTORES
                XElement subsectores = new XElement("subsectores", "5");
                empleados.Add(subsectores); //DENTRO DE EMPLEADOS
                //TOTAL CUPO ASIGNADO SECTORES
                XElement totalCupoAsignadoSectores = new XElement("totalCupoAsignadoSector", "4217.21");
                empleados.Add(totalCupoAsignadoSectores); //DENTRO DE EMPLEADOS
                XElement totalCupoConsumidoSectores = new XElement("totalCupoConsumidoSector", "1405.88");
                //TOTAL CUPO CONSUMIDO SECTORES
                empleados.Add(totalCupoConsumidoSectores); //DENTRO DE EMPLEADOS
                //VALOR DIAL
                XElement valorDial = new XElement("valorDial", "33.34");
                empleados.Add(valorDial);//DENTRO DE EMPLEADOS

                XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
                XComment comentario = new XComment("Lista de Empleados");
                XDocument miXML = new XDocument(declaration, comentario, empleados);

                string path = Directory.GetCurrentDirectory();
                path = path.Replace("bin\\Debug", "");
                string archivoXML = path + "miXMLEmpleados.xml";
                miXML.Save(@archivoXML);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
