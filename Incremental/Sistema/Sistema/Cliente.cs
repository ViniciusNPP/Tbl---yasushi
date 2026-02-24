using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    internal class Cliente
    {
        private string nome = "";
        private string cpf = "";

        public Cliente()
        {
            Console.Write("Seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Seu CPF: ");
            string cpf = Console.ReadLine();

            this.nome = nome;
            this.cpf = cpf;
        }

        public string Nome { get => nome; }
        public string Cpf { get => cpf; }
    }
}
