using System;

namespace Abstração
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string codDeBarras { get; set; }
        public string bancoEmissor { get; set; }

        public string RegistrarBoleto(){
            return "Boleto registrado no sistema";
        }
    }
}