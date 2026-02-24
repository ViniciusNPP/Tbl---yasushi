using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    internal class Produto
    {
        private string nome;
        private float preco;
        
        public Produto(string nome, float preco) { 
            this.nome = nome;
            this.preco = preco;
        }

        public string Nome { get { return nome; } }
        public float Preco { get { return preco; } }
    }
}
