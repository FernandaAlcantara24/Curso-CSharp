using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    //Estrutura que agrupa vários valores dentro dela
    class Params
    {
        //Recebendo um conjunto de Parâmetros variáveis, ou seja, pode passar quantos parâmetros quiser
        public static void Recepcionar(params string [] pessoas) // [] pessoas ---> representa o conjunto de parâmetros. Em um único parâmetro tem acesso a todos.
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia"); // Pode passar quantos parâmetros quiser

        }
    }
}
