using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado*lado;
        }

        public static double CalcularTriangulo(double b, double h)
        {
            return (b*h)/2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
