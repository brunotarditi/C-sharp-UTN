/*En primer lugar, cree una clase base llamada Figura y luego cree clases derivadas como Rectángulo, Circulo y Triangulo.
Incluya en la clase Figura un método virtual llamado Dibujar() que imprima por consola el mensaje “Dibuja Figura” y 
sobrescriba el método (override) en cada clase derivada para dibujar la forma determinada que representa la clase, es decir 
que para Rectángulo el método debe imprimir por consola “Dibuja Rectángulo”, para Circulo “Dibuja Circulo” y para Triangulo 
“Dibuja Triangulo”.
Finalmente en el método static void Main() cree un objeto List<Figura> y agregue al mismo instancias de Circulo, Triangulo y 
Rectángulo.
Utilice un bucle foreach para recorrer en iteración la lista y llamar al método Dibujar () en cada objeto Figura de la lista.
Aunque cada objeto de la lista tiene un tipo declarado de Figura, es el tipo en tiempo de ejecución el que se invocará.
El resultado del programa debería ser:
Dibuja Rectángulo
Dibuja Figura
Dibuja Círculo
Dibuja Figura
Dibuja Triangulo
Dibuja Figura
 */

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
