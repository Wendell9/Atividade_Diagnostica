using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Diagnosticca
{
    class CarrinhoDeCompras
    {
        List<Produto> produtos = new List<Produto>();
        public static int Quantidade;
        public void AddProdutos(Produto produto)
        {
            produtos.Add(produto);
        }

        public void listaProdutos()
        {
            foreach(Produto produto in produtos) {
                Console.WriteLine($"{produto.ToString()}");
            }
        }
    }  
}
