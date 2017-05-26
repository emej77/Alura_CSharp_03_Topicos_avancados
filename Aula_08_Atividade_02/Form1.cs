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

namespace Aula_08_Atividade_02
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

                Stream arquivo = File.Open("texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(arquivo);

                while (!leitor.EndOfStream)
                {
                    textoEditor.Text = leitor.ReadToEnd();
                }
                
                //Pode ser da forma acima ou da forma abaixo.
                //A forma abaixo não quebrou a linha e a de cima sim.
                /*
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    textoEditor.Text += linha;
                    linha = leitor.ReadLine();
                }
                */
                leitor.Close();
                arquivo.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream arquivo = File.Open("texto.txt", FileMode.Create);
            StreamWriter gravador = new StreamWriter(arquivo);
            gravador.WriteLine(textoEditor.Text);
            gravador.Close();
            arquivo.Close();
        }
    }
}
