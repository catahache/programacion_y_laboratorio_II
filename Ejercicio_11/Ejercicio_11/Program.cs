using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaValidacion;

// Realizar una clase llamada Validacion que posea un método estático llamado Validar, 
//que posea la siguiente firma: bool Validar(int valor, int min, int max): 
    //a. valor: dato a validar 
    //b. min y max: rango en el cual deberá estar la variable valor. 
//Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente 
//que esten dentro del rango -100 y 100. Terminado el ingreso mostrar el valor mínimo, 
//el valor máximo y el promedio. 
//Nota: Utilizar variables escalares, NO utilizar vectores. 
namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int minimo=0;
            int maximo=0;
            //sin flag:
            //int minimo = int.MaxValue; maximo int posible
            //int maximo = int.MinValue; minimo int posible
            bool flag = true;//1ra iteracion
            int acum = 0;
            float promedio = 0;
            bool isValid;

            for(int i=1; i < 11; i++)
            {
                do
                {
                    Console.Write("Ingrese numero de -100 a 100 (" + i + " de 10): ");
                    int.TryParse(Console.ReadLine(), out int num);//out se pasa por referencia y no por valor
                    //isValid = Validacion.Validacion.Validar(num, -100, 100);
                    isValid = Validacion.Validar(num, -100, 100);
                    if (isValid)
                    {
                    
                        if (num < minimo || flag)
                        {
                            minimo = num;
                        }
                        if(num > maximo || flag)
                        {
                            maximo = num;
                            flag = false;
                        }
                        acum += num;
                    }
                    else
                    {
                        isValid = false;
                        Console.WriteLine("Error, ingrese num valido");
                    }
                } while (isValid==false);
                
            }

            promedio = (float)acum / 10;

            Console.WriteLine("Minimo: " + minimo);
            Console.WriteLine("Maximo: " + maximo);
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadKey();
        }
    }
}
