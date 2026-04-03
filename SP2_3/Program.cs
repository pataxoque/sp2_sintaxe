double soma = 0;

while (true)
{
    Console.WriteLine("Digite um número positivo (ou negativo para sair).");
    string entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Inválido, você não digitou nada.");
        continue;
    }

    double numero = double.Parse(entrada);

    if (numero < 0) break;

    soma += numero; 
}

Console.WriteLine($"Finalizado! o valor da soma é: {soma}");
