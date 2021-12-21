using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar ()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //Posso usar o var ou o bool.   
            bool comprouTV50 = executouTrabalho1 && executouTrabalho2; // && <--- E. Operador binário
            Console.WriteLine("Compro a TV 50? {0}", comprouTV50); // No caso dos 2 trabalhos serem verdadeiros é que o resultado
                                                                  // comprouTV50 será verdadeiro.

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // || <--- OU. Operador binário
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete); // A compra do sorvete basta um dos dois darem certo OU os
                                                                       // dois que será executado.

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2; // ^ <--- OU EXCLUSIVO. Operador binário
            Console.WriteLine("Comprou a TV 32? {0}", comprouTV32); // Somente um deve ser verdadeiro.

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // ! <--- NEGAÇÃO LÓGICA. Operador unário
                                                                     // Inverte o valor de um determinado operando
                                                                    
        }
    }
}
