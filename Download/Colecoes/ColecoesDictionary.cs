using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // A chave não aceita repetição e o valor aceita repetição.

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) // Vai pegar o valor que foi passado e verificar se está na coluna das chaves.
            {
                Console.WriteLine("2004: " + filmes[2004]); // [] <--- Serve para pegar um valor de um dicionário.
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); // O DEFAULT deixa pegar uma string vazia.
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); // Verifica se um determinado valor está contido.
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // Vai remover e dizer se foi ou n removido.

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

           foreach (var chave in filmes.Keys) // Percorrendo a chave.
            {
                Console.WriteLine(chave);
            }

           foreach (var valor in filmes.Values) // Percorrendo valores.
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) // Percorrendo chave e valor ao mesmo tempo.
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

           foreach (var filme in filmes) // Deixando o próprio compilador inferir essa variável.
           {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
           }
        }
    }
}
