using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        #region Metodos
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine($"{auto.MostrarDatos()}");
            }
            sb.ToString();

            return ($"Cantidad de competidores: {this.cantidadCompetidores}\n Cantidad de vueltas: {this.cantidadVueltas}\n Competidores:\n{sb}");
        }
        #endregion

        #region Sobrecargas
        //La sobrecarga + agregará un competidor si es que aún hay espacio (validar con cantidadCompetidores) y el competidor no forma parte de la lista(== entre Competencia y AutoF1).
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c != a) // si hay espacio y no esta en la lista de competidores
            {
                Random r = new Random();
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                short.TryParse(r.Next(15, 101).ToString(), out short cantComb);
                a.CantidadCombustible = cantComb;

                c.competidores.Add(a);
                
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
           return c.competidores.Remove(a); // true si elimino, false si no
        }

        //Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un número random entre 15 y 100 a cantidadCombustible
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        #endregion

    }
}
