using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            // O BREAK ou está associado ao SWITCH ou a uma estrutura de REPETIÇÃO. NÃO a um bloco IF.

            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // Quando ele achar, ele encerra e vai para linha posterir ao laço for
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim");

        }
    }
}
