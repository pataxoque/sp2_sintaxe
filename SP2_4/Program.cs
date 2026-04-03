Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());
int divisores = 0;

for (int i = 1; i <= num; i++)
{
    if (num % i == 0) divisores++;
}

if (divisores == 2)
    Console.WriteLine($"{num} é um número primo.");
else
    Console.WriteLine($"{num} não é um número primo.");