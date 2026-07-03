using System;

namespace ListaExercicios
{
    public class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 01: VERIFICADOR DE NÚMERO ===");
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("O número digitado é ZERO");
            }
            else if (numero > 0)
            {
                Console.WriteLine($"O número {numero} é POSITIVO");
            }
            else
            {
                Console.WriteLine($"O número {numero} é NEGATIVO");
            }
        }
    }
}