
Funcionario A = new Funcionario();
Funcionario B = new Funcionario();

Console.WriteLine("Dados do Primeiro Funcionario: ");
Console.Write("Nome: ");
A.Nome = Console.ReadLine();
Console.Write("Salario: ");
A.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados do Segundo Funcionario: ");
Console.Write("Nome: ");
B.Nome = Console.ReadLine();
Console.Write("Salario: ");
B.Salario = double.Parse(Console.ReadLine());


double mediaSalario = A.Salario + B.Salario / 2;

Console.WriteLine($"Salario medio = {mediaSalario}");

class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }


}