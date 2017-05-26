using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HSP.Aula_02_Atividade_02.Contas;

namespace HSP.Aula_02_Atividade_02
{
    public partial class Form1 : Form
    {
        Conta c;
        public Form1()
        {
            c = new Conta();
            c.Numero = 123;
            c.Titular = "José Alberto";
            c.Deposita(100.0);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MontarTela();
        }

        private void MontarTela()
        {
            textoNumero.Text = Convert.ToString(c.Numero);
            textoTitular.Text = c.Titular;
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exception ees = new Exception();
            try
            {
                c.Saca(Convert.ToDouble(textoValor.Text));
            }
            catch (Exception EErro)
            {
                MessageBox.Show(EErro.Message);
            }
            finally
            {
                this.MontarTela();
            }
        }
    }
}
