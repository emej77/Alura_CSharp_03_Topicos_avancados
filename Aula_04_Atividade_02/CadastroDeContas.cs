using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_Atividade_02
{
    public partial class CadastroDeContas : Form
    {
        private Principal principal;

        public CadastroDeContas(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta()
            {
                Numero = Convert.ToInt32(textoNumero.Text),
                Titular = textoTitular.Text
            };

            principal.AdiconaConta(c);

            this.Close();
        }
    }
}
