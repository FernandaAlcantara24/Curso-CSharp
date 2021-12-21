using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        //Estrutura de repetição.
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); // Random = Valor aleatório

            int numeroSecreto = random.Next(1, 16); // O valor 16 não vai entrar, só vai do 1 até o 15 
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            //while (true) ---> Laço infiito
            //{
            //}

            // Enquanto houver tentativas e o número não tiver sido encontrado
            while (tentativasRestantes > 0 && !numeroEncontrado) // Só vai parar de repitir se o número for encontrado ou a qtd de tentativas tenha acabado
            {
                Console.WriteLine("Insira o seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
