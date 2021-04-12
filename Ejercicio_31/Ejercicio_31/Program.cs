using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaDeAtencion;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 31";

            Cliente c1 = new Cliente(1, "Cata");
            Cliente c2 = new Cliente(2, "Dilem");
            Cliente c3 = new Cliente(3, "Raul");
            Cliente c4 = new Cliente(4, "Omar");

            Negocio tienda = new Negocio("tienda");

            int numActual = PuestoAtencion.NumeroActual;

            // Agrego clientes a tienda
            bool agrego = tienda + c1;
            agrego = tienda + c2;
            agrego = tienda + c3;
            agrego = tienda + c2; // no lo agrega
            agrego = tienda + c4;

            Console.WriteLine(tienda.ClientesPendientes);

            if (~(tienda))
            {
                Console.WriteLine(tienda.ClientesPendientes);
            }
            Console.ReadKey();
        }
    }
}
