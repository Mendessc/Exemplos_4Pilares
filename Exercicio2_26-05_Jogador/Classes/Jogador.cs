using System;
namespace Exercicio2_26_05.Classes
{
    public abstract class Jogador 
    {
        public string NomeJogador;
        public int AnoNascimento;
        public string Nacionalidade;
        public double Altura;
        public double Peso;
        public int IdadeJogador;
        public int TempoRestante;

        public string MostrarInfos()
        {
            return $@"
Informações do Jogador:
Nome: {NomeJogador}
Ano de Nascimento: {AnoNascimento}
Nacionalidade: {Nacionalidade}
Altura: {Altura}
Peso: {Peso}kg";
        }
        public int CalcularIdade()
        {
            return IdadeJogador = (DateTime.Now.Year - AnoNascimento);
        }
    }
}