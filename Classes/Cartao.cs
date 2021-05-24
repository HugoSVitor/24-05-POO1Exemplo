using System;

namespace POO1Exemplo.Classes
{
    public class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o cvv do cartão");
            Cvv = Console.ReadLine();

            return $"Cartão de número {Numero} salvo com sucesso!";
        }
    }
}