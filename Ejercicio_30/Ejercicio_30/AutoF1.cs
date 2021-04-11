using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }


        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            string enCompetencia;
            if (this.enCompetencia)
            {
                enCompetencia = "Si";
            }
            else
            {
                enCompetencia = "No";
            }
            return ($"Numero: {this.numero}, Escuderia: {this.escuderia}, Cantidad de combustible: {this.cantidadCombustible}, En competencia: {enCompetencia}, Vueltas restantes: {this.vueltasRestantes}");
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
