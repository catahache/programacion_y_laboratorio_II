using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Un centro numérico es un número que separa una lista de números enteros 
//(comenzando en 1) en dos grupos de números, cuyas sumas son iguales. 
//El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: 
//(1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
//El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: 
//(1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
//Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número 
//que el usuario ingrese por consola. 
//Nota: Utilizar estructuras repetitivas y selectivas. 
namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese num: ");
            int numIngresado = int.Parse(Console.ReadLine());
            int prev = 0;
            for(int i = 1; i < numIngresado; i++)//i = centro, hasta uno antes del num ingresado
            {
                //prev += i;//1, 3, 6, 10...
                prev += i - 1;
                int next = 0;
                for(int j = i+1; next < prev ; j++ )//next
                {
                    next += j;
                    if(prev == next)
                    {
                        //i es centro
                        Console.WriteLine(i + " es centro numerico");
                        break;
                    }
                }
            }
            Console.WriteLine("Listo");
            Console.ReadKey();
        }
    }
}
