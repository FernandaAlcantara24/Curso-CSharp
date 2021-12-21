using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // STATIC = não pertence mais ao objeto e sim a classe.
        // Método de Classe ou Método estático!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Quando NÃO é STATIC ele é acessivél a partir da instância
        // Método de instância!
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }


    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }

}
