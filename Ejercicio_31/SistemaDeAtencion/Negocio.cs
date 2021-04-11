using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAtencion
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;//cola de clientes
        private string nombre;

        #region "Constructores"
        private Negocio()
        {
            //inicializará la colección y el puesto de atención como Caja1.
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region "Propiedades"
        public Cliente Client
        {
            get
            {
                return clientes.Peek(); //retornará el próximo cliente en la cola de atención
            }
            set
            {
                //deberá controla que el Cliente no figure ya en la cola de atención, caso contrario lo agregará
                //TODO ver como reutilizar la sobrecarga ==
                bool isInQueue = false;
                foreach (Cliente cli in clientes)
                {
                    if (cli == value)//si ya figura en la cola
                    {
                        isInQueue = true;
                        break;
                    }
                }

                if (!isInQueue)//si no esta en la cola, lo agrego
                {
                    clientes.Enqueue(value);
                }
            }
        }
        #endregion

        /// <summary>
        /// Retornará true si el cliente se encuentra en la colección
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)//si ya figura en la cola
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
    }
}
