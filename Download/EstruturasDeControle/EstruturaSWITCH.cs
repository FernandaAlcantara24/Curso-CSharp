using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSWITCH
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            // SWITCH devolve um valor NUMÉRICO, já o o IF devolve TRUE ou FALSE.
            switch(nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break; // O Break faz com que ele saía e vá para linha posterior.
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;

                default: //Caso o Usuário n tenha posto nenhuma das notas, ou seja, uma nota inválida...
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
