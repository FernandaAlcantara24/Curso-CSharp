using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // Preço com Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura); // Math.Pow(altura, 2);  <--- Outra forma de fazer a potência.
            Console.WriteLine("IMC é: {0}", imc);

            // Númer Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2); // par % 2 <--- é um módulo pq é o resto da divisão.
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2); // se o resto for 1 é impar, se o resto for 0 é par.
        }
    }
}
