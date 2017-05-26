using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_09_Atividade_04
{
    public partial class Form1 : Form
    {
        List<Conta> contas = new List<Conta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CriarConta(int numero, string titular, double valor)
        {
            Conta c = new Conta() { Numero = numero, Titular = titular };
            c.Depositar(valor);
            contas.Add(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarConta(1, "Elias", 1000);
            CriarConta(2, "Luciana", 2000);
            CriarConta(3, "Adelina", 3000);
            CriarConta(4, "Arthur", 4000);
            CriarConta(4, "Pedro", 5000);

            //Utilizando o LINQ

            IEnumerable<Conta> filtrados = contas.Where(result => result.Saldo >= 2500 && result.Titular.StartsWith("A"));

            foreach (Conta c in filtrados)
            {
                MessageBox.Show("Número: " + c.Numero + "\nTitular: " + c.Titular + "\nSaldo: " + c.Saldo);
            }
        }
    }
}
