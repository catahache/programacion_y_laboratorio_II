using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {
        //a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación. 
        public static float Calcular(float num1, float num2, char operacion)
        {
            float resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir por 0");
                    }
                   
                    break;
            }
            return resultado;
        }

        //b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá TRUE si el número es distinto de CERO. 
        private static bool Validar(float num)
        {
            bool valido = false;
            if (num != 0)
            {
                valido = true;
            }
            return valido;
        }
    }
}
