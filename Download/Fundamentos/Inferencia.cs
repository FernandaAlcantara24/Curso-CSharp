using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            // var = variavél implicita 
            var nome = "Fernanda";
            Console.WriteLine(nome);

            // nome = 123; Porque é do tipo inteiro e o outro como estava em " ele viu que era string

            // var idade; Tem que atribuir um valor a variável
            // idade = 32;

            var idade = 32;
            Console.WriteLine(idade);

            int a; // Declaração de uma variável
            a = 3; // Atribui o valor para a

            int b = 2; // Declara a variavél b e inicializa ela com um valor inicial

            Console.WriteLine(a + b);
        }
    }
}
