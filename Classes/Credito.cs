using System;

namespace POO1Exemplo.Classes
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;

        public void Pagar(){
            float valor = this.Valor;
            int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("O seu limite é insuficiente para pagar este valor!");
            }else
            {
                do
                {
                    Console.WriteLine($"Em quantas vezes você deseja parcelar o valor {valor:C2}? (De 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} vezes de {(valor * 1.05) / vezes:C2}");
                    }else if (vezes >= 7 && vezes <=12)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 8% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} vezes de {(valor * 1.08) / vezes:C2}");
                    }
                } while (vezes < 1 || vezes > 12);
            }
        }
    }
}