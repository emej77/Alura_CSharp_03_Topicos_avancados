using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta() { Numero = 1, Titular = "Titular 1" };
            //Quando modificamos a classe Conta e sobrescrevemos o método Equals retornado sempre false, enganamos o HashSet.
            HashSet<Conta> contas = new HashSet<Conta>();
            contas.Add(c);
            contas.Add(c);
            MessageBox.Show(Convert.ToString(contas.Count));
            contas.Clear();
            MessageBox.Show(Convert.ToString(contas.Count));
        }
    }
}
