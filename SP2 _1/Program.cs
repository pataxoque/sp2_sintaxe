using System;

class Program
{
    static void Main()
    {
        // 1. Inicializamos os contadores
        int pares = 0;
        int impares = 0;
        int numero;

        Console.WriteLine("--- Contagem de Pares e Ímpares ---");
        Console.Write("Digite um número (ou 0 para sair): ");
        
        // 2. Leitura inicial
        numero = int.Parse(Console.ReadLine());

        // 3. Laço while: repete ENQUANTO o número for diferente de 0
        while (numero != 0)
        {
            // Verificamos se o resto da divisão por 2 é zero
            if (numero % 2 == 0)
            {
                pares++; // Incrementa 1 ao contador de pares
            }
            else
            {
                impares++; // Incrementa 1 ao contador de ímpares
            }

            // Pede o próximo número para continuar ou sair do laço
            Console.Write("Digite o próximo número (ou 0 para sair): ");
            numero = int.Parse(Console.ReadLine());
        }

        // 4. Exibição dos resultados finais
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Atividade Concluída!");
        Console.WriteLine("Total de números pares: " + pares);
        Console.WriteLine("Total de números ímpares: " + impares);
        Console.WriteLine("-----------------------------------");
    }
}