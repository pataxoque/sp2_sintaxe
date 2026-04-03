Console.Write("Quantos termos da sequência de Fibonacci você deseja ver? ");
int termos = int.Parse(Console.ReadLine());

int a = 0, b = 1;

for (int i = 0; i < termos; i++)
{
    Console.Write(a + " ");
    int proximo = a + b;
    a = b;
    b = proximo;
}