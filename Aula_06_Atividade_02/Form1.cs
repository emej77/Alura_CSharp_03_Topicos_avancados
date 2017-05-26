using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Conta> contas = new List<Conta>();
            HashSet<Conta> contas = new HashSet<Conta>();
            for (int i = 0; i <= 9; i++)
            {
                contas.Add(new Conta() { Numero = i, Titular = "Titular " + i });
            }

            MessageBox.Show("Quantidade de contas no HashSet <contas>: " + contas.Count);

            foreach (Conta conta in contas)
            {
                MessageBox.Show("Numero: " + conta.Numero + " Titular: " + conta.Titular);
            }

            //Não pode remover por posição com um HashSet, somente com o: HashSet.remove(objeto);
            //contas.RemoveAt(0);

            //MessageBox.Show("Quantidade de contas na lista <contas> após remover uma conta: " + contas.Count);

            //O HashSet guarda a referência de um objeto criado na memória, e ele não permite incluir a mesma referencia no mesmo conjunto (HashSet).
            //Veja o exemplo abaixo.
            Conta c = new Conta() { Numero = 11, Titular = "Titular 11" };
            contas.Add(c);
            MessageBox.Show(c.GetHashCode().ToString());
            c.Numero = 45;
            c.Titular = "João";
            MessageBox.Show(c.GetHashCode().ToString());
            contas.Add(c);

            MessageBox.Show("Quantidade de contas no HashSet <contas> após adicionar a mesma conta duas vezes: " + contas.Count);

            foreach (Conta conta in contas)
            {
                MessageBox.Show("Numero: " + conta.Numero + " Titular: " + conta.Titular);
            }

            MessageBox.Show("Contas possui a conta c? " + contas.Contains(c));

            contas.Remove(c);

            MessageBox.Show("Quantidade de contas no HashSet <contas> após remover uma conta: " + contas.Count);

            MessageBox.Show("Contas possui a conta c? " + contas.Contains(c));
        }
    }
}
