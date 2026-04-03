using System;

class Program
{
    static void Main()
    {
        // 1. Gerar o número aleatório entre 1 e 100
        Random gerador = new Random();
        int numeroCorreto = gerador.Next(1, 101); // O limite superior é exclusivo, por isso 101
        
        int palpite;
        
        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Eu escolhi um número entre 1 e 100. Tente adivinhar!");

        // 2. Início do laço Do While
        do
        {
            Console.Write("\nDigite seu palpite: ");
            
            // Converte a entrada do usuário de string para inteiro
            palpite = int.Parse(Console.ReadLine());

            // 3. Informar se o palpite foi maior ou menor
            if (palpite < numeroCorreto)
            {
                Console.WriteLine("O número correto é MAIOR do que " + palpite);
            }
            else if (palpite > numeroCorreto)
            {
                Console.WriteLine("O número correto é MENOR do que " + palpite);
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o número!");
            }

        // 4. Condição: continua enquanto o palpite for diferente do correto
        } while (palpite != numeroCorreto);

        Console.WriteLine("Fim de jogo. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}