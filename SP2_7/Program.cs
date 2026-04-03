List<string> compras = new List<string>();
string entrada = "";

while (true)
{
    Console.Write("Digite o nome do produto (ou 'fim' para encerrar): ");
    entrada = Console.ReadLine();

    if (entrada.ToLower() == "fim") break;

    compras.Add(entrada);
}

compras.Sort(); // Ordena alfabeticamente

Console.WriteLine("\nProdutos que começam com 'A':");
foreach (string item in compras)
{
    if (item.ToUpper().StartsWith("A"))
    {
        Console.WriteLine(item);
    }
}