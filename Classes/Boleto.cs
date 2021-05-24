using System;

namespace POO1Exemplo.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;

        Random r = new Random();

        public void Registrar(){
            CodigoDeBarras = r.Next(300000000).ToString();

            Console.WriteLine($"Boleto gerado com o código de barrar: {CodigoDeBarras}");
            Console.WriteLine($"Boleto gerado com desconto, o valor atual é de {this.Valor * 0.88:C2}");
        }
    }
}