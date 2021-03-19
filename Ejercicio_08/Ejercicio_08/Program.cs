using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N empleados de una fábrica. 
//Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas.
namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";
            float importeBruto;
            float importeNeto;
           // float total;
            float porcentajeDescuento;
            char respuesta = 's';
            bool seguir = true;
            bool respuestaIncorrecta = false;

            do {

                Console.Write("Ingresar valor hora: ");
                float.TryParse(Console.ReadLine(), out float valorHora);
                Console.Write("Ingresar nombre: ");
                int.TryParse(Console.ReadLine(), out int nombre);
                Console.Write("Ingresar antiguedad: ");
                int.TryParse(Console.ReadLine(), out int antigüedad);
                Console.Write("Ingresar cantidad de  horas trabajadas: ");
                int.TryParse(Console.ReadLine(), out int horasTrabajadas);

                importeBruto = (valorHora * horasTrabajadas) + (antigüedad * 150);
                porcentajeDescuento = importeBruto * (float)0.13;
                importeNeto = importeBruto - porcentajeDescuento;

                Console.WriteLine("Nombre: {0} \nAntiguedad: {1} \nValor hora: {2} \nTotal bruto: {3} \nDescuentos: {4} \nValor neto: {5}\n\n", nombre, antigüedad, valorHora, importeBruto, porcentajeDescuento, importeNeto);  ;

                do {
                    Console.Write("Continuar? s/n: ");
                    char.TryParse(Console.ReadLine(), out respuesta);
                    respuesta = char.ToLower(respuesta);
                    if (respuesta == 'n')
                    {
                        seguir = false;
                        //respuestaIncorrecta = false;
                    }
                    else if (respuesta != 's')
                    {
                        Console.WriteLine("Respuesta invalida.");
                        respuestaIncorrecta = true;
                    }
                } while (respuestaIncorrecta);
            } while (seguir);

            

            Console.ReadKey();
        }
    }
}
