using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;


// Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * ó /). El usuario decidirá cuándo finalizar el programa. Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase): 
//a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación. 
//b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá TRUE si el número es distinto de CERO. 
namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            bool respuesta = true;
            do
            {
                bool incorrecto = true;

                Console.Write("Numero 1: ");
                float.TryParse(Console.ReadLine(), out float num1);
                Console.Write("Numero 2: ");
                float.TryParse(Console.ReadLine(), out float num2);
                Console.Write("Operacion: ");
                char.TryParse(Console.ReadLine(), out char operacion);

                Console.WriteLine("Resultado: {0}", Biblioteca.Calculadora.Calcular(num1, num2, operacion));
                
                do
                {
                    Console.WriteLine("Continuar? S/N:");
                    char.TryParse(Console.ReadLine(), out char letra);
                    if (char.ToLower(letra) == 'n')
                    {
                        respuesta = false;
                        incorrecto = false;
                    }
                    else if (char.ToLower(letra) == 's')
                    {
                        incorrecto = false;
                    }
                    else
                    {
                        Console.WriteLine("Caracter incorrecto.");
                    }
                } while (incorrecto);

            } while (respuesta);


            Console.ReadKey();
        }
    }
}
