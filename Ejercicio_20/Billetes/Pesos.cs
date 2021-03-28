using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //Conversiones:
        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / cotizRespectoDolar);
        }


        //Operaciones
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).cantidad);
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).cantidad);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).cantidad);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).cantidad);
        }

        //Comparaciones
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.cantidad == ((Pesos)d).cantidad;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p.cantidad == ((Pesos)e).cantidad;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
    }
}
