using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

// Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): string DecimalBinario(int). Convierte un número de entero a binario. int BinarioDecimal(string). Convierte un número binario a entero. 

//NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control. 
namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            int numDecimal = 50;//110010
            string numBinario = "110010";//50

            Console.WriteLine("Resultado de decimal a binario : {0}", Conversor.DecimalBinario(numDecimal));
            Console.WriteLine("Resultado de binario a decimal: {0}", Conversor.BinarioDecimal(numBinario));

            Console.ReadKey();
        }
    }
}
