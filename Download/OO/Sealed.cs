using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    // Classe celada. Só faz sentido usar o Sealed quando o método está marcado como virtual.
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }
    // Não é possível herdar de uma classe celada

    //class SouFilho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    // Um método celado n pode ser sobrescrito.
    class FilhoRebelde : Pai
    {
        //public new bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
