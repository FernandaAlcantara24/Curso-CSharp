using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); // QUEUE com generics

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Vai pegar o 1º elemento da fila e mostrar e não foi excluido da lista.
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // Tira a 1ª pessoa da fila.
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // QUEUE sem generics
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
