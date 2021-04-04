using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasNumeracion
{
    public class Conversor
    {
        static public string DecimalBinario(int numDecimal)
        {
            int resto = 0;
            string numBinario = "";
            for (; numDecimal > 1;)
            {
                resto = numDecimal % 2;//0 o 1
                numDecimal /= 2;
                numBinario += resto;
            }
            if (numDecimal == 1 || numDecimal == 0)
            {
                numBinario += numDecimal;//numDecimal va a quedar cargado con 1 o 0
            }

            char[] charNumBinario = numBinario.ToCharArray();//convierto en array de chars
            Array.Reverse(charNumBinario);//lo invierto
            return new string(charNumBinario);//lo convierto en string de nuevo
        }

        static public int BinarioDecimal(string numBinario)
        {
            int numDecimal = 0;
            for (int i = 0; i < numBinario.Length; i++)
            {
                char posicion = numBinario[numBinario.Length - (i + 1)];//+1 porque el ultimo char es \0
                if (posicion.Equals('1'))//de atras hacia adelante
                {
                    numDecimal += (int)Math.Pow(2, i);
                }

            }
            return numDecimal;
        }
    }
}
