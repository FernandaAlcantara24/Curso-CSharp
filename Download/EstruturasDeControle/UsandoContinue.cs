using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        // O CONTINUE interrompe aquela REPETIÇÃO e vai para próxima REPETIÇÃO
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue; // Ele volta para o for para continuar, ele não para a execução do for que nem o break.
                }

                Console.Write(i + " ");
            }
        }
    }
}
