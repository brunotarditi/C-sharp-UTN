using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{

    public class cheque
    {
        private int nroInterno;

        public string Banco { get; set; }

        public string Propietario { get; set; }

        public decimal Importe { get; set; }
        public int Numero { get; set; }

        public void Guardar()
        {
            Console.WriteLine("Guardar.");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        protected void ValidarNroInterno()
        {
            Console.WriteLine("Validar");
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
