using System;
using Exercicio2_26_05.Classes;

namespace Exercicio2_26_05
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque Ja = new JogadorAtaque();
            JogadorDefesa Jd = new JogadorDefesa();
            JogadorMeioCampo Jm = new JogadorMeioCampo();
            bool check = false;

            do
            {
                Console.WriteLine($@"
Qual a posição do jogador?
1- Joga no Ataque
2- Joga na Defesa
3- Joga no Meio de Campo");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    Console.WriteLine("Qual o nome do Jogador?");
                    Ja.NomeJogador = Console.ReadLine();

                    Console.WriteLine("Qual seu ano de nascimento?");
                    Ja.AnoNascimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a nacionalidade do Jogador?");
                    Ja.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a altura do Jogador?");
                    Ja.Altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o peso do Jogador?");
                    Ja.Peso = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{Ja.MostrarInfos()}");
                    Console.WriteLine($"{Ja.NomeJogador} tem {Ja.CalcularIdade()} anos");
                    Console.WriteLine(Ja.Aposentar());
                        break;

                    case "2":
                     Console.WriteLine("Qual o nome do Jogador?");
                    Jd.NomeJogador = Console.ReadLine();

                    Console.WriteLine("Qual seu ano de nascimento?");
                    Jd.AnoNascimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a nacionalidade do Jogador?");
                    Jd.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a altura do Jogador?");
                    Jd.Altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o peso do Jogador?");
                    Jd.Peso = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{Jd.MostrarInfos()}");
                    Console.WriteLine($"{Jd.NomeJogador} tem {Jd.CalcularIdade()} anos");
                    Console.WriteLine(Jd.Aposentar());
                        break;

                    case "3":
                    Console.WriteLine("Qual o nome do Jogador?");
                    Jm.NomeJogador = Console.ReadLine();

                    Console.WriteLine("Qual seu ano de nascimento?");
                    Jm.AnoNascimento = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Qual a nacionalidade do Jogador?");
                    Jm.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a altura do Jogador?");
                    Jm.Altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o peso do Jogador?");
                    Jm.Peso = double.Parse(Console.ReadLine());

                    Console.WriteLine($"{Jm.MostrarInfos()}");
                    Console.WriteLine($"{Jm.NomeJogador} tem {Jm.CalcularIdade()} anos");
                    Console.WriteLine(Jm.Aposentar());
                        break;
                    default:
                    Console.WriteLine("A opção selecionada é inválida! Digite uma opção válida");
                    check = true;
                        break;
                }
            } while (check);
        }
    }
}
