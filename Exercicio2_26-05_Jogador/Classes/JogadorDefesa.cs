namespace Exercicio2_26_05.Classes
{
    public class JogadorDefesa : Jogador
    {
         public string Aposentar()
        {
            if (CalcularIdade() < 40)
            {
                TempoRestante = 40 - CalcularIdade();
                return $"{NomeJogador} ainda jogará por {TempoRestante} Anos, até ter idade para aposentar";
            }else
            {
                return $"{NomeJogador} já tem idade para se aposentar";
            }
        }
    }
}