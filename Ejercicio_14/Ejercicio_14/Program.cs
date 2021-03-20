using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

// Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el cálculo del área que corresponda:  a. double CalcularCuadrado(double) b. double CalcularTriangulo(double, double) c. double CalcularCirculo(double) El ingreso de los datos como la visualización se deberán realizar desde el método Main(). 
namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            Console.WriteLine("Cuadrado. Base = 5, Area = {0}", CalculoDeArea.CalcularCuadrado(5));
            Console.WriteLine("Triangulo. Base = 5, altura= 7, Area = {0}", CalculoDeArea.CalcularTriangulo(5, 7));
            Console.WriteLine("Cuadrado. Radio = 8, Area = {0}", CalculoDeArea.CalcularCirculo(8));

            Console.ReadKey();
        }
    }
}
