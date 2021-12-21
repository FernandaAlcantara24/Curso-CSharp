using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        // Única estrutura que termina com ---> ;
        // é a primeira estrutura que a expressão está depois do bloco
        public static void Executar()
        {
            string entrada;

            // O DO WHILE SEMPRE pelo menos uma vez o bloco será executado
            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo! {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");

            Console.WriteLine("Foi um prazer te conhecer! até a próxima :)");
        }
    }
}
