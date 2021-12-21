using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            // 3 partes do OPERADOR TERNÁRIO: uma expressão(True ou False), um operando que vai ser atribuida
            // caso seja TRUE e outro operando caso seja False. ATRIBUIÇÃO CONDICIONAL.

            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "APROVADO" : "REPROVADO";
            // Para retornar V ou F se usa o símbolo ternário --> ? <--
            // temos o --> : <-- também que serve para separar um operando do outro.
            // Se o resultado for MAIOR OU IGUAL a 7 aparecerá Aprovado! SE NÃO Reprovado.
            Console.WriteLine(resultado);

        }
    }
}
