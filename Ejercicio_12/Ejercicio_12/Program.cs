using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Libreria;

// Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)". En el método estático ValidaS_N(char c) de la clase ValidarRespuesta,se validará el ingreso de opciones. El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. (crtl e, ctrl w para hacer wrap)
namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            bool seguir = true;
            int acum = 0;

            do
            {
                //bool repregunta = false;
                char respuesta;

                Console.Write("Ingresar num: ");
                int.TryParse(Console.ReadLine(), out int num);
                acum += num;
                do {
                    Console.Write("Seguir? S/N: ");
                    char.TryParse(Console.ReadLine(), out respuesta);
                    //if (!ValidarRespuesta.ValidaS_N(respuesta))
                    //{
                    //    Console.WriteLine("Error en la respuesta.");
                    //    repregunta = true;
                    //}
                    if (char.ToLower(respuesta) == 'n')
                    {
                        seguir = false;
                    }
                } while (!ValidarRespuesta.ValidaS_N(respuesta));//sale en true
                
            } while (seguir);

            Console.WriteLine("La suma total es de: {0}", acum);

            Console.ReadKey();
        }
    }
}
