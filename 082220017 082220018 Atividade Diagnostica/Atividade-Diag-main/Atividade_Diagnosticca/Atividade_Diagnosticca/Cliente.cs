using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Diagnosticca
{
    class Cliente
    {
        public string nome;
        public CarrinhoDeCompras carrinho;
        public Cliente(string nome, CarrinhoDeCompras carrinho)
        {
            this.nome = nome;
            this.carrinho = carrinho;
        }
        public override string ToString()
        {
            return $"Nome: {nome}";
        }
    }
}
