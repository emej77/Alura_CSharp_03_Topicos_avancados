using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Aula_08_Atividade_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que le e escreve o que o usuário digitou.");

            TextReader leitor = Console.In;

            string linha = leitor.ReadLine();

            while (linha != null)
            {
                Console.WriteLine("O usuário escreveu-> " + linha);
                linha = leitor.ReadLine();
            }
        }
    }
}
