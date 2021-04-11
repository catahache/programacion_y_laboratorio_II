using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }


        public string this[int i]//indexador
        {
            get 
            { 
                if(i < this.paginas.Count() && i >= 0)
                {
                    return this.paginas[i];
                }
                else
                {
                    return string.Empty; // ""
                }
                
            }
            set 
            { 
                if(i >= 0)
                {
                    if (i < this.paginas.Count())
                    {
                        //si ya existe, asigno value
                        this.paginas[i] = value;
                    }
                    else if(i >= paginas.Count())
                    {
                        //si no existe, crear pag
                        this.paginas.Add(value);
                    }
                }
            }
        }

        public List<string> Paginas
        {
            get
            {
                return this.paginas;
            }
        }
    }
}
