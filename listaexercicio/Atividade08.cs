using System;

namespace ListaExercicios
{
    public class Exercicio08
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 08: CALCULADORA DE POTÊNCIA ===");

            Console.Write("Digite o valor da Base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            // Usamos 'long' para o resultado, pois potências crescem muito rápido
            long resultado = CalcularPotencia(baseNum, expoente);

            Console.WriteLine($"\nResultado: {baseNum} elevado a {expoente} = {resultado}");
        }

        // Função que calcula a potência usando apenas multiplicação
        private long CalcularPotencia(int baseNum, int expoente)
        {
            long acumulador = 1;

            // O laço roda a quantidade de vezes definida no expoente
            for (int i = 1; i <= expoente; i++)
            {
                acumulador = acumulador * baseNum;
            }

            return acumulador;
        }
    }
}