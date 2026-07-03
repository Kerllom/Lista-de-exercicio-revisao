using System;

namespace ListaExercicios
{
    public class Exercicio09
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 09: NÚMEROS PRIMOS NO INTERVALO ===");

            Console.Write("Digite o número inicial do intervalo: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Digite o número final do intervalo: ");
            int fim = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nNúmeros primos entre {inicio} e {fim}:");

            // Chamamos o procedimento para fazer o trabalho pesado
            ExibirPrimos(inicio, fim);
        }

        // Procedimento que varre o intervalo e exibe os resultados
        private void ExibirPrimos(int inicio, int fim)
        {
            int totalPrimos = 0;

            for (int i = inicio; i <= fim; i++)
            {
                if (EhPrimo(i))
                {
                    Console.Write($"{i} ");
                    totalPrimos++; // Soma 1 no contador de primos
                }
            }

            // Quebra de linha e exibição do total
            Console.WriteLine($"\nTotal de primos encontrados: {totalPrimos}");
        }

        // Função otimizada para verificar se é primo
        private bool EhPrimo(int numero)
        {
            // Tratando os casos especiais: 0, 1 e números negativos não são primos
            if (numero < 2)
            {
                return false;
            }

            // Otimização matemática: verificar apenas até a raiz quadrada do número
            int limite = (int)Math.Sqrt(numero);

            for (int i = 2; i <= limite; i++)
            {
                if (numero % i == 0)
                {
                    // Se achou um divisor, quebra a função e devolve falso imediatamente
                    return false;
                }
            }

            // Se o laço rodou inteiro e não caiu no 'return false', então o número é primo!
            return true;
        }
    }
}