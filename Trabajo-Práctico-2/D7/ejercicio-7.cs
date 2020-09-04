using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace D7
{

    public class Figura
    {

        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujar Figura.");
        }

    }

    public class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Rectángulo.");
            base.Dibujar();


        }


    }

    public class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Circulo.");
            base.Dibujar();
        }
    }

    public class Triangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Triangulo.");
            base.Dibujar();
        }

    }
    class ejercicio7
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo();
            Circulo c = new Circulo();
            Triangulo t = new Triangulo();
            
            List<Figura> figuras = new List<Figura>();
            figuras.Add(r);           
            figuras.Add(c);
            figuras.Add(t);
            
            

            foreach (Figura f in figuras)
            {
                f.Dibujar();

            }
        }
    }
}
