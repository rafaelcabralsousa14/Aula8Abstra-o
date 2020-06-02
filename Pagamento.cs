using System;

namespace Abstração
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        /// Get é para leitura, set é para escrita e reescrita

        public string Pagar(){
            return "Pagamento efetuado";
        }
        
        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }
    }
}
