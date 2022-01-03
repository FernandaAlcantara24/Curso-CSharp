using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    // Classe abstrata pode ou n ter um método abstrato. É uma classe inacabada.
    public abstract class Celular // Só pode instânciar classes concretas.
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    class ClasseAbstrata
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
