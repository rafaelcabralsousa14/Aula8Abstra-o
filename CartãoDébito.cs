namespace Abstração
{
    public class CartãoDébito : Cartão
    {
        public float saldo { get; set; }
        
        public string Transferir(float valor){
            return $"R$ {valor} transferido";
        }
        public string PagarTítulo(){
            return "Título pago com o cartão de débito";
        }        
    }
}