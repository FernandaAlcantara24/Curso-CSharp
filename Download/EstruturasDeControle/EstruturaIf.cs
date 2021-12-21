using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota); // Vai converter esse número pra uma nota 

            Console.WriteLine("Possui bom comportamento? (S/N) ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s"; 

            bomComportamento = entrada.ToLower() == "s"; // O ToLower vai converter o S para letra minúscula.

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

            // Estrutura de controle NÃO tem --> ; <-- Exceto em um caso

        }
    }
}
