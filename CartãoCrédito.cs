namespace Abstração
{
    public class CartãoCrédito : Cartão
    {
        public float limite { get; set; }
        
        public float AumentarLimite(float limiteAtual, float acréscimo){
            return limiteAtual + acréscimo;
        }
        public string BloquearCartaoDeCrédito(){
            return "Cartão foi bloqueado";
        }
    }
}