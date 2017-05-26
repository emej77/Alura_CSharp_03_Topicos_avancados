using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_05
{
    public partial class Principal : Form
    {
        private Conta[] contas;
        private int quantidadeDeConta = 0;

        public Principal()
        {
            this.contas = new Conta[20];
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastroDeContas = new CadastroDeContas(this);
            cadastroDeContas.ShowDialog();
        }

        public void AdiconaConta(Conta conta)
        {
            this.contas[this.quantidadeDeConta] = conta;
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
    }
}
