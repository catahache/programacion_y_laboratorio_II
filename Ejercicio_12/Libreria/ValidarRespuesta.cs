using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool isValid = true;
            if (char.ToLower(c) != 's' && char.ToLower(c) != 'n')
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
