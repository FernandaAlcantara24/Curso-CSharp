using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()  // Método que retorna string.
        {
            return string.Format($"Olá! Mechamo {Nome} e tenho {Idade} anos.");

        }

        public void ApresentarNoConsole() // Método que não retorna nada.
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() // Não recebe parametro de entrada e nao retorna nada mas faz coisas úteis.
        {
            Nome = "";
            Idade = 0;

        }
    }
}
