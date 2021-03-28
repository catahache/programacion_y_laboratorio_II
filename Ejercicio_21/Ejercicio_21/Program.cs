using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnidadesTemperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 21";

            Fahrenheit f = new Fahrenheit(93.2);
            Celsius c = new Celsius(34);
            Kelvin k = new Kelvin(307.15);

            Console.WriteLine("1 grado Celsius equivale a {0} grados Fahrenheit\n1 grado Kelvin equivale a {1} grados Fahrenheit", Celsius.GetTemperatura(), Kelvin.GetTemperatura());

            Console.WriteLine("Cantidad de grados Fahrenheit: {0}\nCantidad de grados Celsius: {1}\nCantidad de grados Kelvin: {2}", f.GetGrados(), c.GetGrados(), k.GetGrados());

            //Console.WriteLine("Total en Fahrenheit: {0}", ((f+c)+k).GetGrados());
            //Console.WriteLine("Total Celsius: {0}", ((c+f)+k).GetGrados());
            //Console.WriteLine("Total en kelvin: {0}",((k+c)+f).GetGrados());

            Console.WriteLine("{0} Fahrenheit son {1} Celsius", f.GetGrados(), ((Celsius)f).GetGrados());
            Console.WriteLine("{0} Kelvin son {1} Celsius", k.GetGrados(), ((Celsius)k).GetGrados());

            Console.WriteLine("Total Celsius: {0}", ((c + f) + k).GetGrados());


            Console.ReadKey();
        }
    }
}
