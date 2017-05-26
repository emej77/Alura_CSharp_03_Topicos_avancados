using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_07
{
    public partial class Principal : Form
    {
        //private Conta[] contas;
        List<Conta> contas = new List<Conta>();
        private int quantidadeDeConta = 0;

        public Principal()
        {
            //this.contas = new Conta[20];
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastroDeContas = new CadastroDeContas(this);
            cadastroDeContas.ShowDialog();
        }

        public void AdiconaConta(Conta conta)
        {
            this.contas.Add(conta);
            this.quantidadeDeConta++;

            comboBox1.Items.Add(conta);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object ContaSelecionada = comboBox1.SelectedItem;
            Conta c = (Conta)ContaSelecionada;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoTitular.Text = c.Titular;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Object ContaSelecionada = comboBox1.SelectedItem;
            Conta c = (Conta)ContaSelecionada;
            contas.Remove(c);
            comboBox1.Items.Remove(c);
        }
    }
}
