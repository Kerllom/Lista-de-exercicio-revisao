using System;

namespace ListaExercicios
{
    public class Exercicio05
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 05: CALCULADORA DE FATORIAL ===");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            // 1. Validação da Entrada
            if (numero < 0)
            {
                Console.WriteLine("Erro: fatorial não definido para negativos");
            }
            else
            {
                // 2. Chamada da função e exibição (se for válido)
                long resultado = CalcularFatorial(numero);
                Console.WriteLine($"{numero}! = {resultado}");
            }
        }

        // Função que recebe um 'int', mas devolve um 'long'
        private long CalcularFatorial(int n)
        {
            // O acumulador DEVE iniciar em 1 na multiplicação
            long acumulador = 1;

            // Se n for 0, o laço não vai rodar (pois i <= 0 é falso)
            // e a função devolve o acumulador valendo 1, o que está correto!
            for (int i = 1; i <= n; i++)
            {
                acumulador = acumulador * i;
                // Dica: você também pode escrever isso como: acumulador *= i;
            }

            return acumulador;
        }
    }
}