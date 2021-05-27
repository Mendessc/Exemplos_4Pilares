namespace Exercicio2_26_05.Classes
{
    public class JogadorMeioCampo : Jogador
    {
         public string Aposentar()
        {
            if (CalcularIdade() < 38)
            {
                TempoRestante = 38 - CalcularIdade();
                return $"{NomeJogador} ainda jogará por {TempoRestante} Anos, até ter idade para aposentar";
            }else
            {
                return $"{NomeJogador} já tem idade para se aposentar";
            }
        }
    }
}