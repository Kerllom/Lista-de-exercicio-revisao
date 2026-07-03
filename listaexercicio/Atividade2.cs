using System;

namespace ListaExercicios
{
    public class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 02: CALCULADORA DE MÉDIA ===");

            Console.Write("Digite a Nota 1 (0 a 10): ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota 2 (0 a 10): ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota 3 (0 a 10): ");
            double nota3 = double.Parse(Console.ReadLine());

            // Validação das notas
            if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10)
            {
                Console.WriteLine("Erro: Todas as notas devem estar entre 0 e 10.");
                return; // Encerra o método imediatamente se houver nota inválida
            }

            double media = CalcularMedia(nota1, nota2, nota3);
            Console.WriteLine($"\nMédia: {media:F2}");

            if (media >= 7.0)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else if (media >= 5.0)
            {
                Console.WriteLine("Situação: Recuperação");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");
            }
        }

        // Deixamos essa função como 'private' porque ela só é usada aqui dentro
        private double CalcularMedia(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }
    }
}