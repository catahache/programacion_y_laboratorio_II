using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    public class NumeroBinario
    {
        public string numero;
        
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(nb.numero) + (int) nd.numero);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(nb.numero) - (int)nd.numero);
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return (Conversor.BinarioDecimal(nb.numero) == (int)nd.numero);
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb != nd);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numero)
        {
            return numero.numero;
        }

    }
}
