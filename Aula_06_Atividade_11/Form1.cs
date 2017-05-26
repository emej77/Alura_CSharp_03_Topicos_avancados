using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_Atividade_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> NomeSexo = new Dictionary<string, string>();
            NomeSexo.Add("Elias", "masculino");
            NomeSexo.Add("Luciana", "feminino");

            foreach (KeyValuePair<string, string> i in NomeSexo)
            {
                MessageBox.Show("Nome: " + i.Key + ", sexo: " + i.Value);
            }
        }
    }
}
