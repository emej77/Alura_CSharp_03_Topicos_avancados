using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Aula_08_Atividade_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                textoEditor.Clear();

                using (Stream arquivo = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    textoEditor.Text = leitor.ReadToEnd();
                }
                //Não precisa mais, estamos utilizando o <using>
                /*
                leitor.Close();
                arquivo.Close();
                */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream arquivo = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter gravador = new StreamWriter(arquivo))
            {
                gravador.WriteLine(textoEditor.Text);
            }
            //Não precisa mais, estamos utilizando o <using>
            /*
            gravador.Close();
            arquivo.Close();
            */
        }
    }
}
