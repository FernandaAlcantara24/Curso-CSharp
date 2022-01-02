using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }

    class ColecoesList
    {
        // A lista tbm é indexada.
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> //Lista já pondo os produtos
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada de Game Of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); //ADD tudo no carrinho.
            Console.WriteLine(carrinho.Count); //Vai dizer quantos itens tem no carrinho.
            carrinho.RemoveAt(3); //Remover o elemento de indice 3.

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}  {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro)); // Qual é o último item desse elemento
        }
    }
}
