using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesTemperatura
{
    public class Fahrenheit
    {
        private double grados;
        private static double tempRespectoFahrenheit;

        static Fahrenheit()
        {
            tempRespectoFahrenheit = 1;
        }

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public Fahrenheit(double grados, double temperatura)
            :this(grados)
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
        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.grados - 32)*5/9);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.grados + 459.67)*5/9);
        }

        //Operaciones
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.grados - ((Fahrenheit)c).grados);
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.grados - ((Fahrenheit)k).grados);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.grados + ((Fahrenheit)c).grados);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.grados + ((Fahrenheit)k).grados);
        }

        //Comparaciones
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.grados == ((Fahrenheit) c).grados;
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.grados == ((Fahrenheit)k).grados;
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.grados == f2.grados;
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

    }
}
