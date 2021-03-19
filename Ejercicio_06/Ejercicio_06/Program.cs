using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa que determine si un año es bisiesto. 
//Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
//salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 
//1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años 
//bisiestos en ese rango. Nota: Utilizar estructuras repetitivas, selectivas y la 
//función módulo (%). 

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese anio: ");
            int anio = int.Parse(Console.ReadLine());
            bool isBiciesto = false;

            for(int i = 1; i < anio; i++)
            {
                if((100 * i != anio)&&(4 * i == anio))
                {
                    Console.WriteLine("Anio es multiplo de 4: " + i);
                    isBiciesto = true;
                }
                if((100 * i == anio))
                {
                    Console.WriteLine("Anio es multiplo de 100");
                    for(int j = 1; j < anio; j++)
                    {
                        if (400 * j == anio)
                        {
                            Console.WriteLine("Anio es multiplo de 400");
                            isBiciesto = true;
                            break;
                        }
                    }
                    break;//ya si es multiplo de 100, pero no de 400, corta el bucle porque puede ser que haya otro num superior multiplo de 4 que vuelva a entrar y poner true
                }
            }
            if (isBiciesto)
            {
                Console.WriteLine(anio + " es biciesto.");
            }
            else
            {
                Console.WriteLine(anio + " no es biciesto.");
            }
            Console.ReadKey();
        }
    }
}
