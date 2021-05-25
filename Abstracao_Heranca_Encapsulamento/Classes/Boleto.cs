using System;

namespace Abstracao_Heranca_Encapsulamento.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigodeBarras;

        Random r = new Random();

        public void Registrar(){
            CodigodeBarras = r.Next(3000000).ToString();

            Console.WriteLine($"Boleto Gerado com o código {CodigodeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de {this.Valor * 0.88:C2}");
        }
    }
}