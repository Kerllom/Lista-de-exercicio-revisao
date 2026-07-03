using System;

namespace ListaExercicios
{
    public class Exercicio07
    {
        public void Executar()
        {
            Console.WriteLine("=== EXERCÍCIO 07: SISTEMA DE LOGIN ===");

            // 1. Nossa "Bandeira" (Flag) de estado
            bool acessoLiberado = false;
            int maxTentativas = 3;

            // 2. O laço que permite até 3 tentativas
            for (int tentativa = 1; tentativa <= maxTentativas; tentativa++)
            {
                Console.Write($"\nTentativa {tentativa} - Digite a Senha: ");
                string senhaDigitada = Console.ReadLine();

                // 3. Chamamos a função para verificar a senha
                if (VerificarSenha(senhaDigitada))
                {
                    Console.WriteLine("Acesso liberado! Bem-vindo(a)!");
                    acessoLiberado = true; // Levantamos a bandeira de sucesso
                    break; // Interrompe o laço imediatamente
                }
                else
                {
                    int tentativasRestantes = maxTentativas - tentativa;

                    // Só exibimos a mensagem se ainda houver tentativas sobrando
                    if (tentativasRestantes > 0)
                    {
                        Console.WriteLine($"Senha incorreta. Tentativas restantes: {tentativasRestantes}");
                    }
                }
            }

            // 4. Fora do laço, verificamos a bandeira para saber como tudo terminou
            if (acessoLiberado == false) // Ou simplesmente: if (!acessoLiberado)
            {
                Console.WriteLine("\nAcesso bloqueado! Entre em contato com o suporte.");
            }
        }

        // Função separada que valida a senha (escondendo a senha real do fluxo principal)
        private bool VerificarSenha(string senha)
        {
            // Definimos a senha correta apenas aqui dentro
            string senhaCorreta = "1234";

            // Retorna verdadeiro se a senha digitada for igual à correta
            return senha == senhaCorreta;
        }
    }
}