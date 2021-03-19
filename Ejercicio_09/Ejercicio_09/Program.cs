using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa que imprima por pantalla una pirámide como la siguiente: 
//* 
//*** 
//***** 
//******* 
//********* 

//El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el ejemplo anterior la altura ingresada fue de 5. Nota: Utilizar estructuras repetitivas y selectivas. 
namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            bool flag = true;
            string stars = "*";//en la 1ra vuelta hay 1 sola estrella

            Console.Write("Ingresar altura piramide a dibujar: ");
            int.TryParse(Console.ReadLine(), out int alto);

            for(int i = 0; i < alto ; i++)
            {
                if (flag)
                {
                    Console.WriteLine(stars);//1ra vuelta
                    flag = false;
                }
                else
                {
                   stars += "**";//sumo 2 mas por vuelta
                   Console.WriteLine(stars);
                }
            }

           
            Console.ReadKey();
        }
    }
}
