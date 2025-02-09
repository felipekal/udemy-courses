
Pessoa A = new Pessoa();
Pessoa B = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
A.Nome = Console.ReadLine();
Console.Write("Idade: ");
A.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
B.Nome = Console.ReadLine();
Console.Write("Idade: ");
B.Idade = int.Parse(Console.ReadLine());


if (B.Idade > A.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {B.Nome}");
}
else
{
    Console.WriteLine($"Pessoa mais velha: {A.Nome}");
}


public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

}
