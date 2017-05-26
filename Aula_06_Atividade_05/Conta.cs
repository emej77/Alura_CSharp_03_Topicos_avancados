using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Atividade_05
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }

        public override bool Equals(object obj)
        {
            return false;
        }
    }
}
