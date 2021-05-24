using System;
using POO1Exemplo.Classes;

namespace POO1Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;
            do
            {
                Console.WriteLine(@"
                
                |------------------------------------------|
                |     Selecione uma das opções abaixo:     |
                |------------------------------------------|
                |                                          |
                |           B - Boleto                     |
                |           C - Crédito                    |
                |           D - Débito                     | 
                |           H - Cancelar pagamento         |
                |                                          |
                |------------------------------------------|
                                    ");
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registrar();
                        opcaoValida = true;
                        break;

                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoValida = true;
                        break;

                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoValida = true;
                        break;

                    case "h":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        opcaoValida = true;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        opcaoValida = false;
                        break;
                }
            } while (!opcaoValida);


        }
    }
}
