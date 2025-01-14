int n = int.Parse(Console.ReadLine());

int dentro = 0;
int fora = 0;

for (int i = 0; i < n; i++)
{
    Console.Write("Insira o valor: ");
    int valor = int.Parse(Console.ReadLine());

    if (valor >= 10 & valor <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }

}

Console.WriteLine($"{dentro} In");
Console.WriteLine($"{fora} Out");