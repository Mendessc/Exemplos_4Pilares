using System;
namespace Exercicio1_26_05.Classes
{
    public class ElevadorServico : Elevador
    {
        public int Caixas;

        public int AlterarCaixas()
        {
         Console.WriteLine("Quantas caixas deseja colocar no elevador?");
         Caixas = int.Parse(Console.ReadLine());
         return Caixas;   
        }

    }
}