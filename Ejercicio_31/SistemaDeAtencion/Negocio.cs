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
            :this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region "Propiedades"
        public Cliente Client
        {
            get
            {
                return clientes.Dequeue(); //retornará el próximo cliente en la cola de atención (lo saca de la cola?)
            }
            set
            {
                //deberá controla que el Cliente no figure ya en la cola de atención, caso contrario lo agregará
                if (this != value)
                {
                    this.clientes.Enqueue(value);
                }  
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count(); // cant de clientes a atender
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

        //El operador + será el único capaz de agregar un Cliente a la cola de atención. Sólo se agregará un Cliente si este no forma ya parte de la lista.Rehutilizar el == de Cliente
        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        //generará una atención del próximo cliente en la cola, utilizando la propiedad Client y el método Atender de PuestoAtencion. Retornará True si pudo realizar la operación completa.
        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Client); // Atender + Dequeue (get)
        }
    }
}
