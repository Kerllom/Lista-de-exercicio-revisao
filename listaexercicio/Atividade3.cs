using System;

namespace ListaExercicios
{
    public class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 03: TABUADA ===");
            Console.Write("Digite um número para calcular a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            // Chamamos o procedimento passando o número digitado
            ExibirTabuada(numero);
        }

        // Este é o nosso "Procedimento" (método void). Ele apenas formata e imprime a tela.
        private void ExibirTabuada(int num)
        {
            Console.WriteLine($"\n===== TABUADA DO {num} =====");

            // O laço: começa no 1; roda enquanto for menor ou igual a 10; aumenta 1 por vez
            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                // Exibindo a formatação exata pedida na lista
                Console.WriteLine($"{num} x {i} = {resultado}");
            }

            Console.WriteLine("========================");
        }
    }
}