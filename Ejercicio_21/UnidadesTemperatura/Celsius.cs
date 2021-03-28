using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesTemperatura
{
    public class Celsius
    {
        private double grados;
        private static double tempRespectoFahrenheit;

        static Celsius()
        {
            tempRespectoFahrenheit = 33.8;
        }

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public Celsius(double grados, double temperatura)
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
        public static implicit operator Celsius(double c)
        {
            return new Celsius(c);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.grados * 9/5 + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetGrados() + 459.67) * 5/9);
        }

        //Operaciones
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.grados - ((Celsius)f).grados);
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.grados - ((Celsius)k).grados);
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.grados + ((Celsius)f).grados);
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.grados + ((Celsius)k).grados);
        }


        //Comparaciones
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.grados == ((Celsius)f).grados;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.grados == ((Celsius)k).grados;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.grados == c2.grados;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
    }
}
