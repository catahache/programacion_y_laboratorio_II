using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente: 

//    * //4
//   *** //3
//  ***** //2
// ******* //1
//*********

//Nota: Utilizar estructuras repetitivas y selectivas. 


namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            //tantos espacios como altura - 1
            Console.Title = "Ejercicio 10";
            bool flag = true;
            string stars = "*";//en la 1ra vuelta hay 1 sola estrella
            char espacio = ' ';
            string espacios ="";
            int espaciosAlto;

            Console.Write("Ingresar altura piramide a dibujar: ");
            int.TryParse(Console.ReadLine(), out int alto);
            espaciosAlto = alto-1;

            for (int i = 0; i < alto; i++)
            {
                for(int j = 0; j < espaciosAlto; j++ )
                {
                    espacios += espacio;
                }
                espaciosAlto--;//resto una altura para la prox linea iterada
                
                if (flag)
                {
                    Console.WriteLine(espacios+stars);//1ra vuelta
                    flag = false;
                }
                else
                {
                    stars += "**";//sumo 2 mas por vuelta
                    Console.WriteLine(espacios+stars);
                }
                espacios = "";
            }

            Console.ReadKey();
        }
    }
}
