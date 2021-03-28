using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Billetes;

//a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos. 
//b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos. 
//c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
//d. Colocar dentro del Main el código necesario para probar todos los métodos. 
//e. Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases. 
//f. Los comparadores == compararan cantidades. 
//g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido. Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos. 
//h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso. 
namespace Ejercicio_20
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
