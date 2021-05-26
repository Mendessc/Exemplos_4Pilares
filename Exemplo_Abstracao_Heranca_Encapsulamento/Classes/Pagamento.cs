using System;

namespace Abstracao_Heranca_Encapsulamento.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;

        protected float Valor = 2599f;

        public string Cancelar()
        {
            return "Pagamento Cancelado";
        }
    }
}