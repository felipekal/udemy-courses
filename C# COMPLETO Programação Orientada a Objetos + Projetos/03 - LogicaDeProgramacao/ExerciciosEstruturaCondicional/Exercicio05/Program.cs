string[] vet = Console.ReadLine().Split(' ');

int cod = int.Parse(vet[0]);
int quant = int.Parse(vet[1]);

double preco = 0;

if (cod == 1)
{
    preco = 4;

}
else if (cod == 2)
{
    preco = 4.5;
}
else if (cod == 3)
{
    preco = 5;
}
else if (cod == 4)
{
    preco = 2;
}
else if (cod == 5)
{
    preco = 1.50;
}
else
{
    Console.WriteLine("Codigo Invalido");
}

double total = quant * preco;

Console.WriteLine($"Total: R$ {total}");