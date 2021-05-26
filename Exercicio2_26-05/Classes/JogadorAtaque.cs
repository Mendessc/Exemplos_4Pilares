
namespace Exercicio2_26_05.Classes
{
    public class JogadorAtaque : Jogador
    {
        public string Aposentar()
        {
            if (CalcularIdade() < 35)
            {
                TempoRestante = 35 - CalcularIdade();
                return $"{NomeJogador} ainda jogará por {TempoRestante} anos, até ter idade para se aposentar";
            } 
            else
            {
                return $"{NomeJogador} ja tem idade suficiente para se aposentar";
            }
        }
    }
}