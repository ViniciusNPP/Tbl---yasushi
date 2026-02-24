using Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Pagamento
    {
        public void EfetuarPagamento(Cliente cliente, List<Produto> produtos)
        {
            while (true)
            {
                float valor_total = 0;

                Console.WriteLine("Produtos a serem pagos:");
                produtos.ForEach(produto =>
                {
                    Console.WriteLine($"{produto.Nome} R${produto.Preco}");
                    valor_total += produto.Preco;
                });
                Console.WriteLine($"\nValor total: R${valor_total}");
                Console.WriteLine("Método de pagamento: [1]Débito  [2]Crédito");

                if (Console.ReadKey(true).KeyChar == '1')
                {
                    Console.Clear();
                    Debito(cliente, produtos, valor_total);
                    break;
                }
                else if (Console.ReadKey(true).KeyChar == '2')
                {
                    Console.Clear();
                    Credito(cliente, produtos, valor_total);
                    break;
                } 
                else
                {
                    Console.WriteLine("Método de pagamento inválido...");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        internal void Debito(Cliente cliente, List<Produto>produtos, float valor_total)
        {
            Console.WriteLine("Pagamento efetuado com sucesso!");
            Console.WriteLine($"Cliente: {cliente.Nome} - CPF: {cliente.Cpf}");
            Console.WriteLine("Método de pagamento: Débito");
            produtos.ForEach(produto =>
            {
                Console.WriteLine($"{produto.Nome} - R${produto.Preco}");
            });
            Console.WriteLine($"\nValor total: R${valor_total}");
        }

        internal void Credito(Cliente cliente, List<Produto> produtos, float valor_total)
        {
            Console.WriteLine("Pagamento efetuado com sucesso!");
            Console.WriteLine($"Cliente: {cliente.Nome} - CPF: {cliente.Cpf}");
            Console.WriteLine("Método de pagamento: Crédito");
            produtos.ForEach(produto =>
            {
                Console.WriteLine($"{produto.Nome} - R${produto.Preco}");
            });
            Console.WriteLine($"\nValor total: R${valor_total}");
        }
    }
}
