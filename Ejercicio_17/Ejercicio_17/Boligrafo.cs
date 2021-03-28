using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Valida nivel de tinta y asigna el atributo
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                for (int i = 0; i < tinta; i++)
                {
                    if (this.tinta < cantidadTintaMaxima)
                    {
                        this.tinta++;
                    }
                }
            }
            else if (tinta < 0)
            {
                for (int i = 0; i > tinta; i--)
                {
                    if (this.tinta > 0)
                    {
                        this.tinta--;
                    }
                }
            }

        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            bool pudoPintar = false;
            for (int i = 0; i < gasto; i++)
            {
                if(this.tinta > 0)
                {
                    this.SetTinta(-1);
                    dibujo += "*";
                    pudoPintar = true;
                }
                else
                {
                    break;
                }
            }
            return pudoPintar;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

       
    }
}
