using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = (float) 1 / 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
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
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.cantidad / cotizRespectoDolar);//constructor con cantidad
            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            //Dolar d = (Dolar)e;
            //Pesos p = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());//cant dolares * 66
            //return p;
            return (Pesos)((Dolar)e);
        }


        //Operaciones
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        //Comparaciones
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == ((Euro)d).cantidad;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
    }
}
