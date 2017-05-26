using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_Atividade_02
{
    static class StringUtil
    {
        public static string Pluralize(this string texto)
        {
            if (texto.ToUpper().EndsWith("S"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }
    }
}
