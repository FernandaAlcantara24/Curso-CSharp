using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro //construtor padrão.
    {
        //Classe com 3 atributos
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //Construtores
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        //Construtores
        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine("{0} {1} {2}", carro1.Fabricante, carro1.Modelo, carro1.Ano);

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine("{0} {1} {2}", carro3.Fabricante, carro3.Modelo, carro3.Ano);
        }
    }
}
