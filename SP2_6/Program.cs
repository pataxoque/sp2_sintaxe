double[] temperaturas = new double[7];
double somaTemp = 0;

// Leitura
for (int i = 0; i < 7; i++)
{
    Console.Write($"Digite a temperatura do dia {i + 1}: ");
    temperaturas[i] = double.Parse(Console.ReadLine());
}

// Cálculo da Média com foreach
foreach (double temp in temperaturas)
{
    somaTemp += temp;
}
double media = somaTemp / 7;
Console.WriteLine($"\nMédia da semana: {media:F2}");

// Verificação acima da média
Console.WriteLine("Temperaturas acima da média:");
foreach (double temp in temperaturas)
{
    if (temp > media) Console.WriteLine(temp);
}