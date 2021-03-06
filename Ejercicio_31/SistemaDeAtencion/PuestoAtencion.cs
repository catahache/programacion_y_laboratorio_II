﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaDeAtencion
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
            :this()
        {
            this.puesto = puesto;
        }
        /// <summary>
        /// Incrementa en 1 al atributo numeroActual y luego lo retorna
        /// </summary>
        public static int NumeroActual
        {
            get 
            {
                //PuestoAtencion.numeroActual += 1;
                //return PuestoAtencion.numeroActual; 
                return ++numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(800);//milisegs
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

    }
}
