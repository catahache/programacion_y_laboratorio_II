using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//. Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
// a. Mostrar el vector tal como fue ingresado
// b. Luego mostrar los positivos ordenados en forma decreciente.
// c. Por último, mostrar los negativos ordenados en forma creciente.

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";

            Random r = new Random();
            double[] arrayRandom = new double[20];

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                double random = r.Next(-1000, 1001);
                while(random == 0)
                {
                   random = r.Next(-1000, 1001);
                }
                arrayRandom[i] = random;
            }

            Console.WriteLine("Array completo:\n");
            foreach (double num in arrayRandom)
            {
                Console.WriteLine($"{num}\n");
            }

            //primero ordenar decreciente, despues mostrar solo posit
            Array.Sort(arrayRandom); // orden creciente
            Array.Reverse(arrayRandom); // orden decreciente
            Console.WriteLine("\n\nEnteros positivos decreciente:\n");
            foreach (double num in arrayRandom)
            {
                if (num > 0) // solo posit
                {
                    Console.WriteLine($"{num}\n"); 
                }
            }

            //primero ordenar creciente, despues mostrar solo negativos
            Array.Reverse(arrayRandom); // orden creciente
            Console.WriteLine("\n\nNegativos creciente:\n");
            foreach (double num in arrayRandom)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num}\n"); // solo negativos
                }
            }

            Console.ReadKey();
        }
    }
}
