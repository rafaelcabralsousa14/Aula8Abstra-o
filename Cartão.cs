namespace Abstração
{
    public class Cartão : Pagamento
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
        private string token = "029382488391dj03isjahnjc";
        
        public bool validarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

    }
}