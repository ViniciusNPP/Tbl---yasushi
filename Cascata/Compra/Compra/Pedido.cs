using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compra
{
    internal class Pedido
    {

        public void EfetuarPagamento(Cliente cliente, List<Produto> produtos)
        {
            float valor_total = 0;

            Console.WriteLine("Produtos a serem pagos:");
            produtos.ForEach(produto =>
            {
                Console.WriteLine($"{produto.Nome} R${produto.Preco}");
                valor_total += produto.Preco;
            });
            Console.WriteLine($"\nValor total a ser pago por {cliente.Nome}: R${valor_total}");
        }
    }
}
