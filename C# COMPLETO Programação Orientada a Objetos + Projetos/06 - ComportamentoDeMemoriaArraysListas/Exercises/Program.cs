using Exercises;
Console.Write("Numero de quartos a serem reservados: ");
int n = int.Parse(Console.ReadLine());

Quarto[] quartos = new Quarto[10];

int quarto = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Aluguel #{i}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("E-mail: ");
    string mail = Console.ReadLine();
    Console.Write("Quarto: ");
    quarto = int.Parse(Console.ReadLine());

    quartos[quarto] = new Quarto(nome,mail,quarto);
}

Console.WriteLine("Quartos ocupados:");
for (int i = 0; i < 10; i++)
{
    if (quartos.Length != null)
    {
        Console.WriteLine(quartos[i]); 
    }    
}