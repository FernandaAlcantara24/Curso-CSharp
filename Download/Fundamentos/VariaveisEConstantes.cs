using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Àrea da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //  PI = 3.15484; não da para mudar pois está como uma constante.

            double area = PI * raio * raio; // Números reais
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true; // True or False
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // Números inteiros. Vai de 0 a 256. Só aceita valores positivos.
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // Vai de -127 a +128. MinValue = Menor valor do byte. Byte com sinal.
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros.
            Console.WriteLine("Menor Valor Inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // Inteiro sem sinal.
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // Long sem sinal.
            Console.WriteLine("Populaçã Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // Número real.
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoDaAplle = 1000000000000.00; // Mais usado dos reais.
            Console.WriteLine("Valor De Mercado Da Aplle " + valorDeMercadoDaAplle);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Carrega valores enormes.
            Console.WriteLine("Distância Entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b'; // UMA UNICA LETRA é delimitada por ' simples.
            Console.WriteLine("Letra " + letra);

            string texto = "Seja Bem-Vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
