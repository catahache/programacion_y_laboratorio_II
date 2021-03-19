using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    /// <summary>
    /// 
    /// </summary>
    public class AnioBisiesto
    {
        public static bool EsBisiesto(int anio)
        {
            bool isBiciesto = false;

            for (int i = 1; i < anio; i++)
            {
                if ((100 * i != anio) && (4 * i == anio))
                {
                    //Console.WriteLine("Anio es multiplo de 4: " + i);
                    isBiciesto = true;
                }
                if ((100 * i == anio))
                {
                    //Console.WriteLine("Anio es multiplo de 100");
                    for (int j = 1; j < anio; j++)
                    {
                        if (400 * j == anio)
                        {
                            //Console.WriteLine("Anio es multiplo de 400");
                            isBiciesto = true;
                            break;
                        }
                    }
                    break;//ya si es multiplo de 100, pero no de 400, corta el bucle porque puede ser que haya otro num superior multiplo de 4 que vuelva a entrar y poner true
                }
            }
            //if (isBiciesto)
            //{
            //    Console.WriteLine(anio + " es biciesto.");
            //}
            //else
            //{
            //    Console.WriteLine(anio + " no es biciesto.");
            //}


            return isBiciesto;
        }
    }
}
