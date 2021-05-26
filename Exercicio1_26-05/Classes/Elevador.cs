using System;

namespace Exercicio1_26_05.Classes
{
    public abstract class Elevador
    {
        public int AndarAtual = 0;
        public int AndarTotal;
        public int Capacidade;
        public int TotalPessoas;

        public void Inicializar()
        {
            AndarAtual = 0;
            AndarTotal = 10;
            Capacidade = 9;
        }
        public int AlterarPessoas()
        {
            Console.WriteLine("Quantas pessoas desejam entrar no elevador?");
            TotalPessoas = int.Parse(Console.ReadLine());
            return TotalPessoas;
        }
        public int AlterarAndar()
        {
            Console.WriteLine("Pra qual andar você deseja ir?");
            AndarAtual = int.Parse(Console.ReadLine());
            return AndarAtual;
        }


    }
}