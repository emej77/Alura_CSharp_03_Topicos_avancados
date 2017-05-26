using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03_Atividade_07
{
    public partial class Form1 : Form
    {
        Conta c1, c2;

        public Form1()
        {
            c1 = new Conta() { Numero = 1, Titular = "André" };
            c1.Deposita(100.0);

            c2 = new Conta() { Numero = 2, Titular = "Bruno" };
            c2.Deposita(200.0);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object ContaSelecionada = comboBox1.SelectedItem;
            Conta c = (Conta)ContaSelecionada;
            MessageBox.Show(Convert.ToString(c.Numero));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(c1);
            comboBox1.Items.Add(c2);

            comboBox1.DisplayMember = "TiTuLaR"; // Não é case-sensitive
        }
    }
}
