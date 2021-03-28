using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crear la clase Bolígraf
namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);

            boliAzul.Pintar(90, out string dibujoAzul);
            Console.ForegroundColor = boliAzul.GetColor();
            Console.WriteLine(dibujoAzul);
            Console.WriteLine("El boligrafo azul tiene un nivel de tinta de {0}", boliAzul.GetTinta());
            boliAzul.Recargar();
            Console.WriteLine("Luego de recargar, el boligrafo azul tiene un nivel de tinta de {0}\n", boliAzul.GetTinta());

            boliRojo.Pintar(60, out string dibujoRojo);
            Console.ForegroundColor = boliRojo.GetColor();
            Console.WriteLine(dibujoRojo);
            Console.WriteLine("El boligrafo rojo tiene un nivel de tinta de {0}", boliRojo.GetTinta());
            boliRojo.Recargar();
            Console.WriteLine("Luego de recargar, el boligrafo rojo tiene un nivel de tinta de {0}", boliRojo.GetTinta());
            boliRojo.Pintar(80, out dibujoRojo);
            Console.WriteLine(dibujoRojo);
            Console.WriteLine("El boligrafo rojo tiene un nivel de tinta de {0}", boliRojo.GetTinta());

            Console.ReadKey();
        }
    }
}
