using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Diagnosticca
{
    class Produto
    {
        public string nome;
        public double preco;
        public string disponibilidade;

        public Produto(string nome, double preco, bool disponibilidade)
        {
            this.nome = nome;
            this.preco = preco;
            if (disponibilidade)
            {
                this.disponibilidade = "Disponível";
            }
            else
            {
                this.disponibilidade = "Indisponível";
            }
        }

        public override string ToString()
        {
            return "Nome: " + nome + "\nPreço: " + preco + "\nDisponibilidade: " + disponibilidade;
        }
    }
}
