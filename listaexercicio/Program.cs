using System;

namespace ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criado o objeto do Exercício 01 e o executamos
            Exercicio01 ex1 = new Exercicio01();
            ex1.Executar();

            Console.WriteLine("\n-------------------------------------------\n");

            // Criado o objeto do Exercício 02 e o executamos
            Exercicio02 ex2 = new Exercicio02();
            ex2.Executar();

            Console.WriteLine("\n-------------------------------------------\n");

            // Criado
            Exercicio03 ex3 = new Exercicio03();
            Console.WriteLine("\n-------------------------------------------\n");
            ex3.Executar();

            // Criado 
            Exercicio04 ex4 = new Exercicio04();
            Console.WriteLine("\n-------------------------------------------\n");
            ex4.Executar();

            // Criado
            Exercicio05 ex5 = new Exercicio05();
            Console.WriteLine("\n-------------------------------------------\n");
            ex5.Executar();

            // Criado
            Exercicio06 ex6 = new Exercicio06();
            Console.WriteLine("\n-------------------------------------------\n");
            ex6.Executar();

            // Criado 
            Exercicio07 ex7 = new Exercicio07();
            Console.WriteLine("\n-------------------------------------------\n");
            ex7.Executar();

            // Criado
            Exercicio08 ex8 = new Exercicio08();
            Console.WriteLine("\n-------------------------------------------\n");
            ex8.Executar();

            // Criado
            Exercicio09 ex9 = new Exercicio09();
            Console.WriteLine("\n-------------------------------------------\n");
            ex9.Executar();

            // Criado
            Exercicio10 ex10 = new Exercicio10();
            Console.WriteLine("\n-------------------------------------------\n");
            ex10.Executar();
            Console.ReadKey(); // Mantém o console aberto no final
        }
    }
}