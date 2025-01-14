string[] vet = Console.ReadLine().Split(' ');

int x = int.Parse(vet[0]);
int y = int.Parse(vet[1]);

while (x != 0 & y != 0)
{
    Coordenadas(x, y);
    vet = Console.ReadLine().Split(' ');

    x = int.Parse(vet[0]);
    y = int.Parse(vet[1]);

}


void Coordenadas(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Quarto");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro");
    }
}