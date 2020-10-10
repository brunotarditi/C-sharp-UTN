using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Model
{
    class Escritor
    {

        public long Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public long Dni { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
