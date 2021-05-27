using System;
namespace Exercicio3_26_05_Cafe.Classes
{
    public class MaquinaCafe
    {
        public int Acucar;
        public int AcucarDisponivel = 100;

        public void FazerCafe(string SemAcucar)
        {
            Console.WriteLine("O cafézinho foi feito, sem açúcar, Volte Sempre!");
        }

        public int FazerCafe()
        {
            Console.WriteLine("Quantas gramas de açúcar você deseja colocar no seu cafézinho? Para usar a medida padrão digite 0");
            Acucar = int.Parse(Console.ReadLine());

            if (Acucar == 0)
            {
                Acucar = 10;
            }
            return Acucar;
        }
    }
}