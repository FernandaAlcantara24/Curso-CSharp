using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 Arredondamento pq botou para ser só uma casa decimal.
            Console.WriteLine(valor.ToString("C")); // C = Current - Uma moeda. transformando em valor monetário. 
            Console.WriteLine(valor.ToString("P")); // P = Percentual, múltiplica o valor por 100 e add o %.
            Console.WriteLine(valor.ToString("#.##")); // Quer dizer que vc quer um número que tem 2 casa decimais, pode usar F2 tbm.

            CultureInfo cultura = new CultureInfo("pt-BR"); // transforma os valores para região escolhida tipo R$ por estar em português.
            Console.WriteLine(valor.ToString("C0", cultura)); // Dinheiro sem casa decimal.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Vai completar até o número ficar em 10 posições. Põem zeros a esquerda.
                                 


        }
    }
}
