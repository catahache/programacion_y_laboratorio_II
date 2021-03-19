using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
//Se debe validar que el número sea mayor que cero, caso contrario, 
//mostrar el mensaje: "ERROR. ¡Reingresar número!". 
//Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            bool isValidNum;
            int num;

            do
            {
                isValidNum = true;
                Console.Write("Ingresar numero: ");
                num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    isValidNum = false;
                }
            } while (isValidNum == false);

            Console.WriteLine("Cuadrado: "+ Math.Pow(num, 2));
            Console.WriteLine("Cubo: " + Math.Pow(num, 3));

            Console.ReadKey();
        }
    }
}
