using System;

namespace ListaExercicios
{
    public class Exercicio04
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 04: CONTADOR DE PARES E ÍMPARES ===");

            // 1. Inicializamos os contadores com zero
            int pares = 0;
            int impares = 0;

            // 2. O laço roda 10 vezes (de 1 a 10)
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());

                // 3. Chamamos a nossa função booleana para testar o número
                if (EhPar(numero))
                {
                    pares++; // Incrementa o contador de pares em 1
                }
                else
                {
                    impares++; // Incrementa o contador de ímpares em 1
                }
            }

            // 4. Exibimos o resultado fora do laço
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Números pares : {pares}");
            Console.WriteLine($"Números ímpares: {impares}");
        }

        // Função que retorna verdadeiro (true) ou falso (false)
        private bool EhPar(int numero)
        {
            // O operador % pega o resto da divisão por 2. 
            // Se for igual a 0, a expressão inteira vira 'true' e é devolvida.
            return (numero % 2 == 0);
        }
    }
}