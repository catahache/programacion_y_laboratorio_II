using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar 5 números por consola, guardándolos en una variable escalar. 
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. 
namespace ConsoleApp1
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int maximo = 0;
            int minimo = 0;
            float acum = 0;
            float promedio;
            const int VUELTAS = 5;

            for(int i = 0; i < VUELTAS; i++)
            {
                Console.Title = "Ejercicio Nro 01";

                Console.Write("Ingresa un numero: ");
                int aux = int.Parse(Console.ReadLine());

                if(aux > numero)
                {
                    maximo = aux;
                }
                else if(aux < numero)
                {
                    minimo = aux;
                }

                numero = aux;
                acum += numero;
            }

            promedio = acum / VUELTAS;

            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadKey();
        }
    }
}
