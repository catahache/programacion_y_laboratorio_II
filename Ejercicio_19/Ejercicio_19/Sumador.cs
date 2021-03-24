using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) //reutiliza el anterior
        {
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;//suma una suma
            return a+b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;//suma una suma
            return $"{a}{b}";
            //return a+b; tambien esta bien
        }

        /// <summary>
        /// Retorna cantidad de sumas de un sumador
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            //recibe un sumador, devuelve un int
            return s.cantidadSumas;
        }

        /// <summary>
        /// Suma dos cantidades de sumas
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        /// <summary>
        /// Compara cantidad de sumas de dos sumadores
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (int)s1 == (int)s2;//utilizo el casteo que declare arriba
        }

    }
}
