using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_09_Atividade_07
{
    public partial class Form1 : Form
    {
        List<Conta> contas = new List<Conta>();

        public Form1()
        {
            CriarConta(1, "Elias", 1000);
            CriarConta(2, "Luciana", 2000);
            CriarConta(3, "Adelina", 3000);
            CriarConta(4, "Arthur", 4000);
            CriarConta(4, "Pedro", 5000);

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
            //Utilizando o LINQ
            var filtrados = from result in contas
                            select new { Titular = result.Titular, Saldo = result.Saldo } ;
            
            foreach (var c in filtrados)
            {
                MessageBox.Show("Titular: " + c.Titular + "\nSaldo: " + c.Saldo);
            }
        }
    }
}
