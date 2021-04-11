using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            :this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            return ($"Dni: {this.dni}, Nombre: {this.nombre}, Partidos Jugados: {this.partidosJugados}, Promedio de Goles: {GetPromedioGoles()}, Total goles: {this.totalGoles}");
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
