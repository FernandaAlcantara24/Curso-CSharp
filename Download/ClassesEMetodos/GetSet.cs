using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    // Public fica visivel pra quem for usar determinada classe...
    public class Moto
    {
        // O private vai encapsular = tornar escondido. Visivel apenas internamente
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //uint = inteiro sem sinal, vai ser obrigado a passar o valor +

        public Moto(string marca, string modelo, uint cilindrada)
        {
            //Marca = marca; 
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca) // string marca --> parâmetro
        {
            Marca = marca; // marca =  parâmetro da função, vai setar Marca = atributo da classe
        }

        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada)
        {
            // 1 Opção
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}

            // 2 Opção
            /*Cilindrada = Math.Abs(cilindrada);*/ // pega o valor e transforma em + ou -. No caso em +


            Cilindrada = cilindrada;
        }
    }

    class GetSet //Get = lÊ O VALOR DO ATRIBUTO. set = ALTERA O VALOR DO ATRIBUTO.
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
