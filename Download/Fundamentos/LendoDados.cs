using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // O PARSE está transformando uma string em número

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); // Vai usar o ponto como separador decimal, se n por esse código Culture ele irá usar a vírgula.


            Console.WriteLine("Seu nome: {0} sua idade: {1} seu salário: R${2}", nome, idade, salario);
        }
    }
}
