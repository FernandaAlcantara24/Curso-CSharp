using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        // Estrutura usada quando tem uma quantidade determinada de repetições.
        public static void Executar()
        {
            //int i = 1; <--- Declaração da variável. i<= 10; <--- Expressão que vai dizer se é V ou F. i++ <--- Incremento.

            //for(int i = 1; i <= 10; i++)
            //{
            //  Console.WriteLine("O valor de i é {0}.", i);

            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Média da turma: {0}", media);
        }
    }
}
