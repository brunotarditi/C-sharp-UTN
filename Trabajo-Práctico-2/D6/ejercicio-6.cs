using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{

    class Deposito : Articulo
    {

        private string nombre;
        private string domicilio;
        private List<Articulo> articulos = new List<Articulo>();

        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Articulo> Articulos {
            get { return articulos; }
            set {articulos = value; } }

        public List<Articulo> ArticulosBajoStock()
        {

            if (StockTotal < StockMinimo)
            {
                return Articulos;
            }

            return Articulos;

        }

    }

    class Articulo
    {

        private int codigo;
        private double stockTotal;
        private double stockMinimo;

        public double StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public double StockTotal { get => stockTotal; set => stockTotal = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
