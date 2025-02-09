int n = int.Parse(Console.ReadLine());

int resultado = 0;

for (int i= 0; i < n; i++)
{
    string[] vet = Console.ReadLine().Split(' ');

    int x = int.Parse(vet[0]);
    int y = int.Parse(vet[1]);

    if (y == 0)
    {
        Console.WriteLine("Divisao Impossivel");
    }
    else
    {
        resultado = x / y;
        Console.WriteLine(resultado);
    }
}