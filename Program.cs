using System;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartãoCrédito visa = new CartãoCrédito();
            visa.limite = 1200;
            visa.Pagar();
            System.Console.WriteLine("Seu limite atual é: "+visa.limite);
            System.Console.WriteLine("Limite aumentado para: "+ visa.AumentarLimite(visa.limite, 300));
            System.Console.WriteLine(visa.Pagar());
        }
    }
}
