using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaValidacion
{
    public  class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool isValid = false;
            if(valor > min && valor < max)
            {
                isValid = true;
            }
            return isValid;
            
        }
    }
}
