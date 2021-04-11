using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "pag 1";
            libro[1] = "pag 2";
            libro[2] = "pag 3";
            libro[1] = "pag 2 reasignada";
            libro[5] = "pag 5...";

            for(int i = 0; i < libro.Paginas.Count(); i++)
            {
                Console.WriteLine($"{libro[i]} index: {i}");
            }

            Console.ReadKey();
        }
    }
}
