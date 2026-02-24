using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compra
{
    internal class Pedido
    {

        public List<Produto> ComnprarProduto(List<Produto> lista_produtos)
        {
            List<Produto> lista = [];

            while (true)
            {
                if (lista_produtos.Count <= 0)
                {
                    Console.WriteLine("A loja está sem produtos...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }

                Console.WriteLine("Produtos");
                int cont = 1;
                lista_produtos.ForEach(produto =>
                {
                    Console.WriteLine($"{cont}- {produto.Nome} R${produto.Preco}");
                    cont++;
                });
                Console.WriteLine($"{cont}- Sair");

                int key = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                if (key == cont) break;
                else if (key <= 0 || key > cont) break;

                lista.Add(lista_produtos[key - 1]);

                Console.WriteLine($"\n{lista_produtos[key - 1].Nome} adicionado à sacola!");
                Thread.Sleep(1000);
                Console.Clear();
            }
            return lista;
        }
    }
}
