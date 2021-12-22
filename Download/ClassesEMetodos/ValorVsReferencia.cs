using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{ 
    //public struct Dependente
    public class Dependente
    {
        public string Nome; // A string é uma classe
        public int Idade; // O int é um Struct
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}"); // Atribuição feita por valor, ou seja, eles serão iguais.

            numero++; // Foi feita uma cópia, não irá influenciar no outro. Ele add mais 1.
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}"); // Cópia por referência. Faz com que os dois aponte para o msm local de memória
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato"; // Mudou o nome da cópia.
            dep.Idade = 21; //Mudou a idade do original.

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
