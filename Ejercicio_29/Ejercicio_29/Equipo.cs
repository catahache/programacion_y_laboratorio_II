using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public StringBuilder MostrarJugadores(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Los jugadores de {e.nombre} son:\n");
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine($"{jugador.MostrarDatos()}\n");
            }
            return sb;
        }

        //La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores
        public static bool operator +(Equipo e, Jugador j)
        {
            bool existe = false;

            foreach (Jugador jug in e.jugadores)
            {
                if(jug == j)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe && (e.jugadores.Count < e.cantidadDeJugadores || e.jugadores == null)) // si no lo contiene y si la lista tiene menos jugadores de lo establecido
            {
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
