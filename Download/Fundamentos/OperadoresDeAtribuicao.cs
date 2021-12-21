using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; // trocando o valor do 3 por 7.

            num1 += 10; // num1 = (recebe) num1 + 10;. Esta acrescentando a variável o valor 10.

            num1 -= 3; // num1 = num1 - 3;. Atribuição subtrativa.

            num1 *= 5; // num1 = num1 * 5;. Atribuição multiplicativa.

            num1 /= 2; // num1 = num1 / 2;. Atribuição divisiva.
            Console.WriteLine(num1);


            // Forma de Atribuição mais Implicita

            int a = 1; // Atribuição de um valor literal.
            int b = a; // Atribuição de outra variável apontando para outra variável que no caso é b.

            a++; // Acrescentando uma unidade a variável a. É o msm que a = a + 1; Valor unário de incremento.
            b--; // b = b - 1; Valor unário de decremento.

            Console.WriteLine($"{a} {b}");
        }
    }
}
