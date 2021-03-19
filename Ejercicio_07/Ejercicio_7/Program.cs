using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now). Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. 
namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            Console.Write("Ingrese dia de nacimiento: ");
            int.TryParse(Console.ReadLine(), out int dia);
            Console.Write("Ingrese mes de nacimiento: ");
            int.TryParse(Console.ReadLine(), out int mes);
            Console.Write("Ingrese anio de nacimiento: ");
            int.TryParse(Console.ReadLine(), out int anio);
            DateTime nacimiento = new DateTime(anio, mes, dia);
            DateTime now = DateTime.Now;
            Console.WriteLine("Tu nacimiento es el dia {0}",nacimiento);
            Console.WriteLine("La fecha de hoy es {0}",now);
            int diasVividos = 0;

            for (; nacimiento < now; nacimiento = nacimiento.AddDays(1.0))//adddays agrega de a un dia
            {
                diasVividos++;
            }

            Console.WriteLine("Viviste: {0} dias", diasVividos);

            Console.ReadKey();
        }
    }
}
