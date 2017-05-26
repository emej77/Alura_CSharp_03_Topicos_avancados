using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_Atividade_06
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Valor para saque inválido. Valor informado é menor ou igual a 0(zero).");
            }

            if (valor > this.Saldo)
            {
                throw new Exception("Valor de saque superior ao saldo atual da conta.");
            }

            this.Saldo -= valor;
        }
    }
}
