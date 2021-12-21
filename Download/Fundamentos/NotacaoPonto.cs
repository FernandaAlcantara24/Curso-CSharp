using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); // Quantidade de caractéries 

            string valorImportante = null; // Variável vazia/Nula 
            Console.WriteLine(valorImportante?.Length); // Não da para usar notação ponto em variável vazia

        }
    }
}
