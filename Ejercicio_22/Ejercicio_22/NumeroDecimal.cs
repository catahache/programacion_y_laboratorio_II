using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static int operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return Conversor.BinarioDecimal(nb + nd);
        }
        public static int operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            return Conversor.BinarioDecimal(nb - nd);
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return (nb == nd);
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.numero;
        }
    }
}
