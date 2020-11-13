using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Empleado> empleados = new List<Empleado>() {
                new Empleado() { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio = "Salta 314", Localidad = "Ciudad", Salario = 30000, DiasInasistencia = 0 } ,
                new Empleado() { Id = 2, Nombre = "Pedro", Apellido = "Hernandez", Domicilio = "San Martin 456", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 1 } ,
                new Empleado() { Id = 3, Nombre = "Jose", Apellido = "Chatruc", Domicilio = "Lavalle 789", Localidad = "Lujan", Salario = 28000, DiasInasistencia = 12 } ,
                new Empleado() { Id = 4, Nombre = "Carlos" , Apellido = "Alonso", Domicilio = "Rioja 14", Localidad = "Guaymallen", Salario = 45000, DiasInasistencia = 5 } ,
                new Empleado() { Id = 5, Nombre = "Claudio" , Apellido = "Ahumada", Domicilio = "Lima 125", Localidad = "Tupungato", Salario = 38000, DiasInasistencia = 0 } ,
                new Empleado() { Id = 5, Nombre = "Sebastian" , Apellido = "Tobar", Domicilio = "Rawson 123", Localidad = "Lujan", Salario = 42000, DiasInasistencia = 2 } ,
                new Empleado() { Id = 5, Nombre = "Javier" , Apellido = "Puebla", Domicilio = "Italia 987", Localidad = "Ciudad", Salario = 33000, DiasInasistencia = 4 } ,
                new Empleado() { Id = 5, Nombre = "Fabian" , Apellido = "Gilar", Domicilio = "Las Viñas 987", Localidad = "Guaymallen", Salario = 38000, DiasInasistencia = 0 } ,
                new Empleado() { Id = 5, Nombre = "Victor" , Apellido = "Pereira", Domicilio = "25 de Mayo 654", Localidad = "Tupungato", Salario = 37000, DiasInasistencia = 8 } ,
                new Empleado() { Id = 5, Nombre = "Nelson" , Apellido = "Piquet", Domicilio = "Peru 987", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 3 }
            };

            var empleados1 = from Empleado in empleados where Empleado.Localidad.Equals("Ciudad") select Empleado;
            var empleados2 = from Empleado in empleados where Empleado.Apellido.StartsWith("A") select Empleado;
            var empleados3 = from Empleado in empleados where Empleado.DiasInasistencia == 0 select Empleado;
            var empleados4 = from Empleado in empleados where Empleado.Localidad.Equals("Ciudad") && Empleado.Salario > 35000 select Empleado;
            var empleados5 = from Empleado in empleados where Empleado.DiasInasistencia != 0 || Empleado.Salario <= 30000 select Empleado;
            var empleados6 = from Empleado in empleados where Empleado.Nombre.EndsWith("n") select Empleado;
            var empleados7 = from Empleado in empleados orderby Empleado.Salario ascending select Empleado;
            var empleados8 = from Empleado in empleados orderby Empleado.DiasInasistencia descending select Empleado;
            var empleados9 = from Empleado in empleados group Empleado by Empleado.Localidad;
            var count = (from Empleado in empleados select Empleado.Salario).Count();
            var max = (from Empleado in empleados select Empleado.Salario).Max();
            var average = (from Empleado in empleados select Empleado.Salario).Average();
            var first = (from Empleado in empleados select Empleado).First();

            Console.WriteLine("Los empleados de la Localidad de Ciudad son:");
            Console.WriteLine();
            foreach (Empleado e in empleados1)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido + " - Domicilio: " + e.Domicilio);

            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados cuyo apellido inicien con 'A' son:");
            Console.WriteLine();
            foreach (Empleado e in empleados2)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados que no tengan inasistencias son:");
            Console.WriteLine();
            foreach (Empleado e in empleados3)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados de la Localidad de Ciudad y cuyo salario es mayor a 35000 son:");
            Console.WriteLine();
            foreach (Empleado e in empleados4)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido + " - Domicilio: " + e.Domicilio + " - Salario: " + e.Salario);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados que tengan inasistencias y cuyo salario es menor o igual a 30000 son:");
            Console.WriteLine();
            foreach (Empleado e in empleados5)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido + " - Domicilio: " + e.Domicilio + " - Salario: " + e.Salario);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados que finalicen sus nombres con 'n' son:");
            Console.WriteLine();
            foreach (Empleado e in empleados6)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados con salarios ordenados de forma ascendente son:");
            Console.WriteLine();
            foreach (Empleado e in empleados7)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido + " - Salario: " + e.Salario);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados con días de inasistencias ordenados de forma descendente son:");
            Console.WriteLine();
            foreach (Empleado e in empleados8)
            {
                Console.WriteLine("Nombre: " + e.Nombre + " - Apellido: " + e.Apellido + " - Días de inasistencias: " + e.DiasInasistencia);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los empleados agrupados por Localidad son:");
            Console.WriteLine();

            foreach (var empGroup in empleados9)
            {
                Console.WriteLine(empGroup.Key);
                foreach(Empleado e in empGroup){
                    Console.WriteLine("     {0} {1}", e.Nombre, e.Apellido);
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("La cantidad de salarios es de: " + count);
            Console.WriteLine("El máximo salario es: " + max);
            Console.WriteLine("El promedio de salarios es: " + average);
            Console.WriteLine("El primer empleado es: " + "ID: {0}, {1} {2}",first.Id , first.Nombre, first.Apellido);
        }
    }
}
