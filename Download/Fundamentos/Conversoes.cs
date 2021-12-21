using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //Conversão implicita quando não perigo de ter perda de informação.
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Ou faria
            // int inteiro = 10;
            // double quebrado = inteiro;

            //Conversão numérica explicita, quando a possibilidade de perder informação.

            double nota = 9.7;
            int notatruncada = (int) nota; // Esse (int) é onde vc explicita o que quer converter.
            Console.WriteLine("Nota Truncada: {0}", notatruncada);

            //Conversões entre strings e inteiros.

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);  // O valor int tem 4baites, ou seja, 32bits por isso põem o 32 ali.
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Mesmo que não digite um valor que não seja inteiro ele vai ignorar isso.

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out  numero1); // Converta PALAVRA e jogue dentro do NUMERO que eu criei na linha 36.
            Console.WriteLine("Resultado 1: {0}", numero1);

            // Outra forma de ser feito:

            Console.Write("Digite o segundo número:");
            int.TryParse(Console.ReadLine(), out int numero2); 
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
    
}
