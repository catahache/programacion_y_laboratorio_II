using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 29";

            Jugador j1 = new Jugador(38837743, "Cata", 3, 1);
            Jugador j2 = new Jugador(36837743, "Dilem", 2, 1);
            Jugador j3 = new Jugador(35837743, "Carlos", 3, 2);
            Jugador j4 = new Jugador(38837743, "Raul bb", 5, 7);
            Jugador j5 = new Jugador(30737743, "Andrea", 5, 2);

            Equipo equipito = new Equipo(4, "Almirante gg");

            bool agrego = equipito + j1;
            agrego = equipito + j2;
            agrego = equipito + j3;
            agrego = equipito + j4; // no debe agregar a j4 porque tiene el mismo dni que j1
            agrego = equipito + j5; 

            Console.WriteLine(equipito.MostrarJugadores(equipito));

            if(j1 == j4)
            {
                Console.WriteLine("j1 es igual a j4");
            }
            else
            {
                Console.WriteLine("j1 distinto a j4");
            }

            Console.ReadKey();

        }
    }
}
