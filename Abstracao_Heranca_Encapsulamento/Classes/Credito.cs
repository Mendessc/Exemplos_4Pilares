using System;

namespace Abstracao_Heranca_Encapsulamento.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("O seu limite não é suficiente para pagar esse valor");
            }
            else
            {

                do
                {
                    Console.WriteLine($"Quantas vezes deseja parcelar o {valor:C2}? (de 1 a 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma os juros serão de 5% do valor total!");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");

                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma os juros serão de 8% do valor total!");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Impossivel parcelar nessa quantidade, escolha um número de vezes entre 1 e 12!!");
                    }

                } while (vezes < 1 || vezes > 12);
            }
        }
    }
}