using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            this.notaFinal = -1;

            int seed = Environment.TickCount;//num en milisegs desde que arranca la computadora
            Random random = new Random(seed);
            
            if (this.nota1 >=4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(4, 11);
                Console.WriteLine(this.notaFinal);
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string finalAprobado = "Alumno desaprobado";
            if(this.notaFinal != -1)
            {
                finalAprobado = this.notaFinal.ToString();
            }
            return $"Nombre: {this.nombre}\nApellido: {this.apellido}\nLegajo: {this.legajo}\nNota 1:{this.nota1}\nNota 2: {this.nota2}\nNota final: {finalAprobado}";
        }
    }
}
