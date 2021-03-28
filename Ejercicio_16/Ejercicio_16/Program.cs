using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno roberto = new Alumno("Roberto", "Asdn", 12345);
            Alumno ricardo = new Alumno("Ricardo", "Uhdsh", 12346);
            Alumno ruben = new Alumno("Ruben", "Posid", 12347);

            roberto.Estudiar(2, 7);
            ricardo.Estudiar(6, 10);
            ruben.Estudiar(10, 9);

            roberto.CalcularFinal();
            ricardo.CalcularFinal();
            ruben.CalcularFinal();

            Console.WriteLine(roberto.Mostrar());
            Console.WriteLine(ricardo.Mostrar());
            Console.WriteLine(ruben.Mostrar());

            Console.ReadKey();

        }
    }
}
