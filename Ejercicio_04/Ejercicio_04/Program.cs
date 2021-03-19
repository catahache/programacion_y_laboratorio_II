using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros 
//positivos (excluido el mismo) que son divisores del número. El primer número perfecto es 6, 
//ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
//Escribir una aplicación que encuentre los 4 primeros números perfectos. 
//Nota: Utilizar estructuras repetitivas y selectivas. 
namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            int num = 6;
            int contadorNumerosPerfectos = 0;

            while(contadorNumerosPerfectos < 4)
            {
                int suma = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        suma += i;
                    }
                }
                //Console.WriteLine("Suma: " + suma+" numero:"+num);
                if (suma == num)
                {
                    Console.WriteLine("Num perfecto: " + num);
                    contadorNumerosPerfectos++;
                }

                num++;
            }
            Console.ReadKey();
        }
    }
}
