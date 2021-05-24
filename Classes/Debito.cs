using System;

namespace POO1Exemplo.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar(){
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para pagar este valor!");
            }else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}