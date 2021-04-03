using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 22";

            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            string numeroBinario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

            Console.WriteLine("Suma en binario: {0}", objBinario + objDecimal);
            Console.WriteLine("Suma en decimal: {0}", objDecimal + objBinario);
            Console.WriteLine("Resta en binario: {0}", objBinario - objDecimal);
            Console.WriteLine("Resta en decimal: {0}", objDecimal - objBinario);

            if (objBinario == objDecimal)
            {
                Console.WriteLine("Los numeros {0} y {1} son iguales", (string)objBinario, (double)objDecimal);
            }
            else
            {
                Console.WriteLine("Los numeros {0} y {1} no son iguales", (string)objBinario, (double)objDecimal);
            }

            Console.ReadKey();
        }
    }
}
