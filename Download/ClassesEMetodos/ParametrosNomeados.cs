using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia , mes, ano); // {0:D2} ---> Vai por zeros a direita para completar o tamanho, no caso por 1 zero antes.
        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}
