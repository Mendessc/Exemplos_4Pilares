using System;
using Exercicio3_26_05_Cafe.Classes;

namespace Exercicio3_26_05_Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();

            do
            {
                Console.WriteLine($@"
|----------------------------------------------------------|
|             Maquina de Café TabajarasPlus++              | 
|                                                          | 
|                Digite o que você deseja:                 |
|                  1- Café com Açúcar                      | 
|                  2- Café sem Açúcar                      |
|----------------------------------------------------------|
O armazenamento de açúcar esta em : {m.AcucarDisponivel}g");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        do
                        {
                            m.FazerCafe();

                            if (m.Acucar > m.AcucarDisponivel)
                            {
                                Console.WriteLine("O armazenamento de açúcar não tem essa quantidade disponivel, o cafézinho não foi feito");
                            }
                        } while (m.Acucar > m.AcucarDisponivel);

                        Console.WriteLine($"O seu cafézinho foi feito com {m.Acucar}g de açúcar, Volte Sempre!");
                        m.AcucarDisponivel = m.AcucarDisponivel - m.Acucar;
                        break;

                    case "2":
                        m.FazerCafe("Sem Açúcar");
                        break;

                    default:
                        Console.WriteLine("Opção digitada inválida!! Tente Novamente");
                        break;
                }
                if (m.AcucarDisponivel <= 0)
                {
                    Console.WriteLine("O açúcar disponivel no armazenamneto infelizmente acabou.");
                }
            } while (m.AcucarDisponivel > 0);
        }
    }
}
