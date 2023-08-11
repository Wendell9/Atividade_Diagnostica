using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Diagnosticca
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            Produto produtos = new Produto("leite", 10.00, true);
            Produto produtos2 = new Produto("café", 5.00, true);
            Produto produtos3 = new Produto("chocolate", 10.00, true);
            int op;

            CarrinhoDeCompras carInho = new CarrinhoDeCompras();
            do
            {
                Console.WriteLine("Escolha um produto:");
                Console.WriteLine("1-Leite");
                Console.WriteLine("2-Café");
                Console.WriteLine("3-Chocolate");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    
                    case 1:
                        carInho.AddProdutos(produtos);
                        break;
                    case 2:
                        carInho.AddProdutos(produtos2);
                        break;
                    case 3:
                        carInho.AddProdutos(produtos3);
                        break;
                }
                
                do
                {
                    Console.WriteLine("Deseja escolher mais algum item?");
                    Console.WriteLine("1-Sim\n2-Não");
                    resposta = Console.ReadLine();
                    if (resposta != "1" && resposta != "2")
                    {
                        Console.WriteLine("A resposta deve ser 1 ou 2");
                    }
                } while (resposta != "1" && resposta != "2");
            } while (resposta == "1");
            Console.Clear();
            Cliente cliente = new Cliente(nome,carInho);
            Console.WriteLine(cliente.nome);
            cliente.carrinho.listaProdutos();
        }
    }
}
