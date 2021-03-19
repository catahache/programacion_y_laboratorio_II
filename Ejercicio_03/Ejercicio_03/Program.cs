using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mostrar por pantalla todos los números primos que haya 
//hasta el número que ingrese el usuario por consola. 
//Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            Console.Write("Ingresar numero: ");
            int num = int.Parse(Console.ReadLine());

            for(; num > 0; num--)
            {
                bool isPrimo = true;
                for (int i = 2; i < num; i++)
                {
                    if ((num % i) == 0)//si el modulo da 0 no es primo
                    {
                        isPrimo = false;
                    }
                }
                if (isPrimo) { Console.WriteLine(num); }
                num--;
            }
            Console.ReadKey();
        }
    }
}
