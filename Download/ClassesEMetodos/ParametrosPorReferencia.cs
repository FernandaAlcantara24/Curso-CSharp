using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) // Com o REF vc passa uma referência.
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        // OUT é uma forma de vc receber algo que não é diretamente por parâmetro. Ele é de uma única direção. 
        // Não se passa um dado para um parâmetro de tipo out ele simplesmente gera uma saída.
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
