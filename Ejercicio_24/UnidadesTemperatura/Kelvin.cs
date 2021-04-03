using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesTemperatura
{
    public class Kelvin
    {
        private double grados;
        private static double tempRespectoFahrenheit;

        static Kelvin()
        {
            tempRespectoFahrenheit = -457.87;
        }

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public Kelvin(double grados, double temperatura)
            : this(grados)
        {
            tempRespectoFahrenheit = temperatura;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static double GetTemperatura()
        {
            return tempRespectoFahrenheit;
        }

        //Conversiones:
        public static implicit operator Kelvin(double k)
        {
            return new Kelvin(k);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.grados * 9/5 - 459,67);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius( ( ((Fahrenheit)k).GetGrados() - 32) * 5/9);
        }


        //Operaciones
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.grados - ((Kelvin)f).grados);
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.grados - ((Kelvin)c).grados);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.grados + ((Kelvin)f).grados);
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.grados + ((Kelvin)c).grados);
        }


        //Comparaciones
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.grados == ((Kelvin)f).grados;
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.grados == ((Kelvin)c).grados;
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.grados == k2.grados;
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
    }
}
