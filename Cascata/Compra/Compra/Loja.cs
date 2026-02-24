using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    internal class Loja
    {
        public static void Main()
        {
            Cliente cliente = new();
            Pedido pedido = new();

            Produto produto1 = new("Teclado", 89.99f);
            Produto produto2 = new("Geladeira", 899.99f);
            Produto produto3 = new("Tapete", 199.99f);
            Produto produto4 = new("AirFryer", 239.99f);
            
            List<Produto> lista_produtos = [produto1, produto2, produto3, produto4];

            List<Produto> sacola = cliente.ComnprarProduto(lista_produtos);
            if (sacola.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Pagamento");
                pedido.EfetuarPagamento(cliente, sacola);
            }
        }
    }
}
