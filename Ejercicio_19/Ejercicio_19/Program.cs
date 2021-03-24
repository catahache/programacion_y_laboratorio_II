using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";

            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();
            Console.WriteLine(sumador.Sumar(3, 4));
            Console.WriteLine(sumador2.Sumar(5, 4));
            Console.WriteLine(sumador2.Sumar(3, 7));
            Console.WriteLine(sumador.Sumar(6, 4));
            Console.WriteLine(sumador.Sumar("Programacion ", "II"));

            Console.WriteLine((int)sumador);//me devolvera la cant de sumas hechas por este sumador
            Console.WriteLine((int)sumador2);//me devolvera la cant de sumas hechas por este sumador

            if (sumador | sumador2)
            {
                Console.WriteLine("Los sumadores tienen la misma cant de sumas");
            }
            else
            {
                Console.WriteLine("Los sumadores no tienen la misma cant de sumas");

            }

            Console.WriteLine("La suma de las cantidades de sumas de ambos sumadores es de: {0}", (sumador + sumador2));

            Console.ReadKey();
        }
    }
}
