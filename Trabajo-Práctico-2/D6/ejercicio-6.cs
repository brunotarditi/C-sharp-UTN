using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{

    class Deposito
    {

        private string nombre;
        private string domicilio;
        private List<Articulo> articulos = new List<Articulo>();
        private List<Articulo> ar = new List<Articulo>();

        public Deposito()
        {
        }

        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Articulo> Articulos { get { return articulos; } }

        public void setArticulos(Articulo art)
        {
            articulos.Add(art);
        }
        public void ArticulosBajoStock()
        {
            foreach (Articulo art in Articulos)
            {

                if (art.StockTotal <= art.StockMinimo)
                {
                    ar.Add(art);
                }

            }

        }

        public void mostrarArticulos()
        {
            Console.WriteLine("Los articulos con bajo stock son: ");
            foreach (Articulo art in ar)
            {
                Console.WriteLine(art.Codigo);
            }
        }

    }

    class Articulo
    {

        private string codigo;
        private double stockTotal;
        private double stockMinimo;

        public Articulo(string codigo, double stockTotal, double stockMinimo)
        {
            this.codigo = codigo;
            this.stockTotal = stockTotal;
            this.stockMinimo = stockMinimo;
        }

        public double StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public double StockTotal { get => stockTotal; set => stockTotal = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Deposito d = new Deposito();
            Articulo a1 = new Articulo("Tv", 4, 2);
            Articulo a2 = new Articulo("Notebook", 1, 1);
            Articulo a3 = new Articulo("Celular", 15, 8);
            d.setArticulos(a1);
            d.setArticulos(a2);
            d.setArticulos(a3);
            d.ArticulosBajoStock();
            d.mostrarArticulos();




        }
    }
}
