using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moneda;


namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Euro e = new Euro(2);
            Dolar d = new Dolar(2);
            Pesos p = new Pesos(2);

            Console.WriteLine("Cotizacion pesos: {0}\nCotizacion euro: {1}",Pesos.GetCotizacion(), Euro.GetCotizacion());

            Console.WriteLine("Cantidad de dolares: {0}\nCantidad de pesos: {1}\nCantidad de euros: {2}", d.GetCantidad(), p.GetCantidad(), e.GetCantidad());

            Console.WriteLine("Total pesificado: {0}", ((p + d) + e).GetCantidad());
            Console.WriteLine("Total dolarizado: {0}", ((d + p) + e).GetCantidad());
            Console.WriteLine("Total en euros: {0}", ((e + d) + p).GetCantidad());



            Console.ReadKey();
        }
    }
}
