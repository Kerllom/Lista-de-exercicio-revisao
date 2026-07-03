using System;

namespace ListaExercicios
{
    public class Exercicio06
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 06: SEQUÊNCIA DE FIBONACCI ===");
            Console.Write("Quantos termos da sequência você quer ver? ");
            int n = int.Parse(Console.ReadLine());

            // 1. Validação: n precisa ser maior que zero
            if (n <= 0)
            {
                Console.WriteLine("Erro: Por favor, digite um número maior que zero.");
                return; // Encerra a execução caso a entrada seja inválida
            }

            Console.WriteLine($"\nSequência de Fibonacci ({n} termos):");

            // 2. Inicializamos as variáveis base
            int anterior = 0;
            int atual = 1;
            int proximo; // Apenas declaramos, o valor será calculado no laço

            // 3. O laço roda 'n' vezes
            for (int i = 1; i <= n; i++)
            {
                // Exibe o termo atual (usamos Write para ficar na mesma linha com um espaço)
                Console.Write($"{anterior} ");

                // 4. A "Dança das Variáveis"
                proximo = anterior + atual; // Calcula o próximo da sequência
                anterior = atual;           // O anterior anda uma casa para frente
                atual = proximo;            // O atual anda uma casa para frente, assumindo o valor do próximo
            }

            Console.WriteLine(); // Quebra de linha final para organizar o terminal
        }
    }
}