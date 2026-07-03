using System;

namespace ListaExercicios
{
    public class Exercicio10
    {
        public void Executar()
        {
            // Variável que controla a vida do nosso menu
            bool continuar = true;

            // O 'do' garante que o menu apareça pelo menos a primeira vez
            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                // Se o usuário escolher 5, já encerramos e nem pedimos os números
                if (opcao == 5)
                {
                    Console.WriteLine("Saindo do programa... Até logo!");
                    continuar = false;
                    continue; // Pula para o final do laço ignorando o código abaixo
                }

                // Se digitou uma opção inválida
                if (opcao < 1 || opcao > 5)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    continue;
                }

                Console.Write("Operando 1: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Operando 2: ");
                double num2 = double.Parse(Console.ReadLine());

                // A estrutura 'switch' substitui um monte de 'if/else'
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1} + {num2} = {Somar(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1} - {num2} = {Subtrair(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1} * {num2} = {Multiplicar(num1, num2)}");
                        break;
                    case 4:
                        // Tratamento da Divisão por Zero
                        if (num2 == 0)
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {num1} / {num2} = {Dividir(num1, num2)}");
                        }
                        break;
                }

            } while (continuar); // Fica repetindo enquanto continuar for 'true'
        }

        // --- Funções Matemáticas ---
        private double Somar(double a, double b)
        {
            return a + b;
        }

        private double Subtrair(double a, double b)
        {
            return a - b;
        }

        private double Multiplicar(double a, double b)
        {
            return a * b;
        }

        private double Dividir(double a, double b)
        {
            return a / b;
        }
    }
}