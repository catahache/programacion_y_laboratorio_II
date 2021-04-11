using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            AutoF1 a1 = new AutoF1(1, "Mercedes");
            AutoF1 a2 = new AutoF1(2, "McLaren");
            AutoF1 a3 = new AutoF1(1, "Mercedes");
            AutoF1 a4 = new AutoF1(3, "Alpine");
            AutoF1 a5 = new AutoF1(4, "Ferrari");
            AutoF1 a6 = new AutoF1(5, "AlphaTauri");
            AutoF1 a7 = new AutoF1(6, "Alfa Romeo");

            Competencia competencia = new Competencia(5, 6);

            bool agrego = competencia + a1;
            agrego = competencia + a2;
            agrego = competencia + a3;
            agrego = competencia + a4;
            agrego = competencia + a5;
            agrego = competencia + a6;
            agrego = competencia + a7;

            Console.WriteLine(competencia.MostrarDatos());

            a1.VueltasRestantes = 2;
            a6.EnCompetencia = false;

            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}
