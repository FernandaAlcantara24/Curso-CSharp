using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10; // Método de instância

        public static void Executar()
        {
            // Acessar variável 'a' dentro do método executar!

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
