using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_Atividade_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = "Arquitetura de Software";
            MessageBox.Show(titulo);

            titulo = "Arquitetura " + "de" + " Software";
            MessageBox.Show(titulo);

            int numero = 10;
            titulo = "Arquitetura " + "de" + " Software " + numero;
            MessageBox.Show(titulo);

            string metodoFormat;
            string nome = "Elias";
            string sobrenome = "Mansur";

            metodoFormat = string.Format("Olá, meu nome é {0} e o meu sobrenome é {1}.",nome,sobrenome);
            MessageBox.Show(metodoFormat);

            string texto = "Elias Mansur Espindola Junior; 38, Lins; São Paulo; Brasil";
            string[] textoPartes = texto.Split(';');
            foreach (string partes in textoPartes)
            {
                MessageBox.Show(partes);
            }

            texto.ToUpper();
            MessageBox.Show(texto);

            texto = texto.ToUpper();
            MessageBox.Show(texto);

            string replace = " 1; 2; 3; 4; 5; 6; 7; 8; 9.";
            MessageBox.Show(replace);
            replace = replace.Replace(';', ',');
            MessageBox.Show(replace);

            string nomeCompleto = "guilherme silveira";
            string primeiroNome = nomeCompleto.Substring(0, 9);
            MessageBox.Show(primeiroNome); // imprime guilherme;

            int posicaoDoEspaco = nomeCompleto.IndexOf(" ");
            MessageBox.Show(Convert.ToString(posicaoDoEspaco)); // imprime 9

            int inicioDoSegundoNome = nomeCompleto.IndexOf("s");
            MessageBox.Show(nomeCompleto.Substring(inicioDoSegundoNome)); // imprime silveira


        }
    }
}
