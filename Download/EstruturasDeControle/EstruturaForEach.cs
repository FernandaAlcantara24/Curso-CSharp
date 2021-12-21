using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "opa!";

            foreach (var letra in palavra) // Percorrendo da prmeira letra até a última
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
