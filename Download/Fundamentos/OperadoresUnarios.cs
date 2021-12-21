using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            //Funciona em um UNICO operando, por isso UNÁRIO.
            var valorNegativo =  -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Quando coloca - em um operando, ele transforma em um valor negativo ou inverte o sinal.
                                               // Nesse caso como o nº já é negativo e pois o - na frente, ele vai inverte para +.

            Console.WriteLine(!booleano); // Negação lógica,
                                          // Se é V ele vira F, se é F vira V.

            numero1++; // Incremento. Pode por o símbolo ++ antes ou depois.
            Console.WriteLine(numero1); // O nº 1 é = 2 mas INCREMENTANDO ele vai para 3.

            --numero1; // Decremento. Pode por o símbolo -- antes ou depois.
            Console.WriteLine(numero1); //  o nº 1 é = 2 mas DECREMENTANDO ele vai para 2 pq eu tinha INCREMENTADO antes.
            

            Console.WriteLine(numero1++ == --numero2); /* Quando vc coloca o ++ depois da variável significa que "vc n está com presa".
                                                       * Quando vc coloca o símbolo antes, ela tem uma precedência maior, ou seja, "está mais apresada".
                                                       * Entao, neste caso... O nº 2 será decrementado antes de comparar e o nº 1 só será incrementado depois da comparação.
                                                      * E a resposta será true pq os dois valerão 2.
                                                      */

            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
