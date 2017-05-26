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
    public partial class CadastroDeContas : Form
    {
        private Principal principal;
        private Conta c;

        public CadastroDeContas(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboTipoConta.SelectedIndex)
            {
                case 0:
                    c = new ContaCorrente();
                    break;
                case 1:
                    c = new ContaPoupanca();
                    break;
            }
            c.Numero = Convert.ToInt32(textoNumero.Text);
            c.Titular = textoTitular.Text;

            principal.AdiconaConta(c);

            this.Close();
        }
    }
}
