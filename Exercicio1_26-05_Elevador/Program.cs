using System;
using Exercicio1_26_05.Classes;

namespace Exercicio1_26_05
{
    class Program
    {
        static bool Repeticao = true;


        static void Main(string[] args)
        {
            ElevadorSocial so = new ElevadorSocial();
            ElevadorServico se = new ElevadorServico();

            Console.WriteLine("Qual elevador você deseja entrar? 1- Social / 2- Serviço");
            string resposta = Console.ReadLine().ToUpper();

            switch (resposta)
            {
                case "1":
                    so.Inicializar();
                    do
                    {
                        Console.WriteLine($@"
Você esta no {so.AndarAtual}º andar, há {so.TotalPessoas} pessoas no elevador. O que você deseja fazer?
                    
2-Alterar Andar
4-Alterar Quantidade de Pessoas
5-Finalizar");
                        string opcao = Console.ReadLine();
                        switch (opcao)
                        {

                            case "2":
                                do
                                {
                                    so.AlterarAndar();
                                    if (so.AndarAtual > 10)
                                    {
                                        Console.WriteLine($"O prédio não possui mais de {so.AndarTotal} andares, digite um andar disponivel!");
                                    }
                                } while (so.AndarAtual > 10);
                                break;

                            case "4":
                                do
                                {
                                    so.AlterarPessoas();
                                    if (so.TotalPessoas > 9)
                                    {
                                        Console.WriteLine($"A capacidade máxima desse elevador é de {so.Capacidade} pessoas, digite outro valor!");
                                    }
                                } while (so.TotalPessoas > 9);
                                break;

                            case "5":
                                Console.WriteLine("Tenha um bom dia!");
                                Repeticao = false;
                                break;

                            default:
                                Console.WriteLine("Houve um erro digite uma opçâo válida: ");
                                break;
                        }
                    } while (Repeticao);
                    break;

                case "2":
                    se.Inicializar();
                    do
                    {
                        Console.WriteLine($@"
Você esta no {se.AndarAtual}º andar, há {se.TotalPessoas} pessoas no elevador e {se.Caixas} caixas. O que você deseja fazer?
                    
2-Alterar Andar
3-Alterar Quantidade de Caixas
4-Alterar Quantidade de Pessoas
5-Finalizar");
                        string opcao = Console.ReadLine();
                        switch (opcao)
                        {
                            case "2":
                                do
                                {
                                    se.AlterarAndar();
                                    if (se.AndarAtual > 10)
                                    {
                                        Console.WriteLine($"O prédio não possui mais de {se.AndarTotal} andares, digite um andar disponivel!");
                                    }
                                } while (se.AndarAtual > 10);
                                break;

                            case "3":
                                se.AlterarCaixas();
                                Console.WriteLine($"A quantidade de caixas é de {se.Caixas}");
                                break;

                            case "4":
                                do
                                {
                                    se.AlterarPessoas();
                                    if (se.TotalPessoas > 9)
                                    {
                                        Console.WriteLine($"A capacidade máxima desse elevador é de {se.Capacidade} pessoas, digite outro valor!");
                                    }
                                } while (se.TotalPessoas > 9);
                                break;

                            case "5":
                                Console.WriteLine("Tenha um bom dia!");
                                Repeticao = false;
                                break;
                        }
                    } while (Repeticao);
                    break;
                default:
                    break;
            }
        }
    }
}
